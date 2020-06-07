using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EscuelaTec
{
    class ConexionBD
    {
        string cadena = "Data source=LAPTOP-C29586QR\\TEW_SQLEXPRESS; Initial catalog=Proyecto; Integrated Security=true";
        public SqlConnection ConectarBD = new SqlConnection();


        public ConexionBD()
        {
            ConectarBD.ConnectionString = cadena;
        }
        public void abrir()
        {
            try
            {
                ConectarBD.Open();
                Console.WriteLine("Conexion abierta");

            }
            catch(Exception e)
            {
                Console.WriteLine("Error al abrir la base de datos" + e.Message);
            }




        }

        public void cerrar()
        {
            ConectarBD.Close();

        }
    }
}
