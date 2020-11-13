using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const int XSIZE = 4; //raw
        const int YSIZE = 4; //column
        Label[,] tiles;

        string strMousePos; //(temporary) mouse position value

        //initialize
        public Form1()
        {
            InitializeComponent();

            //this.BackgroundImage = Properties.Resources._2048; // full background image 

            //2048 title load
            pictureBox1.Load(@"D:\\programming\\vs2019\\c#_winform\\_2048.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //auto size
        }

        //default form load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        //gray background load
        private void BackgroundBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(20, 115, 360, 335));

            e.Graphics.DrawString(strMousePos, Font, Brushes.Black, 10, 10); //(temporary)mouse position
        }

        //(temporary) output mouse position
        private void MousePosition_MouseMove(object sender, MouseEventArgs e)
        {
            strMousePos = "X : " + e.X + " Y : " + e.Y;
            Invalidate();
        }

        // >>>>tile 1~ 16 >>>>
        private void Tile_Paint(object sender, PaintEventArgs e)
        {
            tiles = new Label[XSIZE, YSIZE]
                { { label1, label2, label3, label4},
                  { label5, label6, label7, label8},
                  { label9, label10, label11, label12},
                  { label13, label14, label5, label16}};

            for(int x = 0; x<XSIZE; x++)
            {
                for(int y=0; y<YSIZE; y++)
                {
                    tiles[x, y].Text = "2";
                }
            }
        }   
    }
}
