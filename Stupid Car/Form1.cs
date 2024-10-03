using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stupid_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gravity = 10;
        int speed = 25;
        int score = 0;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 20;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -20;
            else if (e.KeyCode == Keys.Enter)
                timer1.Start();    

        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            car.Top += gravity;
            pipeDown.Left -= speed;
            pipeTop.Left -= speed;
            bird.Left -= speed;
            IbIScore.Text = $"Score: {score}";
            //adding score 
            if (pipeDown.Left < -170)
            {
                pipeDown.Left = rnd.Next(100, 600);
                score++;
            }
            if (pipeTop.Left < -170)
            {
                int top = rnd.Next(300, 700);
                pipeTop.Left = top;
                bird.Left = rnd.Next(top + 100, 800);
                score++;
            }
            if (car.Bounds.IntersectsWith(pipeDown.Bounds) || car.Bounds.IntersectsWith(pipeTop.Bounds) || car.Bounds.IntersectsWith(ground.Bounds))
            {
                timer1.Stop();
                IbIScore.Text += " GameOver !!!";
            }
            if (score > 10)
                speed += 5;
                
        }

        private void IbIScore_Click(object sender, EventArgs e)
        {

        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }
    }
}
