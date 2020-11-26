using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisForm
{
    public partial class Form1 : Form
    {
        public Tetris Tetris = new Tetris();

        SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 700; 
            Height = 800;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if(e.KeyCode == Keys.Left)
            {
                await semaphoreSlim.WaitAsync();
                Tetris.MoveLeft();
                Tetris.DrawBoard((Form)this);
                semaphoreSlim.Release();
            }

            if(e.KeyCode == Keys.Right)
            {
                await semaphoreSlim.WaitAsync();
                Tetris.MoveRight();
                Tetris.DrawBoard((Form)this);
                semaphoreSlim.Release();
            }

            if(e.KeyCode == Keys.Up)
            {
                await semaphoreSlim.WaitAsync();
                Tetris.NextDirection();
                Tetris.DrawBoard((Form)this);
                semaphoreSlim.Release();
            }

            if(e.KeyCode == Keys.Space || e.KeyCode == Keys.Down)
            {
                await semaphoreSlim.WaitAsync();
                Tetris.MoveDown();
                Tetris.DrawBoard((Form)this);
                semaphoreSlim.Release();
            }
        }

        private async void Form1_Paint(object sender, PaintEventArgs e)
        {
            Tetris.NewBlock();
            await MoveBlockDownLooplyAsync();
            Tetris.DrawBoard((Form)this);
            MessageBox.Show("Game over.");
        }

        private async Task<bool> MoveBlockDownLooplyAsync()
        {
            while (true)
            {
                await semaphoreSlim.WaitAsync();
                Tetris.MoveDown();
                semaphoreSlim.Release();
                Tetris.DrawBoard((Form)this);

                if(Tetris.IsGameOver())
                {
                    break;
                }

                Text = Tetris.CurrentBlock.ToString();
                await Task.Delay(150);
            }
            return true;
        }
    }
}
