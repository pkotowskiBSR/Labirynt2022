namespace Labirynt2022
{
    public partial class Form1 : Form
    {
        bool[,] board = new bool[40, 40];

        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            for (int i = 0; i <= 40; i++)
            {
                g.DrawLine(Pens.Black, 0, 10*i, 400, 10*i);
            }

            for (int i = 0; i <= 40; i++)
            {
                g.DrawLine(Pens.Black, 10*i, 0, 10*i, 400);
            }

            for (int i=0; i<40; i++)
            {
                for (int j=0; j<40; j++)
                {
                    if (board[i,j])
                    {
                        g.FillEllipse(Brushes.Black,  10 * i, 10 * j, 10, 10);
                    }
                }
            }

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            board[x/10, y/10] = true; 

            pictureBox1.Invalidate();

        }
    }
}