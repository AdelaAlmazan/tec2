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
    public partial class Form1 : Form
    {

        SqlConnection conexion = new SqlConnection("server=LAPTOP-C29586QR\\TEW_SQLEXPRESS; database=Proyecto; integrated security=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                
                }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Visible = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "INSERT INTO Personal (IdPersonal,Nombre,APaterno,AMaterno,Direccion,Telefono,Tipo) VALUES (@IdPersonal,@Nombre,@APaterno,@AMaterno,@Direccion,@Telefono,@Tipo)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdPersonal", textBox1.Text);
                comando.Parameters.AddWithValue("@Nombre", textBox2.Text);
                comando.Parameters.AddWithValue("@APaterno", textBox3.Text);
                comando.Parameters.AddWithValue("@AMaterno", textBox4.Text);
                comando.Parameters.AddWithValue("@Direccion", textBox5.Text);
                comando.Parameters.AddWithValue("@Telefono", textBox9.Text);
                comando.Parameters.AddWithValue("@tipo", textBox9.Text); //Cammbiar por opciones 
                comando.ExecuteNonQuery();
                MessageBox.Show("INSERTADO NUEVO MAESTRO");
                conexion.Close();

                string query1 = "INSERT INTO Usuarios (IdUsuario,Password) VALUES (@IdUsuario,@Password)";
                conexion.Open();
                SqlCommand comando1 = new SqlCommand(query1, conexion);
                comando1.Parameters.AddWithValue("@IdUsuario", textBox7.Text);
                comando1.Parameters.AddWithValue("@Password", textBox8.Text);

                comando1.ExecuteNonQuery();
                MessageBox.Show("INSERTADO NUEVO Usuario");
                conexion.Close();




            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

        }
    }
}
