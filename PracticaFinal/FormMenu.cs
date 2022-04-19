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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        int m, mx, my;
        private void AbrirFormGE(object FomGE)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);
            Form ge = FomGE as Form;
            ge.TopLevel = false;
            ge.Dock = DockStyle.Fill;
            this.panelControl.Controls.Add(ge);
            this.panelControl.Tag = ge;
            ge.Show();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox1_Click(null, e);
        }

        private void FormMenu_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormGE(new FormGGE());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToString("hh:mm:ss");
            Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnmaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaxi.Visible = false;
            btnrestar.Visible = true;
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestar.Visible = false;
            btnmaxi.Visible = true;
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormGE(new FormInicio());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormGE(new FormInicio());
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormGE(new FormInicio());
        }

        private void Hora_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormGE(new FormSobre());
        }

        private void FormMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void FormMenu_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
