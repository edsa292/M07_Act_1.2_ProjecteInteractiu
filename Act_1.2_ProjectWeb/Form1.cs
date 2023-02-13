using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Act_1._2_ProjectWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Inicio de Sesión
            if (textBox1.Text == "EDGAR" & textBox2.Text == "1234")
            {
                MessageBox.Show("Bienvenido a My Health, Edgar!");
                string value = textBox1.Text;
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("WRONG DATA");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Inicio de Sesión con Google
            MessageBox.Show("Sesión iniciada con cuenta de Google ");
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Inicio de Sesión con Apple
            MessageBox.Show("Sesión iniciada con cuenta de Apple");
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Formulario de Registro
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 14;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
