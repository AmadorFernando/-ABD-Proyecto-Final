using _ABD_7__Proyecto_Final.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ABD_7__Proyecto_Final
{
    public partial class Form1 : Form
    {
        //LISTADO BD
        static DataTable ListadoBD;
        static string BDUsada="master";
        static DataTable ListadoTablas;
        //Conexiones SQL
        public SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog="+BDUsada+";Integrated Security= True");
        //public SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");

        //Esta variable guardara el ultimo click, para poder realizar el movimiento de la ventana.
        Point lastclick;

        public Form1()
        {
            Thread.Sleep(5000);
            InitializeComponent();

        }
        public void Iniciar()
        {
            Application.Run(new FrPantallaCarga());
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            TreeView();
        }

        public void TreeView()
        {
            string Cadena = "SELECT name FROM master.dbo.sysdatabases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";
            //Creamos el comando de SQL
            Conexiones.Open();
            SqlCommand cmd = new SqlCommand(Cadena,Conexiones);
            //Generamos la tabla
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            Conexiones.Close();

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
                    Conexiones.Open();
                    SqlCommand cmdAux2 = new SqlCommand(Cadena, Conexiones);
                    SqlDataAdapter drAux2 = new SqlDataAdapter(cmdAux2);
                    DataTable dtAux2 = new DataTable();
                    drAux2.Fill(dtAux2);
                    Conexiones.Close();
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
            //Conexion ConectarBD = new Conexion();
            string Cadena = "SELECT TABLE_NAME FROM " + nodo + ".INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            Conexiones.Open();
            SqlCommand cmdAux = new SqlCommand(Cadena, Conexiones);
            SqlDataAdapter drAux = new SqlDataAdapter(cmdAux);
            DataTable dtAux = new DataTable();
            drAux.Fill(dtAux);
            Conexiones.Close();
            return dtAux;
        }
        public void GuardarInfo(DataTable listaBD,int Aux)
        {
            ListadoBD = listaBD;
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            //Abrimos el formulario para seleccionar la BD
            FrUsarBD FrUsar = new FrUsarBD(ListadoBD);
            FrUsar.ShowDialog();
            
            //Condicion para saber si selecciono o no una BD
            if (FrUsar.LocalBDUsada != "")
            {
                //Se guarda el valor que devuelve la seleccion en el formulario
                BDUsada = FrUsar.LocalBDUsada;
                MessageBox.Show("Se ha selecionado la Base de Datos: " + BDUsada, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Cambiamos el nombre del formulario principal
                 lblTitulo.Text = "ABD Software - Base de Datos:  "+BDUsada;
                //Se cambia el nombre al boton para dar mas detalle
                btnUsar.Text = "CAMBIAR";
                //Se agrega a la consola lo que se realizo.
                txtComandos.Text = txtComandos.Text + "Se ha usado la Base de Datos "+ BDUsada +".\r\n";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Abrimos el formulario y mandamos los valores
            FrEliminar frEliminar = new FrEliminar(ObtenerTablasBD(BDUsada),BDUsada,ListadoBD);
            var respuesta = frEliminar.ShowDialog();
            if (respuesta == DialogResult.OK && frEliminar.Mensaje() != "")
            {
                txtComandos.Text = txtComandos.Text + frEliminar.Mensaje() + "\r\n";
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrCrear frCrear;
            if (BDUsada=="")
            {
                frCrear = new FrCrear("");
            }
            else
            {
                frCrear = new FrCrear(BDUsada);
            }
            var respuesta=frCrear.ShowDialog();
            if (respuesta==DialogResult.OK && frCrear.Mensaje()!="")
            {
                txtComandos.Text = txtComandos.Text + frCrear.Mensaje() + ".\r\n";
            }
        }

        private void pboxRefrescar_Click(object sender, EventArgs e)
        {
            //Limpiamos los nodos para que no se repitan visualmente
            treeView1.Nodes.Clear();
            TreeView();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            FrBuscador frbuscador = new FrBuscador(ObtenerTablasBD(BDUsada),BDUsada);
            frbuscador.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrModificar frModificar = new FrModificar(ObtenerTablasBD(BDUsada), BDUsada, ListadoBD);
            frModificar.ShowDialog();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrInsertar frInsertar = new FrInsertar(ObtenerTablasBD(BDUsada), BDUsada, ListadoBD);
            var respuesta = frInsertar.ShowDialog();
            if (respuesta == DialogResult.OK && frInsertar.Mensaje() != "")
            {
                txtComandos.Text = txtComandos.Text + frInsertar.Mensaje() + "\r\n";
            }
        }

        private void pboxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("¿Estas seguro que quieres cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }

    }
}
