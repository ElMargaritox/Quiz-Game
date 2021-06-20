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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }


        
    }
}
