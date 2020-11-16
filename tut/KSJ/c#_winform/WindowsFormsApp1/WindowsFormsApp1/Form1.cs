using System;
using System.Drawing;
using System.Windows.Forms;

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

        //each tile number
        private int[,] tileNumber = new int[GRID_SIZE, GRID_SIZE];

        //label array
        private Label[,] tiles = new Label[GRID_SIZE, GRID_SIZE];

        //fill random number class
        //FillNumber fillNumber = new FillNumber();

        //Fill the labels in this class
        FillLabels fillLabel = new FillLabels();

        //initialize
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
            //(temp) Label information
            tiles[0,0] = new Label
            {
                Size = label1.Size,
                Location = new Point(DXLocation, DYLocation),
                Font = new Font("D2coding", 24),
                Text = "2",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.Black
            };
            Controls.Add(tiles[0,0]);
            tiles[0,0].BringToFront();

            tiles[0,1] = new Label
            {
                Size = label1.Size,
                Location = new Point(DXLocation + TILE_X_INTERVAL, DYLocation),
                Font = new Font("D2coding", 24),
                Text = "4",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.Black
            };
            Controls.Add(tiles[0,1]);
            tiles[0,1].BringToFront();

            tiles[1,0] = new Label
            {
                Size = label1.Size,
                Location = new Point(DXLocation, DYLocation + TILE_Y_INTERVAL),
                Font = new Font("D2coding", 24),
                Text = "8",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.Black
            };
            Controls.Add(tiles[1,0]);
            tiles[1,0].BringToFront();


            //const int TILE_SIZE = 90;
            //const int GRID_SIZE = 4;
            //var clr1 = Color.Gray; //(Temp) Background tile odd
            //var clr2 = Color.DarkGray;//(Temp) Background tile even

            ////initialize the tile board
            //_tileBoardPanel = new Panel[GRID_SIZE, GRID_SIZE];

            ////double for loop to handle all rows and columns
            //for (int x = 0;x<GRID_SIZE;x++)
            //{
            //    for(int y=0;y<GRID_SIZE;y++)
            //    {
            //        //Create new Panel control which will be one tile
            //        var newPanel = new Panel
            //        {
            //            Size = new Size(TILE_SIZE, TILE_SIZE),
            //            Location = new Point(TILE_SIZE * x+30, TILE_SIZE * y+100)
            //        };

            //        //Add to Form's Controls so that they show up
            //        Controls.Add(newPanel);

            //        //Add to our 2d array of panels for future use
            //        _tileBoardPanel[x, y] = newPanel;

            //        //Color the background
            //        if (x % 2 == 0)
            //            newPanel.BackColor = y % 2 != 0 ? clr1 : clr2;
            //        else
            //            newPanel.BackColor = y % 2 != 0 ? clr2 : clr1;
            //    }
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // ##
            // #
            tileNumber[0, 0] = 1;
            tileNumber[0, 1] = 2;
            tileNumber[1, 0] = 3;

            switch (e.KeyCode)
            {
                case Keys.Right:

                    for(int outter = 0; outter<GRID_SIZE; outter++) // 단순반복
                    {
                        for (int j = 0; j < GRID_SIZE-1; j++)
                        {
                            for(int i=0; i<GRID_SIZE; i++)
                            {
                                // When 0 in next tile 
                                if(tileNumber[i,j] != 0 && tileNumber[i,j+1]==0)
                                {
                                    tileNumber[i, j+1] = tileNumber[i, j];
                                    tileNumber[i, j] = 0;
                                    tiles[i, j].Left = DXLocation + (TILE_X_INTERVAL * (j + 1)); //?
                                    tiles[i, j+1] = tiles[i, j];  //?
                                    tiles[i, j] = null;
                                }

                                // When this same as next tile
                                //else if(tileNumber[i,j]==tileNumber[i,j+1])
                                //{
                                //    int sum = tileNumber[i, j] + tileNumber[i, j + 1];
                                //    tileNumber[i, j + 1] = sum;
                                //    tileNumber[i, j] = 0;
                                //}
                            }
                        }
                    }
                    break;
                case Keys.Left:
                    for (int i = 1; i < GRID_SIZE; i++)
                    {

                    }
                    break;
                case Keys.Up:
                    for (int i = 1; i < GRID_SIZE; i++)
                    {

                    }
                    break;
                case Keys.Down:
                    for (int i = 1; i < GRID_SIZE; i++)
                    {

                    }
                    break;
            }
        }
    }
}