using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    
    public partial class Colorpicker : Form
    {
        public Form1 drugaForma { get; set; }
        
        public Colorpicker()
        {
            InitializeComponent();
        }
        public int R1, G1, B1;
        private void Colorpicker_Load(object sender, EventArgs e)
        {
            R1 = 1;
            G1 = 1;
            B1 = 1;
        }

        #region numericscrolls 
        //Kad se promene numericki skrolovi da se azuriraju vrednosti za formiranje boje(R,G,B)
        private void Red_ValueChanged(object sender, EventArgs e)
        {
            R1 = int.Parse(Red.Text);
            Updatecolor();
        }

        private void Green_ValueChanged(object sender, EventArgs e)
        {
            G1 = int.Parse(Green.Text);
            Updatecolor();
        }
        private void Blue_ValueChanged(object sender, EventArgs e)
        {
            B1 = int.Parse(Blue.Text);
            Updatecolor();
        }
        #endregion
        #region horizontalscrolls
        //Horizontalni bar kad se promeni da se azurira value ovih tri vrednosti;
        private void Greens_ValueChanged(object sender, EventArgs e)
        {
            G1 = Greens.Value;
            Updatecolor();
        }

        private void Blues_ValueChanged(object sender, EventArgs e)
        {
            B1 = Blues.Value;
            Updatecolor();
        }

        private void Reds_ValueChanged(object sender, EventArgs e)
        {
            R1 = Reds.Value;
            Updatecolor();
        }
        #endregion

        private void Done_Click(object sender, EventArgs e)
        {
            //azuriranje boja u prvoj formi kad se klikne "Done button"
            drugaForma.R2 = R1;
            drugaForma.G2 = G1;
            drugaForma.B2 = B1;
            drugaForma.newlastcolor();
            this.Close();
        }
        private void Updatecolor()
        {
            //Metod za azuriranje boje 
            Color color = Color.FromArgb(R1, G1, B1);
            colorshow.BackColor = color;
            Red.Text = R1.ToString();
            Blue.Text = B1.ToString();
            Green.Text = G1.ToString();
        }
    }
}
