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
    public partial class imagen : Form
    {
        public int valor = 0;
        public imagen()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (valor != 100)
            {
                this.barraCarga.Increment(2);
                valor = this.barraCarga.Value;
                lblProgreso.Text = valor.ToString() + " %";
            }
            else
            {
                Thread.Sleep(1000);
                Form1 f = new Form1();
                this.Visible = false;
                this.timer1.Stop();
            }
        }
    }
}
