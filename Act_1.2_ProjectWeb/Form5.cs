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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Volver Pagina Inicio
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ajustes
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
