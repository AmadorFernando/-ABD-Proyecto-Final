using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _ABD_7__Proyecto_Final
{
    class Conexion
    {
        private SqlConnection Conexiones =null;


        //public SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=master;Integrated Security= True");

        public Conexion()
        {
            Conexiones.ConnectionString = ("Data Source=DESKTOP-PRRK88P;Initial Catalog=master;Integrated Security= True");
        }

        public void AbrirBD()
        {
            try
            {
                Conexiones.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex);

            }
        }

        public void CerrarBD()
        {
            Conexiones.Close();
        }
    }
}



