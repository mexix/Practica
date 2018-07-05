using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavanderia
{
    public partial class lava : Form
    {
        public lava()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form salir = new Form1();
            salir.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form acceder1 = new regis();
            acceder1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form acceder2 = new repor();
            acceder2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form acceder3 = new regisropa();
            acceder3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form acceder4 = new gana();
            acceder4.Show();
        }
    }
}
