using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ABD_7__Proyecto_Final.Forms
{
    public partial class FrUsarBD : Form
    {
        static DataTable LocalLista;
        public string LocalBDUsada="";
        //Esta variable guardara el ultimo click, para poder realizar el movimiento de la ventana.
        Point lastclick;

        public FrUsarBD(DataTable Listado)
        {
            InitializeComponent();
            LocalLista = Listado;
        }
        void InsertarDatos()
        {
            for (int i = 0; i < LocalLista.Rows.Count; i++)
            {
                cboxBD.Items.Add(LocalLista.Rows[i][0]);
            }
        }

        private void FrUsarBD_Load(object sender, EventArgs e)
        {
            InsertarDatos();
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            if (cboxBD.Text!="")
            {
                LocalBDUsada = cboxBD.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una Base de Datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
