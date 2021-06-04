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
    public partial class FrCrear : Form
    {
        static string LocalBD="";
        static string mensaje = "";
        //Esta variable guardara el ultimo click, para poder realizar el movimiento de la ventana.
        Point lastclick;

        public FrCrear(string BD)
        {
            InitializeComponent();
            LocalBD = BD;
        }
        public SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBD + ";Integrated Security= True");
        //public SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBD + ";Integrated Security= True");
        private void FrCrear_Load(object sender, EventArgs e)
        {
            cboxObjeto.Items.Clear();
            cboxObjeto.ResetText();
            if (LocalBD == "master")
            {
                cboxObjeto.Items.Add("Base de Datos");
            }
            else
            {
                cboxObjeto.Items.Add("Base de Datos");
                cboxObjeto.Items.Add("Tabla");
            }

        }

        private void cboxObjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxObjeto.Text == "Base de Datos")
            {
                //Limpiamos el datagridview
                dgvCrear.Rows.Clear();
                dgvCrear.Refresh();
                //Disminuimos el taman~o del formulario
                this.Height =200;
                this.Width =600;
                //Cambiamos la localizacion de los botones
                btnCrear.Location = new Point(48, 96);
                btnCancelar.Location = new Point(398, 96);
                //Hacemos visible el label y textbox y invisible el datagridview
                dgvCrear.Visible = false;
                lblLlamada.Visible = true;
                txtNombre.Visible = true;
                btnCrear.Visible = true;
            }
            else if (cboxObjeto.Text == "Tabla")
            {
                //Limpiamos el datagridview
                dgvCrear.Rows.Clear();
                dgvCrear.Refresh();
                //Aumentamos el taman~o del formulario
                this.Height = 400;
                this.Width = 600;
                //Cambiamos la localizacion de los botones
                btnCrear.Location = new Point(48, 280);
                btnCancelar.Location = new Point(398,280);
                //Hacemos visible el datagridview, label y textbox
                dgvCrear.Visible = true;
                lblLlamada.Visible = true;
                txtNombre.Visible = true;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            switch (cboxObjeto.Text)
            {
                case "Base de Datos":
                    CrearBaseDatos();
                    break;
                case "Tabla":
                    CrearTabla();
                    break;
                default:
                    MessageBox.Show("Selecciona una opcion","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    break;
            }
        }

        void CrearBaseDatos()
        {
            //Verificamos que no este en blanco
            if (String.IsNullOrWhiteSpace(txtNombre.Text) == false)
            {
                //Trycatch para confirmar que no vaya haber errores al usar el comando (Ejemplo: que ya exista la BD)
                try
                {
                    //Conexion ConectarBD = new Conexion();
                    Conexiones.Open();
                    string Cadena = "Create database " + txtNombre.Text;
                    //Creamos el comando de SQL
                    SqlCommand cmd = new SqlCommand(Cadena, Conexiones);
                    cmd.ExecuteNonQuery();
                    Conexiones.Close();
                    MessageBox.Show("La Base de Datos " + txtNombre.Text + " se ha creado correctamente.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    mensaje = "La Base de Datos " + txtNombre.Text + " se ha creado correctamente.";
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Esa base de datos ya existe.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                if (txtNombre.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Agrega un nombre para la Base de Datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Elimina los espacios para poder agregar la Base de Datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        void CrearTabla()
        {
            //Verificamos que no este en blanco
            if (String.IsNullOrWhiteSpace(txtNombre.Text) == false)
            {
                string textoAux = "";
                int LlaveAux = 0;
                
                //Trycatch para confirmar que no vaya haber errores al usar el comando (Ejemplo: que ya exista la BD)
                try
                {
                    for (int i = 0; i < dgvCrear.RowCount - 1; i++)
                    {
                        //Tomamos el nombre
                        textoAux =textoAux+ dgvCrear.Rows[i].Cells[0].Value.ToString()+" ";
                        //Tomamos el tipo de dato
                        textoAux = textoAux + dgvCrear.Rows[i].Cells[1].Value.ToString()+" ";
                        //Tomamos si es null o no
                        if (Convert.ToBoolean(dgvCrear.Rows[i].Cells[2].Value) == true)
                        {
                            textoAux = textoAux + " NOT NULL";
                        }
                        else
                        {
                            textoAux = textoAux + " NULL";
                        }
                        //Tomaos si es primary key o no
                        if (Convert.ToBoolean(dgvCrear.Rows[i].Cells[3].Value) == true)
                        {
                            textoAux = textoAux + " PRIMARY KEY,";
                            LlaveAux++;
                        }
                        else
                        {
                            textoAux = textoAux + ", ";
                        }

                        if (LlaveAux>1)
                        {
                            MessageBox.Show("Solo puedes tener una Llave primaria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            break;
                        }
                    }
                    if (LlaveAux <= 1)
                    {
                        //Conexion ConectarBD = new Conexion();
                        Conexiones.Open();
                        //Aqui se usa "Use" ya que aun que se indique que la BD, el programa usa "Master" por default.
                        string Cadena = "use " + LocalBD + ";create table " + txtNombre.Text + "(" + textoAux + ")";
                        //Creamos el comando de SQL
                        var cmd = new SqlCommand();
                        cmd.Connection = Conexiones;
                        cmd.CommandText = Cadena;
                        //SqlCommand cmd = new SqlCommand(Cadena, Conexiones);
                        cmd.ExecuteNonQuery();
                        Conexiones.Close();
                        MessageBox.Show("La Tabla " + txtNombre.Text + " se ha creado correctamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        mensaje = "La Tabla " + txtNombre.Text + " se ha creado correctamente";
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo salio mal.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Mensaje()
        {
            return mensaje;
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("¿Estas seguro que quieres cerrar la pestaña?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pboxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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