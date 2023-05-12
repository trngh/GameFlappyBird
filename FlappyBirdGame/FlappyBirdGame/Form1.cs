using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame 
{
	public partial class Form1 : Form
	{
		int pipespeed = 7;
		int gravity = 7;
		int score = 0;
		int d = 250;     // khoảng cách giữa các ống
		int h = 100;     // độ hở giữa ống trên và ống dưới
		int width = 75;  // chiều rộng của ống  (chiều dài được random trong hàm gameTimer_Tick)
        int pointBottom = 474;  // toạ độ điểm kết thúc của ống dưới
        Random a = new Random();
        bool Start=false, End=false;
        public Form1()
		{
			InitializeComponent();
			gameTimer.Stop();

			setPipeTop(230, 0, width, 224);
			setPipeTop1(pipeTop.Location.X + d, 0, width, a.Next(90, 250));
			setPipeTop2(pipeTop1.Location.X + d, 0, width, a.Next(90, 250));
			setPipeTop3(pipeTop2.Location.X + d, 0, width, a.Next(90, 250));
		}
		public void setPipeTop(int x, int y, int width, int height)
		{
            pipeTop.Location = new Point(x, y);
			pipeTop.Size = new Size(width, height);

			pipeBottom.Location = new Point(pipeTop.Location.X, pipeTop.Size.Height + h);
			pipeBottom.Size = new Size(width, pointBottom - pipeBottom.Location.Y);
		}
        public void setPipeTop1(int x, int y, int width, int height)
        {
            pipeTop1.Location = new Point(x,y);
			pipeTop1.Size = new Size(width, height);

            pipeBottom1.Location = new Point(pipeTop1.Location.X, pipeTop1.Size.Height + h);
			pipeBottom1.Size = new Size(width, pointBottom - pipeBottom1.Location.Y);
        }
        public void setPipeTop2(int x, int y, int width, int height)
        {
            pipeTop2.Location = new Point(x, y);
			pipeTop2.Size = new Size(width, height);

            pipeBottom2.Location = new Point(pipeTop2.Location.X, pipeTop2.Size.Height + h);
			pipeBottom2.Size = new Size(width, pointBottom - pipeBottom2.Location.Y);
        }
        public void setPipeTop3(int x, int y, int width, int height)
        {
            pipeTop3.Location = new Point(x, y);
			pipeTop3.Size = new Size(width, height);

            pipeBottom3.Location = new Point(pipeTop3.Location.X, pipeTop3.Size.Height + h);
			pipeBottom3.Size = new Size(width, pointBottom - pipeBottom3.Location.Y);
        }

        private void endGame()
		{
            gameTimer.Stop();
            End = true;
			scoreText.Text += "   Game Over";
			lblSco.Text = score.ToString();
            this.Controls.Add(this.pnlGameOver);
            pnlGameOver.BringToFront();
        }

		private void gameTimer_Tick(object sender, EventArgs e)
		{
			flappybird.Top += gravity;
			pipeBottom.Left -= pipespeed;
            pipeBottom1.Left -= pipespeed;
            pipeBottom2.Left -= pipespeed;
            pipeBottom3.Left -= pipespeed;
            pipeTop.Left -= pipespeed;
            pipeTop1.Left -= pipespeed;
            pipeTop2.Left -= pipespeed;
            pipeTop3.Left -= pipespeed;
            house.Left -= pipespeed;
			scoreText.Text = "SCORE: " + score;

			/*if (pipeBottom.Left < -150)
			{
				pipeBottom.Left = 500;
				if (pipeTop.Left < -180)
				{
					pipeTop.Left = 600;
				}
				score++;
			}*/

			if(pipeTop.Location.X <= -width)
			{
				int x = a.Next(90, 250);
				setPipeTop(pipeTop3.Location.X + d, 0, width, x);
                score++;
            }

            if (pipeTop1.Location.X <= -width)
            {
                int x = a.Next(90, 250);
                setPipeTop1(pipeTop.Location.X + d, 0, width, x);
                score++;
            }

            if (pipeTop2.Location.X <= -width)
            {
                int x = a.Next(90, 250);
				setPipeTop2(pipeTop1.Location.X + d, 0, width, x);
                score++;
            }

            if (pipeTop3.Location.X <= -width)
            {
                int x = a.Next(90, 250);
				setPipeTop3(pipeTop2.Location.X + d, 0, width, x);
                score++;
            }

            if (house.Location.X <= -65)
			{
				house.Left = pipeBottom3.Left + width;
			}
			if (flappybird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeBottom1.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeBottom3.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeTop1.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeTop2.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeTop3.Bounds) ||
                flappybird.Bounds.IntersectsWith(grass.Bounds))
			{
				endGame();
			}
			if (score > 8)
			{
				pipespeed = 10;
			}
		}

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (Start == false)
                {
                    Start = true;
                    gameTimer.Start();
                }
                else if (End == true)
                {}
                else
                {
                    if (gravity > 0)
                        gravity = -7;
                }
            }
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (gravity < 0)
                    gravity = 7;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            /*Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();*/
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure? ", "Exit", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameTimer.Interval = 50;
        }

        
	}
}
