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
        static DataTable LocalListaTablas;
        static DataTable LocalListaBD;
        static string LocalBDSeleccionada;
        string Tabla;
        static string mensaje="";
        //Esta variable guardara el ultimo click, para poder realizar el movimiento de la ventana.
        Point lastclick;
        public SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
        //public SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
        public FrEliminar(DataTable BDTablas, string BDSeleccionada, DataTable Listabd)
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

        void InsertarDataGrid()
        {
            SqlConnection Conexiones7 = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
            //SqlConnection Conexiones7 = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
            
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
        private void cboxTablas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Tabla = cboxTablas.Text;
            if (cboxObjeto.Text=="Registros")
            {
                //Limpiamos el datagridview
                if (dgvEliminar.Rows.Count >= 1)
                {
                    dgvEliminar.DataSource = null;
                    dgvEliminar.Rows.Clear();
                }
                dgvEliminar.Refresh();
                //Aumentamos el taman~o del formulario
                this.Height = 400;
                this.Width = 600;
                //Cambiamos la localizacion de los botones
                btnEliminar.Location = new Point(48, 280);
                btnCancelar.Location = new Point(398, 280);
                //Hacemos visible el datagridview, label y textbox
                dgvEliminar.Visible = true;
                //cboxTablas.Items.Clear();
                InsertarDataGrid();
                //lblLlamada.Visible = true;
                //cboxTablas.Visible = true;
            }
        }

        private void cboxObjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxObjeto.Text == "Base de Datos")
            {
                //Limpiamos el datagridview
                if (dgvEliminar.Rows.Count >= 1)
                {
                    dgvEliminar.DataSource = null;
                    dgvEliminar.Rows.Clear();
                }
                dgvEliminar.Refresh();
                //Disminuimos el taman~o del formulario
                this.Height = 200;
                this.Width = 600;
                //Cambiamos la localizacion de los botones
                btnEliminar.Location = new Point(48, 96);
                btnCancelar.Location = new Point(398, 96);
                //Hacemos visible el label y textbox y invisible el datagridview
                dgvEliminar.Visible = false;
                cboxTablas.Items.Clear();
                //Agregamos al combobox los items (Listado de Base de datos)
                InsertarDatos(LocalListaBD);
                lblLlamada.Visible = true;
                cboxTablas.Visible = true;
                btnEliminar.Visible = true;
            }
            else if (cboxObjeto.Text == "Tabla")
            {
                //Limpiamos el datagridview
                if (dgvEliminar.Rows.Count >= 1)
                {
                    dgvEliminar.DataSource = null;
                    dgvEliminar.Rows.Clear();
                }
                dgvEliminar.Refresh();
                //Aumentamos el taman~o del formulario
                this.Height = 200;
                this.Width = 600;
                //Cambiamos la localizacion de los botones
                btnEliminar.Location = new Point(48, 96);
                btnCancelar.Location = new Point(398, 96);
                //Hacemos visible el datagridview, label y textbox
                dgvEliminar.Visible = false;
                cboxTablas.Items.Clear();
                //Agregamos al combobox los items (Listado de Tablas)
                InsertarDatos(LocalListaTablas);
                lblLlamada.Visible = true;
                cboxTablas.Visible = true;
                btnEliminar.Visible = true;
            }
            else //REGISTROS
            {
                //Limpiamos el datagridview
                if (dgvEliminar.Rows.Count>=1)
                {
                    dgvEliminar.DataSource = null;
                    dgvEliminar.Rows.Clear();
                }
                dgvEliminar.Refresh();
                //Aumentamos el taman~o del formulario
                this.Height = 200;
                this.Width = 600;
                //Cambiamos la localizacion de los botones
                btnEliminar.Location = new Point(48, 96);
                btnCancelar.Location = new Point(398, 96);
                //Hacemos visible el datagridview, label y textbox
                dgvEliminar.Visible = false;
                cboxTablas.Items.Clear();
                //Agregamos al combobox los items (Listado de Tablas)
                InsertarDatos(LocalListaTablas);
                lblLlamada.Visible = true;
                lblLlamada.Text = "DE LA TABLA:";
                lblLlamada.Font = new Font(lblLlamada.Font.Name, 12.0f, lblLlamada.Font.Style, lblLlamada.Font.Unit);
                cboxTablas.Visible = true;
                btnEliminar.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (mensaje=="")
            {
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboxTablas.Text != "")
            {
                switch (cboxObjeto.Text)
                {
                    case "Base de Datos":
                        Eliminar(1);
                        break;
                    case "Registros":
                        Eliminar(2);
                        break;
                    case "Tablas":
                        Eliminar(3);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Selecciona una opcion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        void Eliminar(int num)
        {
            SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
            //SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDSeleccionada + ";Integrated Security= True");
            //Conexion ConectarBD = new Conexion();
            Conexiones.Open();
            string Cadena = "";
            switch (num)
            {
                case 1:
                    Cadena ="Drop database " + Tabla+";";
                    mensaje = mensaje + "Se ha eliminado la Base de Datos " + Tabla+ ".\r\n";
                    break;
                case 2:
                    Cadena = ";delete from " + Tabla+ " where "+dgvEliminar.Columns[0].Name+"="+ dgvEliminar.SelectedCells[0].Value.ToString();
                    mensaje = mensaje + "Se ha eliminado el Registro de la tabla: " + Tabla+" registro: #"+ dgvEliminar.SelectedCells[0].Value.ToString()+ ".\r\n";
                    break;
                case 3:
                    Cadena = "use " + LocalBDSeleccionada + "Drop table " + Tabla + ";";
                    mensaje =mensaje+ "Se ha eliminado la Tabla " + Tabla+ ".\r\n";
                    break;
                default:
                    break;
            }

            //Creamos el comando de SQL
            SqlCommand cmd = new SqlCommand(Cadena, Conexiones);
            //Generamos la tabla
            cmd.ExecuteNonQuery();
            Conexiones.Close();
            if (num==2)
            {
                InsertarDataGrid();
            }
        }

        public string Mensaje()
        {
            return mensaje;
        }

        private void Limpiar()
        {
            dgvEliminar.DataSource = null;
            dgvEliminar.Rows.Clear();
            dgvEliminar.Refresh();
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
