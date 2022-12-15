namespace TopDownRacingGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.award = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.ai2 = new System.Windows.Forms.PictureBox();
            this.ai1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.RoadTrack2 = new System.Windows.Forms.PictureBox();
            this.RoadTrack1 = new System.Windows.Forms.PictureBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.txtscore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.speed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.ai2);
            this.panel1.Controls.Add(this.ai1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.RoadTrack2);
            this.panel1.Controls.Add(this.RoadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 436);
            this.panel1.TabIndex = 0;
            // 
            // award
            // 
            this.award.Image = global::TopDownRacingGame.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(122, 160);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 6;
            this.award.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::TopDownRacingGame.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(68, 281);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            // 
            // ai2
            // 
            this.ai2.Image = global::TopDownRacingGame.Properties.Resources.carPink;
            this.ai2.Location = new System.Drawing.Point(369, 35);
            this.ai2.Name = "ai2";
            this.ai2.Size = new System.Drawing.Size(50, 100);
            this.ai2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ai2.TabIndex = 4;
            this.ai2.TabStop = false;
            this.ai2.Tag = "carright";
            // 
            // ai1
            // 
            this.ai1.Image = global::TopDownRacingGame.Properties.Resources.carYellow;
            this.ai1.Location = new System.Drawing.Point(68, 35);
            this.ai1.Name = "ai1";
            this.ai1.Size = new System.Drawing.Size(50, 99);
            this.ai1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ai1.TabIndex = 3;
            this.ai1.TabStop = false;
            this.ai1.Tag = "carleft";
            // 
            // player
            // 
            this.player.Image = global::TopDownRacingGame.Properties.Resources.carGreen;
            this.player.Location = new System.Drawing.Point(211, 323);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 101);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // RoadTrack2
            // 
            this.RoadTrack2.Image = global::TopDownRacingGame.Properties.Resources.roadTrack;
            this.RoadTrack2.Location = new System.Drawing.Point(0, 0);
            this.RoadTrack2.Name = "RoadTrack2";
            this.RoadTrack2.Size = new System.Drawing.Size(475, 436);
            this.RoadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack2.TabIndex = 1;
            this.RoadTrack2.TabStop = false;
            this.RoadTrack2.Click += new System.EventHandler(this.RoadTrack2_Click);
            // 
            // RoadTrack1
            // 
            this.RoadTrack1.Image = global::TopDownRacingGame.Properties.Resources.roadTrack;
            this.RoadTrack1.Location = new System.Drawing.Point(0, -436);
            this.RoadTrack1.Name = "RoadTrack1";
            this.RoadTrack1.Size = new System.Drawing.Size(475, 436);
            this.RoadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack1.TabIndex = 0;
            this.RoadTrack1.TabStop = false;
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(197, 477);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(103, 38);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.restartgame);
            // 
            // txtscore
            // 
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(243, 451);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(238, 23);
            this.txtscore.TabIndex = 2;
            this.txtscore.Text = "Score: 0";
            this.txtscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtscore.Click += new System.EventHandler(this.txtscore_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 74);
            this.label2.TabIndex = 3;
            this.label2.Text = "Use the keys to move the car \r\n\r\nDon\'t hit any cars to survive and increase your " +
    "score\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gametimer
            // 
            this.gametimer.Interval = 30;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // speed
            // 
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.Location = new System.Drawing.Point(12, 451);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(236, 23);
            this.speed.TabIndex = 4;
            this.speed.Text = "Speed: 12";
            this.speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 601);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Top Down Racing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyisupordown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox RoadTrack1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox ai2;
        private System.Windows.Forms.PictureBox ai1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox RoadTrack2;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label speed;
    }
}

