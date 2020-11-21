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
        private int DXLocation = 28;
        private int DYLocation = 110;

        const int TILE_X_INTERVAL = 86;
        const int TILE_Y_INTERVAL = 89;
        const int GRID_SIZE = 4;

        //map number
        //private int[,] mapNumber = new int[GRID_SIZE, GRID_SIZE]
        //    { {0,0,0,0},
        //      {0,0,0,0},
        //      {0,0,0,0},
        //      {0,0,0,0} };

        //map array
        private int[,] tileNumber = new int[GRID_SIZE, GRID_SIZE];

        //label array
        private Label[,] tiles = new Label[GRID_SIZE, GRID_SIZE];

        //create lable array
        private Label[] labels = new Label[16];

        //initialize
        public Form1()
        {
            InitializeComponent();

            //2048 title load
            pictureBox1.Load(@"D:\\programming\\vs2019\\c#_winform\\_2048.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //auto size
        }

        private void CreateTiles()
        {
            Label tile3 = new Label() // 8
            {
                Size = label1.Size,
                Font = new Font("D2coding", 24),
                Text = "8",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.Coral
            };
            Controls.Add(tile3);
            tile3.BringToFront();
            labels[2] = tile3;

            Label tile4 = new Label() // 16
            {
                Size = label1.Size,
                Font = new Font("D2coding", 24),
                Text = "16",
                ImageIndex=4,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.BlueViolet
            };
            Controls.Add(tile4);
            tile4.BringToFront();
            labels[3] = tile4;
            
        }

        //default form load
        //Background TILE
        private void Form1_Load(object sender, EventArgs e)
        {
            // ##
            // #
            //tileNumber[1, 0] = 3;

            // (temp) each tile location

            labels[0] = new Label() // 2
            {
                Size        = label1.Size,
                Font        = new Font("D2coding", 24),
                Text        = "2",
                Location    = new Point(DXLocation, DYLocation),
                TextAlign   = ContentAlignment.MiddleCenter,
                ForeColor   = Color.Black,
                BackColor   = Color.AliceBlue
            };
            tileNumber[0, 0] = 1;
            tiles[0, 0] = labels[0];
            Controls.Add(labels[0]);
            labels[0].BringToFront();


            labels[1] = new Label() // 4
            {
                Size        = label1.Size,
                Font        = new Font("D2coding", 24),
                Text        = "4",
                Location    = new Point(DXLocation, DYLocation+TILE_Y_INTERVAL),
                TextAlign   = ContentAlignment.MiddleCenter,
                ForeColor   = Color.Black,
                BackColor   = Color.AntiqueWhite
            };
            tileNumber[0, 1] = 2;
            tiles[0, 1] = labels[1];
            Controls.Add(labels[1]);
            labels[1].BringToFront();

            labels[2] = new Label() // 8
            {
                Size        = label1.Size,
                Font        = new Font("D2coding", 24),
                Text        = "8",
                Location    = new Point(DXLocation+TILE_X_INTERVAL, DYLocation+TILE_Y_INTERVAL),
                TextAlign   = ContentAlignment.MiddleCenter,
                ForeColor   = Color.White,
                BackColor   = Color.Coral
            };
            tileNumber[0, 1] = 3;
            tiles[1, 1] = labels[2];
            Controls.Add(labels[2]);
            labels[2].BringToFront();


            //(temp)create rand number
            //while (true)
            //{
            //    Random rand = new Random();
            //    int xRand = rand.Next(0, GRID_SIZE);
            //    int yRand = rand.Next(0, GRID_SIZE);
            //    MessageBox.Show(xRand + ":" + yRand);

            //    if (tiles[xRand, yRand] == null)
            //    {
            //        tileNumber[xRand, yRand]    = 1;
            //        tiles[xRand, yRand]         = labels[0].Clone();
            //        //tiles[xRand, yRand].Left    = DXLocation + (TILE_X_INTERVAL * xRand);
            //        //tiles[xRand, yRand].Top     = DYLocation + (TILE_Y_INTERVAL * yRand);

            //        tiles[xRand, yRand].Location = new Point(DXLocation + (TILE_X_INTERVAL * xRand), DYLocation + (TILE_Y_INTERVAL * yRand));
            //        tiles[xRand, yRand].BringToFront();
            //        //MessageBox.Show(tileNumber[0,0].ToString());
            //        break;
            //    }
            //    else continue;
            //}

        }
    

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            switch (e.KeyCode)
            {
                case Keys.Right:

                    //for (int outter = 0; outter < GRID_SIZE; outter++)
                    //{
                        for (int i = 0; i < GRID_SIZE; i++)
                        {
                            for (int k = 2; k >= 0; k--)
                            {
                                if (tileNumber[i, k] != 0)
                                {
                                    for (int j = k + 1; j < GRID_SIZE; j++)
                                    {
                                        if (tileNumber[i, j] == 0)
                                        {
                                            tileNumber[i, j]        = tileNumber[i, j - 1];
                                            tileNumber[i, j - 1]    = 0;
                                            tiles[i, j]             = tiles[i, j - 1];
                                            tiles[i, j - 1]         = null;
                                            tiles[i, j].Location    = new Point(tiles[i, j].Location.X + TILE_X_INTERVAL, tiles[i, j].Location.Y);
                                        }
                                    }
                                }
                            }
                        }
                    //}

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
                                        if (tileNumber[i, j] == 0)
                                        {
                                            tileNumber[i, j]        = tileNumber[i, j + 1];
                                            tileNumber[i, j + 1]    = 0;
                                            tiles[i, j]             = tiles[i, j + 1];
                                            tiles[i, j + 1]         = null;
                                            tiles[i, j].Location    = new Point(tiles[i, j].Location.X - TILE_X_INTERVAL, tiles[i, j].Location.Y);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    break;

                case Keys.Up:

                    for (int outter = 0; outter < GRID_SIZE; outter++)
                    {
                        for (int i = 0; i < GRID_SIZE; i++)
                        {
                            for (int k = 1; k <= 3; k++)
                            {
                                if (tileNumber[k, i] != 0) //?
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
                                    }
                                }
                            }
                        }
                    }

                    break;

                case Keys.Down:

                    for (int outter = 0; outter < GRID_SIZE; outter++)
                    {
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
                                    }
                                }
                            }
                        }
                    }

                    break;
            }
        }
    }
}