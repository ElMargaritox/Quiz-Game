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

namespace Quiz_Game
{
    public partial class Form1 : Form
    {
        public static Configuration config = new Configuration("spanish");
        public static Form1 Instance { get; set; }
        FormOptions ConfigForm = new FormOptions();
        public Form1()
        {
            Instance = this;
            InitializeComponent();
        }

        #region AnimacionCortaDelTitulo
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lblTitle.ForeColor == Color.Magenta)
            {
                lblTitle.ForeColor = Color.DarkMagenta;
            }
            else
            {
                lblTitle.ForeColor = Color.Magenta;
            }
        }
        #endregion


        public static void CambiarASpanish()
        {
            config = null;
            config = new Configuration("spanish");
            Instance.LoadeR();
        }

        public static void CambiarAIngles()
        {

            config = null;
            config = new Configuration("english");

            Instance.LoadeR();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            LoadeR();
        }

        public void LoadeR()
        {
            lblTitle.Text = config.Title; pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide();
            lblTitle.ForeColor = Color.Magenta;
            BtnJugar.Text = config.ButtonPlay;
            btnOptions.Text = config.ButtonOptions;
            btnExit.Text = config.ButtonExit;
        }

        #region Github
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ElMargaritox");
        }
        #endregion

        private void BtnJugar_Click(object sender, EventArgs e)
        {


            
            
        }

        #region AnimacionBotones
        private void BtnJugar_MouseEnter(object sender, EventArgs e)
        {
            
            ThreadPool.QueueUserWorkItem(delegate (object i)
            {
                pictureBox3.Show(); for (int s = 0; s < 140; s++)pictureBox3.Location = new Point(s, 124);
            });
        }

        private void BtnJugar_MouseLeave(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate (object i)
            {
                for (int s = 140; s > 0; s--) pictureBox3.Location = new Point(s, 124); pictureBox3.Hide();
            });
            
        }

        private void btnOptions_MouseEnter(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate (object i)
            {
                pictureBox4.Show(); for (int s = 0; s < 140; s++) pictureBox4.Location = new Point(s, 163);
            });
        }

        private void btnOptions_MouseLeave(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate (object i)
            {
                for (int s = 140; s > 0; s--) pictureBox4.Location = new Point(s, 163); pictureBox4.Hide();
            });


        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate (object i)
            {
                pictureBox5.Show(); for (int s = 0; s < 140; s++) pictureBox5.Location = new Point(s, 204);

            });

        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate (object i)
            {for (int s = 140; s > 0; s--) pictureBox5.Location = new Point(s, 204); pictureBox5.Hide(); });
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            ConfigForm.Show();
        }
    }
}
