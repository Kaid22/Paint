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
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            Timer1.Start();
        }

        int x1, x2, y1, y2;
        int penwidth;
        bool down = false;//koristi se da se vidi kad je pritisnuto dugme misa (MouseDown event T, MouseUp event F)
        bool brushstarted = false;//koristi se kako bi se utvrdilo da li je jedna linija vec poceta (Metod Timer1_tick)
        Color pencolor;
        Color lastcolor;

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            penwidth = hScrollBar1.Value;
        }
        #region boje
        // za dugmad za deafult boje
        private void red_Click(object sender, EventArgs e)
        {
            lastcolor = Color.Red;
        }

        private void orange_Click(object sender, EventArgs e)
        {
            lastcolor = Color.Orange;
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            lastcolor = Color.Yellow;
        }

        private void lime_Click(object sender, EventArgs e)
        {
            lastcolor = Color.Lime;
        }

        private void cyan_Click(object sender, EventArgs e)
        {
            lastcolor = Color.Cyan;
        }

        private void green_Click(object sender, EventArgs e)
        {
            lastcolor = Color.Green;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            lastcolor = Color.Blue;
        }

        private void purple_Click(object sender, EventArgs e)
        {
            lastcolor = Color.Purple;
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            Colorpicker cp = new Colorpicker();
            cp.drugaForma = this;
            cp.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x2 = PointToClient(MousePosition).X ;
            y2 = PointToClient(MousePosition).Y ;
            x1 = PointToClient(MousePosition).X ;
            y1 = PointToClient(MousePosition).Y ;

            if(e.Button==MouseButtons.Left)//ako je levi klik onda uzima boju lastcolor
            {
                pencolor = lastcolor;       
            }
            else//ako je neki drugi(desni) uzima backcolor forme (brise)
            {
                pencolor = this.BackColor;
            }
         
            down = true;
        }
        public void newlastcolor() //Ovaj metod se poziva iz druge forme da se updateuje boja
        {
            lastcolor = Color.FromArgb(R, G, B);
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
        }
        #region public varijable
        //Geteri i seteri
        private int R = 0;
        private int G = 0;
        private int B = 0;
        public int R2
        {
            get
            {
                return R;
            }
            set
            {
                if (R != value)
                    R = value;
            }
        }
        public int G2
        {
            get
            {
                return G;
            }
            set
            {
                if (G != value)
                    G = value;
            }
        }
        public int B2
        {
            get
            {
                return B;
            }
            set
            {
                if (B != value)
                    B = value;
            }
        }
        #endregion geteri i seteri
        public void Newcolor()
        {
            lastcolor = Color.FromArgb(R,G,B);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            
            Pen pen = new Pen(pencolor, penwidth);      //pen za krug
            Pen pen1 = new Pen(pencolor, 3*penwidth);   //pen za liniju, tri puta penwidth zato sto imamo dva poluprecnika i jedan je sama debljina linije kruga
            Brush brush = new SolidBrush(pencolor);     //brush za punjenje kruga
            if (down)
            {
                if (brushstarted)
                { 
                    x2 = PointToClient(MousePosition).X ;
                    y2 = PointToClient(MousePosition).Y ;
                    g.DrawEllipse(pen, x2-penwidth,y2-penwidth,2*penwidth,2*penwidth);
                    g.FillEllipse(brush, x2 - penwidth, y2 - penwidth, 2 * penwidth, 2 * penwidth);
                    g.DrawLine(pen1, x1, y1, x2, y2);
                    brushstarted = false;
                }
                else
                {
                    x1 = PointToClient(MousePosition).X ;
                    y1 = PointToClient(MousePosition).Y ;
                    g.DrawEllipse(pen, x1 - penwidth, y1 - penwidth, 2 * penwidth, 2 * penwidth);
                    g.FillEllipse(brush, x1 - penwidth, y1 - penwidth, 2 * penwidth, 2 * penwidth);
                    g.DrawLine(pen1, x1, y1, x2, y2);
                    brushstarted = true;
                }
            }
        }
    }
}
