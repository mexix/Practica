using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavanderia
{
    public partial class gana : Form
    {
        
        public gana()
        {
            InitializeComponent();

          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form acceder = new lava();
            acceder.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form acceder = new Form1();
            acceder.Show();
        }

        
    }
        }
    

