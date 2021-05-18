using _ABD_7__Proyecto_Final.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ABD_7__Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //LISTADO BD
        static DataTable ListadoBD;
        static string BDUsada;
        static DataTable ListadoTablas;

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeView();
        }

        public void TreeView()
        {
            Conexion ConectarBD = new Conexion();
            ConectarBD.Conexiones.Open();
            string Cadena = "SELECT name FROM master.dbo.sysdatabases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";
            //Creamos el comando de SQL
            SqlCommand cmd = new SqlCommand(Cadena, ConectarBD.Conexiones);
            //Generamos la tabla
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            ConectarBD.Conexiones.Close();

            TreeView nodo = new TreeView();
            treeView1.BeginUpdate();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Agregado de BD al TreeView
                string nodoPrincipal = Convert.ToString(dt.Rows[i][0]);
                treeView1.Nodes.Add(nodoPrincipal);

                //CREAMOS COMANDO PARA CONSEGUIR LAS TABLAS DE LA BD
                DataTable dTAux=ObtenerTablasBD(nodoPrincipal);
                

                var node = treeView1.Nodes[i];
                for (int j = 0; j < dTAux.Rows.Count; j++)
                {
                    //Agregado de Tablas al TreeView
                    string nodoSecundario = Convert.ToString(dTAux.Rows[j][0]);
                    node.Nodes.Add(nodoSecundario);

                    //CREAMOS COMANDO PARA CONSEGUIR LAS COLUMNAS DE LA BD
                    Cadena = "select COLUMN_NAME from " + nodoPrincipal + ".INFORMATION_SCHEMA.COLUMNS";
                    ConectarBD.Conexiones.Open();
                    SqlCommand cmdAux2 = new SqlCommand(Cadena, ConectarBD.Conexiones);
                    SqlDataAdapter drAux2 = new SqlDataAdapter(cmdAux2);
                    DataTable dtAux2 = new DataTable();
                    drAux2.Fill(dtAux2);
                    ConectarBD.Conexiones.Close();
                    var nodeDos = treeView1.Nodes[i].Nodes[j];

                    for (int k = 0; k < dtAux2.Rows.Count; k++)
                    {
                        string nodoTerciario = Convert.ToString(dtAux2.Rows[k][0]);
                        nodeDos.Nodes.Add(nodoTerciario);
                    }
                }
                GuardarInfo(dt,1);
            }
            treeView1.EndUpdate();

        }

        DataTable ObtenerTablasBD(string nodo)
        {
            Conexion ConectarBD = new Conexion();
            string Cadena = "SELECT TABLE_NAME FROM " + nodo + ".INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            ConectarBD.Conexiones.Open();
            SqlCommand cmdAux = new SqlCommand(Cadena, ConectarBD.Conexiones);
            SqlDataAdapter drAux = new SqlDataAdapter(cmdAux);
            DataTable dtAux = new DataTable();
            drAux.Fill(dtAux);
            ConectarBD.Conexiones.Close();
            return dtAux;
        }
        public void GuardarInfo(DataTable listaBD,int Aux)
        {
            ListadoBD = listaBD;
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            FrUsarBD FrUsar = new FrUsarBD(ListadoBD);
            FrUsar.ShowDialog();
            if (FrUsar.LocalBDUsada != "")
            {
                BDUsada = FrUsar.LocalBDUsada;
                MessageBox.Show("Se ha selecionado la Base de Datos: " + BDUsada, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUsar.Text = "CAMBIAR";
                txtComandos.Text = txtComandos.Text + "Se ha usado la Base de Datos "+ BDUsada +".\r\n";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrEliminar frEliminar = new FrEliminar(ObtenerTablasBD(BDUsada),BDUsada);
            frEliminar.ShowDialog();
        }
    }
}
