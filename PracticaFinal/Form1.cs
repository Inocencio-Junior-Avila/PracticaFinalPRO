using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            Opacity -= 0.030;
            label1.Text = progressBar1.Value.ToString() + "%";

            if (Opacity == 0.0)
            {
                timer1.Stop();
                this.Hide();
                FormLogin login = new FormLogin();
                login.ShowDialog();
            }

            /*progressBar1.Increment(5);
            label1.Text = progressBar1.Value.ToString() + "%";

           if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                FormLogin login = new FormLogin();
                login.ShowDialog();
            }*/
        }
    }
}
