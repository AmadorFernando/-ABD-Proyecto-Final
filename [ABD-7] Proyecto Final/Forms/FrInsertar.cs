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
    public partial class FrInsertar : Form
    {
        static DataTable LocalListaTablas;
        static DataTable LocalListaBD;
        static string LocalBDSeleccionada;
        string Tabla;
        static string mensaje = "";
        static string cadenaaux = "";
        //Esta variable guardara el ultimo click, para poder realizar el movimiento de la ventana.
        Point lastclick;

        public SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
        //public SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
        public FrInsertar(DataTable BDTablas, string BDSeleccionada, DataTable Listabd)
        {
            InitializeComponent();
            LocalListaTablas = BDTablas;
            LocalListaBD = Listabd;
            LocalBDSeleccionada = BDSeleccionada;
        }

        void InsertarDatos(DataTable Listado)
        {
            for (int i = 0; i < Listado.Rows.Count; i++)
            {
                cboxTablas.Items.Add(Listado.Rows[i][0]);
            }
        }

        private void FrInsertar_Load(object sender, EventArgs e)
        {
            dgvEliminar.Refresh();
            InsertarDatos(LocalListaTablas);
        }

        void InsertarDataGrid()
        {
            Tabla = cboxTablas.Text;
            SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
            //SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");

            //Conexion ConectarBD = new Conexion();
            Conexiones.Open();
            string Cadena = "SELECT * from " + Tabla;
            //Creamos el comando de SQL
            SqlCommand cmd = new SqlCommand(Cadena, Conexiones);
            //Generamos la tabla
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dgvEliminar.DataSource = dt;
            dgvEliminar.Refresh();
            Conexiones.Close();
        }

        private void cboxTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvEliminar.Rows.Count >= 1)
            {
                dgvEliminar.DataSource = null;
                dgvEliminar.Rows.Clear();
            }
            dgvEliminar.Refresh();
            InsertarDataGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Tabla = cboxTablas.Text;
                cadenaaux = txtCadena.Text;
                Conexiones.Open();
                string cadenaa = "use " + LocalBDSeleccionada + " insert into " + Tabla + " values (" + cadenaaux + ")";
                mensaje = mensaje + "Se a ingresado un registro a la tabla " + Tabla + ".\r\n";
                SqlCommand cmd = new SqlCommand(cadenaa, Conexiones);
                cmd.ExecuteNonQuery();
                Conexiones.Close();
                MessageBox.Show("El registro se completo con exito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InsertarDataGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo Salio Mal", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        public string Mensaje()
        {
            return mensaje;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (mensaje == "")
            {
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void pboxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("¿Estas seguro que quieres cerrar la pestaña?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
    }
}
