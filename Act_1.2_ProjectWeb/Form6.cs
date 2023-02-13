using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_1._2_ProjectWeb
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox11.PasswordChar = '*';
            textBox11.MaxLength = 14;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*';
            textBox5.MaxLength = 14;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.PasswordChar = '*';
            textBox6.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear Cuenta
            DialogResult result = MessageBox.Show("Desea cambiar los datos?", "Guardar Datos",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Datos cambiados correctamente!", "Guardado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Bienvenido a My Health!");
                Form3 form3 = new Form3();
                form3.Show();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Datos descartados!", "Descartado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Operación cancelada!", "Cancelado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();   
        }
    }
}
