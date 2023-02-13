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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Medicación
            MessageBox.Show("MEDICACIÓN" + "\nAquí podrà ver un calendario mensual " +
                "donde podrà añadir y modificar su medicación diària. No se la olvide!");
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Medichat
            MessageBox.Show("MEDICHAT" + "\nSu asistente mèdico virtual, done podrà " +
                "consultar cualquier inquietud que tenga. Medichat le ayudarà!");
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Emergencias
            DialogResult result = MessageBox.Show("¿Seguro que quiere llamar a emergencias?"
                , "EMERGENCIAS 112", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("En breves recivirá una ambulancia a su localización!",
                    "EMERGENCIAS 112", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Recibido!", "EMERGENCIAS 112",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Operación cancelada!", "Cancelado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Perfil
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Configuración
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Cambiar Salir Cuenta
            MessageBox.Show("Hasta la próxima!");
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
