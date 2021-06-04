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
    public partial class FrBuscador : Form
    {
        DataTable LocalListaTablas;
        DataTable LocalListaColumnas;
        int LocalColumnasLimite;
        List<string> ColumnaSeleccionada= new List<string>();
        string LocalBDUsada;
        //Esta variable guardara el ultimo click, para poder realizar el movimiento de la ventana.
        Point lastclick;

        public FrBuscador(DataTable ListaTablas, string Bdusada)
        {
            InitializeComponent();

            LocalListaTablas = ListaTablas;
            LocalBDUsada = Bdusada;
        }
        public DataTable GenerarColumnas()
        {
            SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDUsada + ";Integrated Security= True");
            //SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDUsada + ";Integrated Security= True");

            //Conexion ConectarBD = new Conexion();
            Conexiones.Open();
            string Cadena = "use " + LocalBDUsada + ";SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ='" + cboxTablas.Text+"'";
            //Creamos el comando de SQL
            SqlCommand cmd = new SqlCommand(Cadena, Conexiones);
            //Generamos la tabla
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            Conexiones.Close();
            return dt;
        }
        void probar()
        {
            for (int i = 0; i < LocalListaTablas.Rows.Count; i++)
            {
                cboxTablas.Items.Add(LocalListaTablas.Rows[i][0]);
            }
            
        }

        private void FrBuscador_Load(object sender, EventArgs e)
        {
            probar();
            clbColumnas.ItemCheck += clbColumnas_ItemCheck;
        }

        private void cboxTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable aux=GenerarColumnas();
            clbColumnas.Items.Clear();
            LocalColumnasLimite = aux.Rows.Count;
            for (int i = 0; i < aux.Rows.Count; i++)
            {
                string aux2 = aux.Rows[i][0].ToString();
                clbColumnas.Items.Add(aux2);
            }
        }
        static string Antiguo = "";
        void Poner()
        {
            cboxColumnas.Items.Clear();
            cboxColumnas.ResetText();
            foreach (var item in ColumnaSeleccionada)
            {
                cboxColumnas.Items.Add(item);
            }
        }
        private void clbColumnas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //CheckedListBox clb = (CheckedListBox)sender;
            //// Switch off event handler
            //clb.ItemCheck -= clbColumnas_ItemCheck;
            //clb.SetItemCheckState(e.Index, e.NewValue);
            //// Switch on event handler
            //clb.ItemCheck += clbColumnas_ItemCheck;

            // Now you can go further
            //Poner();
            //this.BeginInvoke((MethodInvoker)(
            //() => MessageBox.Show((clbColumnas.SelectedItems.Count.ToString()))));
            //if (e.NewValue==CheckState.Checked && (clbColumnas.Items[e.Index].ToString()!=Antiguo))
            //{
            //    MessageBox.Show("Test");
            //    ColumnaSeleccionada.Add(clbColumnas.Items[e.Index].ToString());
            //    Antiguo = clbColumnas.Items[e.Index].ToString();
            //    Poner();
            //}
            //else
            //{
            //    MessageBox.Show("Test2");
            //    ColumnaSeleccionada.Remove(clbColumnas.Items[e.Index].ToString());
            //    Poner();
            //}
            //foreach (var Seleccion in clbColumnas.CheckedItems)
            //{
            //    ColumnaSeleccionada.Add(Seleccion.ToString());
            //    if (e.NewValue == CheckState.Checked)
            //    {
            //        ColumnaSeleccionada.Add(clbColumnas.Items[e.Index].ToString());
            //    }
            //    else
            //    {
            //        ColumnaSeleccionada.Remove(clbColumnas.Items[e.Index].ToString());
            //    }

            //}

            //cboxColumnas.Items.Clear();
            //cboxColumnas.ResetText();
            //foreach (var item in ColumnaSeleccionada)
            //{
            //    cboxColumnas.Items.Add(item);
            //}
        }

        private void cboxTodas_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbColumnas.Items.Count; i++)
            {
                if (cboxTodas.Checked==true)
                {
                    clbColumnas.SetItemChecked(i, true);
                }
                else
                {
                    clbColumnas.SetItemChecked(i, false);
                }
            }
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (lblDonde.Visible==false)
            {
                lblDonde.Visible = true;
                lblEs.Visible = true;
                lblA.Visible = true;
                cboxColumnas.Visible = true;
                cboxCondicionales.Visible = true;
                txtDato.Visible = true;
            }
            else
            {
                lblDonde.Visible = false;
                lblEs.Visible = false;
                lblA.Visible = false;
                cboxColumnas.Visible = false;
                cboxCondicionales.Visible = false;
                txtDato.Visible = false;

                cboxColumnas.Text = "";
                cboxCondicionales.Text = "";
                txtDato.Text = "";
            }
            cboxColumnas.Items.Clear();
            cboxColumnas.Refresh();
            foreach (var item in clbColumnas.CheckedItems)
            {
                cboxColumnas.Items.Add(item);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Confirmamos que tenemos la informacion minima necesaria
            if (cboxTablas.Text=="" || clbColumnas.CheckedItems.Count==0)
            {
                MessageBox.Show("Selecciona la informacion necesaria para realizar la busqueda.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {

                SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=" + LocalBDUsada + ";Integrated Security= True");
                //SqlConnection Conexiones = new SqlConnection("Data Source=PC-SHIDORI;Initial Catalog=" + LocalBDUsada + ";Integrated Security= True");
                string AuxCadena = "";
                string whereCondicion = "";
                
                //Busqueda Completa
                if (cboxColumnas.Text != "" && cboxCondicionales.Text != "" && txtDato.Text != "")
                {
                    whereCondicion ="where "+ cboxColumnas.Text + cboxCondicionales.Text + "'" + txtDato.Text + "'";
                }
                //Busqueda sencilla
                
                    if (LocalColumnasLimite == clbColumnas.CheckedItems.Count)
                    {
                        AuxCadena = "*";
                    }
                    else
                    {
                        foreach (var item in clbColumnas.CheckedItems)
                        {
                            AuxCadena = AuxCadena + item + ",";
                        }
                        AuxCadena = AuxCadena.Remove((AuxCadena.Length - 1), 1);
                    }
               
                    string Cadena = "select " + AuxCadena + " from "+ cboxTablas.Text+" "+ whereCondicion;
                    //Creamos el comando de SQL
                    Conexiones.Open();
                    SqlCommand cmd = new SqlCommand(Cadena, Conexiones);
                    //Generamos la tabla
                    SqlDataAdapter dr = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dr.Fill(dt);
                    Conexiones.Close();
                    dgvBuscador.DataSource = dt;
                    dgvBuscador.Refresh();
            }
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
