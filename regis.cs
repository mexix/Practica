using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lavanderia.DAO;

namespace Lavanderia
{
    public partial class regis : Form
    {
        
        public regis()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
