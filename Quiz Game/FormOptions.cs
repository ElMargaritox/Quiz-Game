using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "English":
                    Form1.CambiarAIngles();
                    break;
                case "Spanish":
                    Form1.CambiarASpanish();
                    break;
            }

            CambiarTextos();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked) Form1.Instance.DificultadActual = 60;
            if (radioButton2.Checked) Form1.Instance.DificultadActual = 30;
            if (radioButton3.Checked) Form1.Instance.DificultadActual = 10;

            this.Hide();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            if(Form1.config.ButtonPlay == "&Jugar") CambiarTextos(); else CambiarTextos();
        }

        private void CambiarTextos()
        {
            radioButton1.Text = Form1.config.Difficulty[0];
            radioButton2.Text = Form1.config.Difficulty[1];
            radioButton3.Text = Form1.config.Difficulty[2];
            label1.Text = Form1.config.LabelIdioma;
            label2.Text = Form1.config.LabelDificultad;
            btnSave.Text = Form1.config.ButtonSaveConfig;
        }

        private void FormOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void FormOptions_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
