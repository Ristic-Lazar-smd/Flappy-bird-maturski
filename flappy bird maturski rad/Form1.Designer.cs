namespace flappy_bird_maturski_rad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.cevgore = new System.Windows.Forms.PictureBox();
            this.cevdole = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.Cevi = new System.Windows.Forms.Timer(this.components);
            this.cevgore2 = new System.Windows.Forms.PictureBox();
            this.cevdole2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nebo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cevgore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cevdole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cevgore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cevdole2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nebo)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(21, 153);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(76, 58);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // cevgore
            // 
            this.cevgore.BackColor = System.Drawing.Color.Transparent;
            this.cevgore.Image = ((System.Drawing.Image)(resources.GetObject("cevgore.Image")));
            this.cevgore.Location = new System.Drawing.Point(307, -200);
            this.cevgore.Name = "cevgore";
            this.cevgore.Size = new System.Drawing.Size(93, 375);
            this.cevgore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cevgore.TabIndex = 1;
            this.cevgore.TabStop = false;
            // 
            // cevdole
            // 
            this.cevdole.BackColor = System.Drawing.Color.Transparent;
            this.cevdole.Image = ((System.Drawing.Image)(resources.GetObject("cevdole.Image")));
            this.cevdole.Location = new System.Drawing.Point(307, 350);
            this.cevdole.Name = "cevdole";
            this.cevdole.Size = new System.Drawing.Size(93, 375);
            this.cevdole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cevdole.TabIndex = 2;
            this.cevdole.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-16, 502);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1103, 249);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 45;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Image = ((System.Drawing.Image)(resources.GetObject("scoreText.Image")));
            this.scoreText.Location = new System.Drawing.Point(198, 567);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(374, 98);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "scoreText";
            this.scoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreText.Visible = false;
            // 
            // Cevi
            // 
            this.Cevi.Interval = 15;
            this.Cevi.Tick += new System.EventHandler(this.Cevi_Tick);
            // 
            // cevgore2
            // 
            this.cevgore2.BackColor = System.Drawing.Color.Transparent;
            this.cevgore2.Image = ((System.Drawing.Image)(resources.GetObject("cevgore2.Image")));
            this.cevgore2.Location = new System.Drawing.Point(550, -286);
            this.cevgore2.Name = "cevgore2";
            this.cevgore2.Size = new System.Drawing.Size(93, 375);
            this.cevgore2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cevgore2.TabIndex = 9;
            this.cevgore2.TabStop = false;
            // 
            // cevdole2
            // 
            this.cevdole2.BackColor = System.Drawing.Color.Transparent;
            this.cevdole2.Image = ((System.Drawing.Image)(resources.GetObject("cevdole2.Image")));
            this.cevdole2.Location = new System.Drawing.Point(550, 243);
            this.cevdole2.Name = "cevdole2";
            this.cevdole2.Size = new System.Drawing.Size(93, 375);
            this.cevdole2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cevdole2.TabIndex = 10;
            this.cevdole2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 144);
            this.label1.TabIndex = 11;
            this.label1.Text = "      Kliknite \"space\"\r\n         da pocnete\r\n\r\n";
            // 
            // nebo
            // 
            this.nebo.BackColor = System.Drawing.Color.Transparent;
            this.nebo.Location = new System.Drawing.Point(-16, -27);
            this.nebo.Name = "nebo";
            this.nebo.Size = new System.Drawing.Size(890, 23);
            this.nebo.TabIndex = 12;
            this.nebo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 674);
            this.Controls.Add(this.nebo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.cevgore2);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.cevdole);
            this.Controls.Add(this.cevgore);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.cevdole2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skok);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cevgore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cevdole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cevgore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cevdole2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nebo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox cevgore;
        private System.Windows.Forms.PictureBox cevdole;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer Cevi;
        private System.Windows.Forms.PictureBox cevgore2;
        private System.Windows.Forms.PictureBox cevdole2;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox nebo;
    }
}

