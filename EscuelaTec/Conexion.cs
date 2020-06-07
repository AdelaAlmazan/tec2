using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Interfaces
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado con exito!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos: " + ex.ToString());
            }
        }
        public String insertar(String IdPersonal, String Carrera, String Grupo, String m1, String m2, String m3)
        {
            String salida = "Agregado";
            try
            {
                cmd = new SqlCommand("INSERT INTO Asignacion(IdPersonal,Carrera,Grupo,m1,m2,m3) VALUES(" + IdPersonal + ",'" + Carrera + "','" + Grupo + "','" + m1 + "','" + m2 + "','" + m3 + "')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
            }
            return salida;
        }
        /*public String personaregisrada(String IdPersonal)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Asignacion WHERE '" + IdPersonal + "' ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible consultar: " + ex.ToString());
            }
            return contador.ToString();
        }*/

        public void llenarTexBoxConsulta(int id, TextBox textBox2)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Personal where IdPersonal=" + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = (dr["Nombre"].ToString() + " " + dr["APaterno"].ToString() + " " + dr["AMaterno"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos: " + ex.ToString());
            }
        }

    }
}
