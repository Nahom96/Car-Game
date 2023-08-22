namespace Car_racing_game_with_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            explosion = new PictureBox();
            award = new PictureBox();
            AI2 = new PictureBox();
            AI1 = new PictureBox();
            player = new PictureBox();
            roadtrack2 = new PictureBox();
            label1 = new Label();
            btnStart = new Button();
            label2 = new Label();
            roadtrack1 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)explosion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)award).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadtrack2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadtrack1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(explosion);
            panel1.Controls.Add(award);
            panel1.Controls.Add(AI2);
            panel1.Controls.Add(AI1);
            panel1.Controls.Add(player);
            panel1.Controls.Add(roadtrack2);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 523);
            panel1.TabIndex = 0;
            // 
            // explosion
            // 
            explosion.Image = Properties.Resources.explosion;
            explosion.Location = new Point(72, 369);
            explosion.Name = "explosion";
            explosion.Size = new Size(64, 64);
            explosion.SizeMode = PictureBoxSizeMode.AutoSize;
            explosion.TabIndex = 9;
            explosion.TabStop = false;
            // 
            // award
            // 
            award.Image = Properties.Resources.bronze;
            award.Location = new Point(115, 202);
            award.Name = "award";
            award.Size = new Size(250, 100);
            award.SizeMode = PictureBoxSizeMode.AutoSize;
            award.TabIndex = 8;
            award.TabStop = false;
            // 
            // AI2
            // 
            AI2.Image = Properties.Resources.carOrange;
            AI2.Location = new Point(361, 71);
            AI2.Name = "AI2";
            AI2.Size = new Size(50, 100);
            AI2.SizeMode = PictureBoxSizeMode.AutoSize;
            AI2.TabIndex = 7;
            AI2.TabStop = false;
            AI2.Tag = "carRight";
            // 
            // AI1
            // 
            AI1.Image = Properties.Resources.carGreen;
            AI1.Location = new Point(55, 71);
            AI1.Name = "AI1";
            AI1.Size = new Size(50, 101);
            AI1.SizeMode = PictureBoxSizeMode.AutoSize;
            AI1.TabIndex = 6;
            AI1.TabStop = false;
            AI1.Tag = "carLeft";
            // 
            // player
            // 
            player.Image = Properties.Resources.carYellow;
            player.Location = new Point(417, 424);
            player.Name = "player";
            player.Size = new Size(50, 99);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 5;
            player.TabStop = false;
            // 
            // roadtrack2
            // 
            roadtrack2.Image = Properties.Resources.roadTrack;
            roadtrack2.Location = new Point(0, 0);
            roadtrack2.Name = "roadtrack2";
            roadtrack2.Size = new Size(466, 523);
            roadtrack2.SizeMode = PictureBoxSizeMode.StretchImage;
            roadtrack2.TabIndex = 4;
            roadtrack2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 538);
            label1.Name = "label1";
            label1.Size = new Size(466, 30);
            label1.TabIndex = 1;
            label1.Text = "Score: 0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.PaleGreen;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(159, 581);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(165, 38);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 633);
            label2.Name = "label2";
            label2.Size = new Size(467, 122);
            label2.TabIndex = 3;
            label2.Text = "Press right or left to move the car.\r\n\r\nDon't hit other cars and survive as long as \r\nyou can 🏆 Good Luck!\r\n\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roadtrack1
            // 
            roadtrack1.Image = Properties.Resources.roadTrack;
            roadtrack1.Location = new Point(0, -530);
            roadtrack1.Name = "roadtrack1";
            roadtrack1.Size = new Size(466, 523);
            roadtrack1.SizeMode = PictureBoxSizeMode.StretchImage;
            roadtrack1.TabIndex = 0;
            roadtrack1.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 764);
            Controls.Add(roadtrack1);
            Controls.Add(label2);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Car Racing";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)explosion).EndInit();
            ((System.ComponentModel.ISupportInitialize)award).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadtrack2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadtrack1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnStart;
        private Label label2;
        private PictureBox roadtrack1;
        private PictureBox roadtrack2;
        private PictureBox explosion;
        private PictureBox award;
        private PictureBox AI2;
        private PictureBox AI1;
        private PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
    }
}