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
    public partial class FrModificar : Form
    {
        private BindingSource bindingsource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        static DataTable LocalListaTablas;
        static DataTable LocalListaBD;
        static string LocalBDSeleccionada;
        string Tabla;
        static string mensaje = "";
        static string cadenaaux = "";
        //Esta variable guardara el ultimo click, para poder realizar el movimiento de la ventana.
        Point lastclick;

        //public SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
        public SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
        public FrModificar(DataTable BDTablas, string BDSeleccionada, DataTable Listabd)
        {
            InitializeComponent();
            LocalListaTablas = BDTablas;
            LocalListaBD = Listabd;
            LocalBDSeleccionada = BDSeleccionada;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Tabla = cboxTablas.Text;
            string variable = txtVariable.Text;
            if (cboxTablas.Text != "")
            {
                switch (cboxObjeto.Text)
                {
                    case "Tabla":
                        ModificarTabla();
                        break;

                    case "Registro":
                        ModificarRegistro();
                        break;

                    default:
                        break;

                }
            }
            void ModificarRegistro()
            {
                SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
                //SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
                Conexiones.Open();
                string cadena = "";
                cadena = " update " + Tabla + " set " + txtColumna.Text + "=" + txtCambiar.Text + " where " + dgvEliminar.Columns[0].Name + "=" + dgvEliminar.SelectedCells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand(cadena, Conexiones);
                cmd.ExecuteNonQuery();
                Conexiones.Close();
                MessageBox.Show("Se modifico la tabla con exito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEliminar.Refresh();
            }

            void ModificarTabla()
            {
                SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
                //SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
                Conexiones.Open();
                string cadena = "";
                switch (cboxAccion.Text)
                {
                    case "ADD":
                        //No
                        cadenaaux = txtVariable.Text + " " + txtTipoDato.Text;
                        cadena = " Alter Table " + Tabla + " add " + cadenaaux;
                        mensaje = mensaje + "Se a añadido una columna a la tabla " + Tabla;
                        break;

                    case "CHANGE":
                        //No
                        cadenaaux = txtVariable.Text + " " + txtTipoDato.Text + "";
                        cadena = " Alter Table " + Tabla + " alter column " + txtVariable.Text + " " + txtTipoDato;
                        mensaje = mensaje + "Se a modificado una columna a la tabla " + Tabla;
                        break;

                    case "DROP":
                        //Si
                        cadena = "use " + LocalBDSeleccionada + " Alter Table " + Tabla + " DROP COLUMN " + txtVariable.Text;
                        mensaje = mensaje + "Se a eliminado una columna a la tabla " + Tabla;
                        break;

                    default:
                        break;
                }

                SqlCommand cmd = new SqlCommand(cadena, Conexiones);
                cmd.ExecuteNonQuery();
                Conexiones.Close();
                MessageBox.Show("Se modifico la tabla con exito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEliminar.Refresh();
            }
        }

        private void cboxTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tabla = cboxTablas.Text;
            InsertarDataGrid();
        }

        private void cboxAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxAccion.Text == "ADD")
            {
                lblTipo.Visible = true;
                txtTipoDato.Visible = true;
            }
            else if (cboxAccion.Text == "CHANGE")
            {
                lblTipo.Visible = true;
                txtTipoDato.Visible = true;
            }
            else//Y Drop
            {

            }
        }

        private void FrModificar_Load(object sender, EventArgs e)
        {
            cboxObjeto.Items.Clear();
            cboxObjeto.ResetText();
            if (LocalBDSeleccionada == "master")
            {
                cboxObjeto.Items.Add("Tabla");
            }
            else
            {
                cboxObjeto.Items.Add("Tabla");
                cboxObjeto.Items.Add("Registro");
            }
        }

        private void cboxObjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxObjeto.Text == "Tabla")
            {
                //Limpiamos el datagridview
                if (dgvEliminar.Rows.Count >= 1)
                {
                    dgvEliminar.DataSource = null;
                    dgvEliminar.Rows.Clear();
                }
                dgvEliminar.Refresh();
                //Hacemos visible el datagridview, label y textbox
                dgvEliminar.Visible = true;
                cboxTablas.Items.Clear();
                //Agregamos al combobox los items (Listado de Tablas)
                InsertarDatos(LocalListaTablas);
                cboxAccion.Visible = true;
                lblAccion.Visible = true;
                lblVariable.Visible = true;
                txtVariable.Visible = true;
                lblCambiar.Visible = false;
                txtCambiar.Visible = false;
                lblNuevoDato.Visible = false;
                txtColumna.Visible = false;
                cboxAccion.Items.Add("ADD");
                cboxAccion.Items.Add("CHANGE");
                cboxAccion.Items.Add("DROP");
                this.Height = 448;
                this.Width = 743;
            }
            else //Registro
            {
                if (dgvEliminar.Rows.Count >= 1)
                {
                    dgvEliminar.DataSource = null;
                    dgvEliminar.Rows.Clear();
                }
                dgvEliminar.Refresh();
                //Hacemos visible el datagridview, label y textbox
                dgvEliminar.Visible = true;
                cboxTablas.Items.Clear();
                //Agregamos al combobox los items (Listado de Tablas)
                InsertarDatos(LocalListaTablas);
                this.Height = 448;
                this.Width = 658;
                lblCambiar.Visible = true;
                txtCambiar.Visible = true;
                lblNuevoDato.Visible = true;
                txtColumna.Visible = true;
                cboxAccion.Visible = false;
                lblAccion.Visible = false;
                lblVariable.Visible = false;
                txtVariable.Visible = false;

                if (dgvEliminar.Rows.Count >= 1)
                {
                    dgvEliminar.DataSource = null;
                    dgvEliminar.Rows.Clear();
                }
                dgvEliminar.Refresh();
            }
        }

        void InsertarDataGrid()
        {

            SqlConnection Conexiones7 = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");

            //SqlConnection Conexiones7 = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
            //Conexion ConectarBD = new Conexion();
            Conexiones.Open();
            string Cadena = "SELECT * from " + Tabla;
            //Creamos el comando de SQL
            SqlCommand cmd = new SqlCommand(Cadena, Conexiones7);
            //Generamos la tabla
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dgvEliminar.DataSource = dt;
            dgvEliminar.Refresh();
            Conexiones.Close();
        }
        void InsertarDatos(DataTable Listado)
        {
            for (int i = 0; i < Listado.Rows.Count; i++)
            {
                cboxTablas.Items.Add(Listado.Rows[i][0]);
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
    }
}
