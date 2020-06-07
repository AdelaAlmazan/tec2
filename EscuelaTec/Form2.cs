using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaTec
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Visible = false;
            }
            if (radioButton2.Checked)
            {

                Form4 f4 = new Form4();
                f4.Show();
                this.Visible = false;

            }
            

        }
    }
}
