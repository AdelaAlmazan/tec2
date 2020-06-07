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

namespace EscuelaTec
{
    public partial class Form7 : Form
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-C29586QR\\TEW_SQLEXPRESS; database=Proyecto; integrated security=true");
        Double prom, c1=0,c2=0,c3=0,c4=0,c5=0;
        public Form7()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SqlCommand comando = new SqlCommand("SELECT * FROM Alumno WHERE IdAlumno= @IdAlumno", conexion);
            comando.Parameters.AddWithValue("@IdAlumno", textBox1.Text);
            conexion.Open();

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
               textBox8.Text= registro["NombreA"].ToString();
                textBox9.Text = registro["ApellidoAPaterno"].ToString();
                textBox11.Text = registro["ApellidoAMaterno"].ToString();
                textBox10.Text = registro["CarreraA"].ToString();
               
            }
            conexion.Close();

        }
        
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            c1 = Double.Parse(textBox2.Text);
            c2 = Double.Parse(textBox3.Text);
            c3 = Double.Parse(textBox4.Text);
            c4 = Double.Parse(textBox5.Text);
            c5 = Double.Parse(textBox6.Text);
            prom=(c1+ c2+ c3+ c4+ c5) / 5;
            textBox7.Text = prom.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                string query = "INSERT INTO Calificaciones (IdCalificacion,IdAlumno,Materia,Periodo,Promedio) VALUES (@IdCalificacion,@IdAlumno,@Materia,@Periodo,@Promedio)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdCalificacion", textBox13.Text);
                comando.Parameters.AddWithValue("@IdAlumno", textBox1.Text);
                comando.Parameters.AddWithValue("@Materia", textBox12.Text);
                comando.Parameters.AddWithValue("@Periodo", textBox13.Text);
                comando.Parameters.AddWithValue("@Promedio", textBox7.Text);
                comando.ExecuteNonQuery();
                conexion.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }


        



    }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM Asignatura WHERE IdAsignatura= @IdAasignatura", conexion);
            comando.Parameters.AddWithValue("@IdAsignatura", textBox14.Text);
            conexion.Open();

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox12.Text = registro["Nombre"].ToString();
                

            }
            conexion.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

          
        }
    }
}
