using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlappyBird
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            gameTimeEV.Stop();
            player.Load();
            player.Play();
            player.PlayLooping();
        }

        private int score;
        private int pipeSpeed;
        private int gravity;
        private bool isJumping;
        private int jumpSpeed;
        private int bestsocre = 0;

        SoundPlayer player = new SoundPlayer(@"C:\New folder\Báo cáo giữa kì game Flappy Bird - Nhóm TTXB\Báo cáo giữa kì game Flappy Bird - Nhóm TTXB\FlappyBird\Energy Theme - Jextor.wav");
        
 
        private void Form1_Load(object sender, EventArgs e)
        {
            Play.TabStop = true;
            this.MaximumSize = new Size(525, 476);
            this.MinimumSize = new Size(525, 476);
        }
        private void InitializeGame()
        {
            score = 0;
            pipeSpeed = 5;
            isJumping = false;
            jumpSpeed = 18;
            gravity = 5;
            pipetop.Location = new Point(367, -1);
            pipedown.Location = new Point(323, 243);
            flappybird.Location = new Point(90, 197);
            label_score.Text = "Score: 0";
            label_bestscore.Visible = true;
            label_bestscore.Text = "Best Score: " + bestsocre ;
            label_score.Location = new Point(11, 404);
            pt_gameover.Visible = false;
            label_score.ForeColor = Color.Black;
            label_score.Font = new Font("Arial", 16, FontStyle.Bold);
            fallingTimer.Enabled = false;
        }
        private void gameTimeEV_Tick(object sender, EventArgs e)
        {
            if (isJumping)
            {
                flappybird.Top -= jumpSpeed;
            }
            else
            {
                flappybird.Top += gravity;
            }
            pipetop.Left -= pipeSpeed;
            pipedown.Left -= pipeSpeed;
            ground.Left -= pipeSpeed;
            label_score.Text = "Score: " + score;            
            if (flappybird.Top < -25)
            {
                SoundPlayer playerr = new SoundPlayer(@"C:\New folder\Báo cáo giữa kì game Flappy Bird - Nhóm TTXB\Báo cáo giữa kì game Flappy Bird - Nhóm TTXB\FlappyBird\mixkit-cartoon-dazzle-hit-and-birds-746.wav");
                playerr.Play();
                GameOver();
            }
            if ((flappybird.Bounds.IntersectsWith(ground.Bounds)) || (flappybird.Bounds.IntersectsWith(pipetop.Bounds)) || (flappybird.Bounds.IntersectsWith(pipedown.Bounds)))
            {
                flappybird.Top -= 20;
                SoundPlayer playerr = new SoundPlayer(@"C:\New folder\Báo cáo giữa kì game Flappy Bird - Nhóm TTXB\Báo cáo giữa kì game Flappy Bird - Nhóm TTXB\FlappyBird\mixkit-cartoon-dazzle-hit-and-birds-746.wav");
                playerr.Play();
                GameOver();
            }
            if (pipedown.Left < -80)
            {
                score++;
                SoundPlayer playerr = new SoundPlayer(@"C:\New folder\Báo cáo giữa kì game Flappy Bird - Nhóm TTXB\Báo cáo giữa kì game Flappy Bird - Nhóm TTXB\FlappyBird\mixkit-winning-a-coin-video-game-2069.wav");
                playerr.Play();
                pipedown.Left = 430;
            }
            if (pipetop.Left < -80)
            {
                pipetop.Left = 460;
            }
            if (ground.Left < -400)
            {
                ground.Left = 1;
            }
            if (score > 5) pipeSpeed = 6;
            if (score > 10) pipeSpeed = 7;
            if (score > 25) pipeSpeed = 8;
            if (score > 50) pipeSpeed = 9;
            if (score > 75) pipeSpeed = 10;
            if (score > 100) pipeSpeed = 11;
        }
        private void GameOver()
        {
            gameTimeEV.Stop();         
            timerflash.Enabled = true;
            var countdown = new Timer();
            countdown.Interval = 500;
            countdown.Tick += (s, e) =>
            {
                countdown.Stop();
                timerflash.Enabled = false;
                this.BackColor = Color.Aqua;
            };
            countdown.Start();
            fallingTimer.Enabled = true;
            pt_gameover.Visible = true;
            label_score.Location = new Point(165, 230);
            label_score.ForeColor = Color.Red;
            label_score.Font = new Font(label_score.Font.FontFamily, 20, label_score.Font.Style );
            if (score > bestsocre)
            {
                bestsocre = score;
                label_score.Text = "Best Score: " + score;
            }
            else label_score.Text = "Your Score: " + score;
            btn_restart.Visible = true;
            label_bestscore.Visible = false;
        }

     

        private void Birddown(object sender, MouseEventArgs e)
        {
            isJumping = true;
        }

        private void BirdUp(object sender, MouseEventArgs e)
        {
            isJumping = false;
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            InitializeGame();
            gameTimeEV.Start();
            btn_restart.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InitializeGame();
            gameTimeEV.Start();
            btn_restart.Visible = false;
            panel1.Visible = false;
            pt_title.Visible = false;
            Play.Visible = false;
            flappybird.Visible = true;
            player.Stop();
        }

        private void timerflash_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }

        private void fallingTimer_Tick(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
        }
    }
}
    