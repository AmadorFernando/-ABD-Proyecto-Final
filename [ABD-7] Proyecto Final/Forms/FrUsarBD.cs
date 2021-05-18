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
            LocalBDUsada = cboxBD.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
