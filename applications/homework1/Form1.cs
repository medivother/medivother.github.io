using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        private int ballWidth = 20;
        private int ballHeight = 20;
        private int ballPosX = 0;
        private int ballPosY = 0;
        private int ballMoveX = 2;
        private int ballMoveY = 2;

        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            this.UpdateStyles();
        }

        private void PaintCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(Brushes.Red,
                ballPosX, ballPosY,
                ballWidth, ballHeight);
            e.Graphics.DrawEllipse(Pens.Black,
                ballPosX, ballPosY,
                ballWidth, ballHeight);
        }

        private void moveBall(object sender, EventArgs e)
        {
            ballPosX += ballMoveX;
            if (
                ballPosX < 0 ||
                ballPosX + ballWidth > this.ClientSize.Width
                ) { 
                    ballMoveX = - ballMoveX;
                this.progressBar1.Increment(1);
                }

            ballPosY += ballMoveY;
            if (
                ballPosY < 0 ||
                ballPosY + ballHeight > this.ClientSize.Height
                ) {
                ballMoveY = -ballMoveY;
                this.progressBar1.Increment(1);
            }

            this.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false )
            {
                timer1.Enabled = true;
                button1.Text = "Stop the ball";
            }
            else {
                timer1.Enabled = false;
                button1.Text = "Resume";
            }
            
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
