namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimeEV = new System.Windows.Forms.Timer(this.components);
            this.label_score = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.timerflash = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pt_title = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.label_bestscore = new System.Windows.Forms.Label();
            this.fallingTimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pt_gameover = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_gameover)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimeEV
            // 
            this.gameTimeEV.Enabled = true;
            this.gameTimeEV.Interval = 17;
            this.gameTimeEV.Tick += new System.EventHandler(this.gameTimeEV_Tick);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.White;
            this.label_score.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(11, 404);
            this.label_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(79, 26);
            this.label_score.TabIndex = 4;
            this.label_score.Text = "Score:";
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.Location = new System.Drawing.Point(228, 264);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(75, 27);
            this.btn_restart.TabIndex = 6;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // timerflash
            // 
            this.timerflash.Interval = 80;
            this.timerflash.Tick += new System.EventHandler(this.timerflash_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pt_title);
            this.panel1.Controls.Add(this.Play);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 440);
            this.panel1.TabIndex = 7;
            // 
            // pt_title
            // 
            this.pt_title.BackgroundImage = global::FlappyBird.Properties.Resources.title;
            this.pt_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pt_title.Location = new System.Drawing.Point(-1, 34);
            this.pt_title.Name = "pt_title";
            this.pt_title.Size = new System.Drawing.Size(514, 225);
            this.pt_title.TabIndex = 4;
            this.pt_title.TabStop = false;
            // 
            // Play
            // 
            this.Play.BackgroundImage = global::FlappyBird.Properties.Resources.PlayButton;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play.Location = new System.Drawing.Point(187, 308);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(115, 50);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 3;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_bestscore
            // 
            this.label_bestscore.AutoSize = true;
            this.label_bestscore.BackColor = System.Drawing.Color.White;
            this.label_bestscore.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bestscore.Location = new System.Drawing.Point(347, 404);
            this.label_bestscore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_bestscore.Name = "label_bestscore";
            this.label_bestscore.Size = new System.Drawing.Size(129, 26);
            this.label_bestscore.TabIndex = 9;
            this.label_bestscore.Text = "Best score:";
            // 
            // fallingTimer
            // 
            this.fallingTimer.Interval = 50;
            this.fallingTimer.Tick += new System.EventHandler(this.fallingTimer_Tick);
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(1, 383);
            this.ground.Margin = new System.Windows.Forms.Padding(2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(967, 67);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipedown.Location = new System.Drawing.Point(323, 245);
            this.pipedown.Margin = new System.Windows.Forms.Padding(2);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(67, 145);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 2;
            this.pipedown.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::FlappyBird.Properties.Resources.pipedownnn;
            this.pipetop.Location = new System.Drawing.Point(367, -1);
            this.pipetop.Margin = new System.Windows.Forms.Padding(2);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(67, 126);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 3;
            this.pipetop.TabStop = false;
            // 
            // flappybird
            // 
            this.flappybird.Image = global::FlappyBird.Properties.Resources.Bird_01;
            this.flappybird.Location = new System.Drawing.Point(90, 201);
            this.flappybird.Margin = new System.Windows.Forms.Padding(2);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(43, 36);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // pt_gameover
            // 
            this.pt_gameover.BackgroundImage = global::FlappyBird.Properties.Resources.GameOver;
            this.pt_gameover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pt_gameover.Location = new System.Drawing.Point(138, 128);
            this.pt_gameover.Name = "pt_gameover";
            this.pt_gameover.Size = new System.Drawing.Size(273, 82);
            this.pt_gameover.TabIndex = 8;
            this.pt_gameover.TabStop = false;
            this.pt_gameover.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_bestscore);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.pt_gameover);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Birddown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BirdUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pt_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_gameover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.Timer gameTimeEV;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.Timer timerflash;
        private System.Windows.Forms.PictureBox pt_gameover;
        private System.Windows.Forms.PictureBox pt_title;
        private System.Windows.Forms.Label label_bestscore;
        private System.Windows.Forms.Timer fallingTimer;
    }
}

