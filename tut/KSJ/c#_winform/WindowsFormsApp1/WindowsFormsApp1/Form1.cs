using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //first label location
        public const int DXLocation = 28;
        public const int DYLocation = 110;


        //Each tiles interval
        public const int TILE_X_INTERVAL    = 86;
        public const int TILE_Y_INTERVAL    = 89;
        public const int GRID_SIZE          = 4;

        //Map array
        public int[,] tileNumber = new int[GRID_SIZE, GRID_SIZE];

        //Label array
        public Label[,] tiles = new Label[GRID_SIZE, GRID_SIZE];

        //Labels
        public Label labels = new Label();

        //Initialize
        public Form1()
        {
            InitializeComponent();

            //2048 title load
            pictureBox1.Load(@"D:\\programming\\vs2019\\c#_winform\\_2048.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //auto size
        }

        //default form load
        //Background TILE
        private void Form1_Load(object sender, EventArgs e)
        {

            // (temp) each tile default

            labels = new Label() // 2
            {
                Size        = label1.Size,
                Font        = new Font("D2coding", 24),
                Text        = "2",
                TextAlign   = ContentAlignment.MiddleCenter,
                ForeColor   = Color.Black,
                BackColor   = Color.AliceBlue
            };
            labels.Location = new Point(-50, -50);
            Controls.Add(labels);


            //Create first rand tile
            while (true)
            {
                Random rand = new Random();
                int xRand = rand.Next(0, GRID_SIZE);
                int yRand = rand.Next(0, GRID_SIZE);

                if (tiles[xRand, yRand] == null)
                {
                    tileNumber[xRand, yRand]        = 1;
                    tiles[xRand, yRand]             = labels.Clone();
                    tiles[xRand, yRand].Location    = new Point(DXLocation + (TILE_X_INTERVAL * yRand), DYLocation + (TILE_Y_INTERVAL * xRand));
                    tiles[xRand, yRand].BringToFront();
                    break;
                }
                else continue;
            }

        }

        private void Tile_Color(int tileNumber, int i, int j)
        {
            switch (tileNumber % 10)
            {
                case 0:
                    tiles[i, j].BackColor = Color.AliceBlue;
                    tiles[i, j].ForeColor = Color.Black;
                    break;

                case 1:
                    tiles[i, j].BackColor = Color.Red;
                    tiles[i, j].ForeColor = Color.White;
                    break;
                case 2:
                    tiles[i, j].BackColor = Color.White;
                    tiles[i, j].ForeColor = Color.Coral;
                    break;
                case 3:
                    tiles[i, j].BackColor = Color.Orange;
                    tiles[i, j].ForeColor = Color.White;
                    break;
                case 4:
                    tiles[i, j].BackColor = Color.Aquamarine;
                    tiles[i, j].ForeColor = Color.Violet;
                    break;
                case 5:
                    tiles[i, j].BackColor = Color.Indigo;
                    tiles[i, j].ForeColor = Color.White;
                    break;
                case 6:
                    tiles[i, j].BackColor = Color.Firebrick;
                    tiles[i, j].ForeColor = Color.White;
                    break;
                case 7:
                    tiles[i, j].BackColor = Color.Black;
                    tiles[i, j].ForeColor = Color.White;
                    break;
                case 8:
                    tiles[i, j].BackColor = Color.LightPink;
                    tiles[i, j].ForeColor = Color.White;
                    break;
                case 9:
                    tiles[i, j].BackColor = Color.BlueViolet;
                    tiles[i, j].ForeColor = Color.DarkGray;
                    break;

            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            switch (e.KeyCode)
            {
                case Keys.Right:

                    for (int i = 0; i < GRID_SIZE; i++)
                    {
                        for (int k = 2; k >= 0; k--)
                        {
                            if (tileNumber[i, k] != 0)
                            {
                                for (int j = k + 1; j < GRID_SIZE; j++)
                                {
                                    if ((tileNumber[i, j - 1] != 0 && tileNumber[i, j] == 0) && tiles[i, j - 1] != null)
                                    {
                                        tileNumber[i, j]        = tileNumber[i, j - 1];
                                        tileNumber[i, j - 1]    = 0;
                                        tiles[i, j]             = tiles[i, j - 1];
                                        tiles[i, j - 1]         = null;
                                        tiles[i, j].Location    = new Point(tiles[i, j].Location.X + TILE_X_INTERVAL, tiles[i, j].Location.Y);
                                    }
                                    else if ((tileNumber[i, j - 1] == tileNumber[i, j]) && tiles[i, j] != null)
                                    {
                                        tileNumber[i, j]        += 1;
                                        tileNumber[i, j - 1]    = 0;
                                        int tile_text           = int.Parse(tiles[i, j].Text) * 2;
                                        tiles[i, j].Text        = tile_text.ToString();
                                        Tile_Color(tileNumber[i, j], i, j);
                                        Controls.Remove(tiles[i, j - 1]);
                                    }
                                }
                            }
                        }
                    }

                    //(temp)create rand number
                    while (true)
                    {
                        Random rand = new Random();
                        int xRand = rand.Next(0, GRID_SIZE);
                        int yRand = rand.Next(0, GRID_SIZE);

                        if (tiles[xRand, yRand] == null)
                        {
                            tileNumber[xRand, yRand]        = 1;
                            tiles[xRand, yRand]             = labels.Clone();
                            tiles[xRand, yRand].Location    = new Point(DXLocation + (TILE_X_INTERVAL * yRand), DYLocation + (TILE_Y_INTERVAL * xRand));
                            tiles[xRand, yRand].BringToFront();
                            break;
                        }
                        else continue;
                    }

                    break;

                case Keys.Left:

                    for (int outter = 0; outter < GRID_SIZE; outter++)
                    {
                        for (int i = 0; i < GRID_SIZE; i++)
                        {
                            for (int k = 1; k <= 3; k++)
                            {
                                if (tileNumber[i, k] != 0)
                                {
                                    for (int j = k - 1; j >= 0; j--)
                                    {
                                        if (tileNumber[i, j + 1] != 0 && tileNumber[i, j] == 0)
                                        {
                                            tileNumber[i, j]        = tileNumber[i, j + 1];
                                            tileNumber[i, j + 1]    = 0;
                                            tiles[i, j]             = tiles[i, j + 1];
                                            tiles[i, j + 1]         = null;
                                            tiles[i, j].Location    = new Point(tiles[i, j].Location.X - TILE_X_INTERVAL, tiles[i, j].Location.Y);
                                        }
                                        else if ((tileNumber[i, j + 1] == tileNumber[i, j]) && tiles[i, j] != null)
                                        {
                                            tileNumber[i, j]        += 1;
                                            tileNumber[i, j + 1]    = 0;
                                            int tile_text           = int.Parse(tiles[i, j].Text) * 2;
                                            tiles[i, j].Text        = tile_text.ToString();
                                            Tile_Color(tileNumber[i, j], i, j);
                                            Controls.Remove(tiles[i, j + 1]);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    //(temp)create rand number
                    while (true)
                    {
                        Random rand = new Random();
                        int xRand = rand.Next(0, GRID_SIZE);
                        int yRand = rand.Next(0, GRID_SIZE);

                        if (tiles[xRand, yRand] == null)
                        {
                            tileNumber[xRand, yRand]        = 1;
                            tiles[xRand, yRand]             = labels.Clone();
                            tiles[xRand, yRand].Location    = new Point(DXLocation + (TILE_X_INTERVAL * yRand), DYLocation + (TILE_Y_INTERVAL * xRand));
                            tiles[xRand, yRand].BringToFront();
                            break;
                        }
                        else continue;
                    }

                    break;

                case Keys.Up:

                    for (int i = 0; i < GRID_SIZE; i++)
                    {
                        for (int k = 1; k <= 3; k++)
                        {
                            if (tileNumber[k, i] != 0)
                            {
                                for (int j = k - 1; j >= 0; j--)
                                {
                                    if (tileNumber[j, i] == 0)
                                    {
                                        tileNumber[j, i]        = tileNumber[j + 1, i];
                                        tileNumber[j + 1, i]    = 0;
                                        tiles[j, i]             = tiles[j + 1, i];
                                        tiles[j + 1, i]         = null;
                                        tiles[j, i].Location    = new Point(tiles[j, i].Location.X, tiles[j, i].Location.Y - TILE_Y_INTERVAL);
                                    }
                                    else if ((tileNumber[j + 1, i] == tileNumber[j, i]) && tiles[j, i] != null)
                                    {
                                        tileNumber[j, i]        += 1;
                                        tileNumber[j + 1, i]    = 0;
                                        int tile_text           = int.Parse(tiles[j, i].Text) * 2;
                                        tiles[j, i].Text        = tile_text.ToString();
                                        Tile_Color(tileNumber[j, i], j, i);
                                        Controls.Remove(tiles[j + 1, i]);
                                    }
                                }
                            }
                        }
                    }

                    //(temp)create rand number
                    while (true)
                    {
                        Random rand = new Random();
                        int xRand = rand.Next(0, GRID_SIZE);
                        int yRand = rand.Next(0, GRID_SIZE);

                        if (tiles[xRand, yRand] == null)
                        {
                            tileNumber[xRand, yRand]        = 1;
                            tiles[xRand, yRand]             = labels.Clone();
                            tiles[xRand, yRand].Location    = new Point(DXLocation + (TILE_X_INTERVAL * yRand), DYLocation + (TILE_Y_INTERVAL * xRand));
                            tiles[xRand, yRand].BringToFront();
                            break;
                        }
                        else continue;
                    }

                    break;

                case Keys.Down:

                    for (int i = 0; i < GRID_SIZE; i++)
                    {
                        for (int k = 2; k >= 0; k--)
                        {
                            if (tileNumber[k, i] != 0)
                            {
                                for (int j = k + 1; j < GRID_SIZE; j++)
                                {
                                    if (tileNumber[j, i] == 0)
                                    {
                                        tileNumber[j, i]        = tileNumber[j - 1, i];
                                        tileNumber[j - 1, i]    = 0;
                                        tiles[j, i]             = tiles[j - 1, i];
                                        tiles[j - 1, i]         = null;
                                        tiles[j, i].Location    = new Point(tiles[j, i].Location.X, tiles[j, i].Location.Y + TILE_Y_INTERVAL);
                                    }
                                    else if ((tileNumber[j - 1, i] == tileNumber[j, i]) && tiles[j, i] != null)
                                    {
                                        tileNumber[j, i]        += 1;
                                        tileNumber[j - 1, i]    = 0;
                                        int tile_text           = int.Parse(tiles[j, i].Text) * 2;
                                        tiles[j, i].Text        = tile_text.ToString();
                                        Tile_Color(tileNumber[j, i], j, i);
                                        Controls.Remove(tiles[j - 1, i]);
                                    }
                                }
                            }
                        }
                    }

                    //(temp)create rand number
                    while (true)
                    {
                        Random rand = new Random();
                        int xRand = rand.Next(0, GRID_SIZE);
                        int yRand = rand.Next(0, GRID_SIZE);

                        if (tiles[xRand, yRand] == null)
                        {
                            tileNumber[xRand, yRand]        = 1;
                            tiles[xRand, yRand]             = labels.Clone();
                            tiles[xRand, yRand].Location    = new Point(DXLocation + (TILE_X_INTERVAL * yRand), DYLocation + (TILE_Y_INTERVAL * xRand));
                            tiles[xRand, yRand].BringToFront();
                            break;
                        }
                        else continue;
                    }

                    break;
            }
        }
    }
}