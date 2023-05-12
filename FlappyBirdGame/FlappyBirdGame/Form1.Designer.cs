namespace FlappyBirdGame
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.house = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.grass = new System.Windows.Forms.PictureBox();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeTop3 = new System.Windows.Forms.PictureBox();
            this.pipeBottom1 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom3 = new System.Windows.Forms.PictureBox();
            this.pnlGameOver = new System.Windows.Forms.Panel();
            this.lblSco = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).BeginInit();
            this.pnlGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.CadetBlue;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(18, 25);
            this.scoreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(119, 32);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "SCORE";
            // 
            // house
            // 
            this.house.Image = global::FlappyBirdGame.Properties.Resources.house;
            this.house.Location = new System.Drawing.Point(118, 406);
            this.house.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(65, 68);
            this.house.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house.TabIndex = 6;
            this.house.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(187, 316);
            this.pipeBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(75, 158);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(187, 0);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(75, 224);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // flappybird
            // 
            this.flappybird.Image = global::FlappyBirdGame.Properties.Resources.bird;
            this.flappybird.Location = new System.Drawing.Point(90, 211);
            this.flappybird.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(41, 42);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 1;
            this.flappybird.TabStop = false;
            // 
            // grass
            // 
            this.grass.BackColor = System.Drawing.Color.Azure;
            this.grass.Image = global::FlappyBirdGame.Properties.Resources.ground;
            this.grass.Location = new System.Drawing.Point(-29, 471);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(655, 77);
            this.grass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass.TabIndex = 0;
            this.grass.TabStop = false;
            // 
            // pipeTop1
            // 
            this.pipeTop1.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pipeTop1.Location = new System.Drawing.Point(311, 0);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(75, 224);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 7;
            this.pipeTop1.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pipeTop2.Location = new System.Drawing.Point(427, 0);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(75, 224);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 9;
            this.pipeTop2.TabStop = false;
            // 
            // pipeTop3
            // 
            this.pipeTop3.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pipeTop3.Location = new System.Drawing.Point(530, 0);
            this.pipeTop3.Name = "pipeTop3";
            this.pipeTop3.Size = new System.Drawing.Size(75, 224);
            this.pipeTop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop3.TabIndex = 10;
            this.pipeTop3.TabStop = false;
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pipeBottom1.Location = new System.Drawing.Point(311, 316);
            this.pipeBottom1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Size = new System.Drawing.Size(75, 158);
            this.pipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom1.TabIndex = 11;
            this.pipeBottom1.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pipeBottom2.Location = new System.Drawing.Point(427, 316);
            this.pipeBottom2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(75, 158);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 12;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeBottom3
            // 
            this.pipeBottom3.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pipeBottom3.Location = new System.Drawing.Point(530, 316);
            this.pipeBottom3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pipeBottom3.Name = "pipeBottom3";
            this.pipeBottom3.Size = new System.Drawing.Size(75, 158);
            this.pipeBottom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom3.TabIndex = 13;
            this.pipeBottom3.TabStop = false;
            // 
            // pnlGameOver
            // 
            this.pnlGameOver.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlGameOver.Controls.Add(this.lblSco);
            this.pnlGameOver.Controls.Add(this.lblScore);
            this.pnlGameOver.Controls.Add(this.btnExit);
            this.pnlGameOver.Controls.Add(this.btnRestart);
            this.pnlGameOver.Controls.Add(this.lblGameOver);
            this.pnlGameOver.Location = new System.Drawing.Point(187, 94);
            this.pnlGameOver.Name = "pnlGameOver";
            this.pnlGameOver.Size = new System.Drawing.Size(210, 243);
            this.pnlGameOver.TabIndex = 14;
            // 
            // lblSco
            // 
            this.lblSco.AutoSize = true;
            this.lblSco.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSco.Location = new System.Drawing.Point(132, 66);
            this.lblSco.Name = "lblSco";
            this.lblSco.Size = new System.Drawing.Size(67, 26);
            this.lblSco.TabIndex = 4;
            this.lblSco.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScore.Location = new System.Drawing.Point(3, 69);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(143, 22);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "YOUR SCORE: ";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(24, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRestart.Location = new System.Drawing.Point(24, 117);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(158, 48);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGameOver.Location = new System.Drawing.Point(29, 14);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(178, 33);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "GAME OVER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.pipeBottom3);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeBottom1);
            this.Controls.Add(this.pipeTop3);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.house);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.grass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).EndInit();
            this.pnlGameOver.ResumeLayout(false);
            this.pnlGameOver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox grass;
		private System.Windows.Forms.PictureBox flappybird;
		private System.Windows.Forms.PictureBox pipeTop;
		private System.Windows.Forms.PictureBox pipeBottom;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Label scoreText;
		private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeTop3;
        private System.Windows.Forms.PictureBox pipeBottom1;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeBottom3;
        private System.Windows.Forms.Panel pnlGameOver;
        private System.Windows.Forms.Label lblSco;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblGameOver;
    }
}

