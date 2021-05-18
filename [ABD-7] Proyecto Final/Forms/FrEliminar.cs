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

namespace _ABD_7__Proyecto_Final.Forms
{
    public partial class FrEliminar : Form
    {
        static DataTable LocalLista;
        string Tabla;
        static string LocalBDSeleccionada;
        public FrEliminar(DataTable BDTablas, string BDSeleccionada)
        {
            InitializeComponent();
            LocalLista = BDTablas;
            LocalBDSeleccionada = BDSeleccionada;
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            InsertarDatos();

            btnMostrar.Visible = true;
            btnRegistros.Visible = false;
            btnTabla.Visible = false;
        }

        private void FrEliminar_Load(object sender, EventArgs e)
        {
            
        }

        void InsertarDatos()
        {
            for (int i = 0; i < LocalLista.Rows.Count; i++)
            {
                cboxTablas.Items.Add(LocalLista.Rows[i][0]);
            }
        }

        private void cboxTablas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Tabla = cboxTablas.Text;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cboxTablas.Text != "" && Tabla != "")
            {
                SqlConnection Conexiones7 = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");

                Conexion ConectarBD = new Conexion();
                ConectarBD.Conexiones.Open();
                string Cadena = "SELECT * from " + Tabla;
                //Creamos el comando de SQL
                SqlCommand cmd = new SqlCommand(Cadena, Conexiones7);
                //Generamos la tabla
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dr.Fill(dt);
                dataGridView1.DataSource = dt;
                ConectarBD.Conexiones.Close();
            }
            else
            {
                MessageBox.Show("Selecciona una Tabla");
            }
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            InsertarDatos();
            btnRegistros.Visible = false;
        }
    }
}
