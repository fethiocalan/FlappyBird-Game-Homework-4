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
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureBird = new System.Windows.Forms.PictureBox();
            this.pictureBottom = new System.Windows.Forms.PictureBox();
            this.pictureGround = new System.Windows.Forms.PictureBox();
            this.gameScore = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureTop = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scoreControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTop)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 25;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImage = global::FlappyBirdGame.Properties.Resources.fireeee1;
            this.pictureEdit1.Location = new System.Drawing.Point(319, 804);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(125, 120);
            this.pictureEdit1.TabIndex = 21;
            // 
            // pictureBird
            // 
            this.pictureBird.BackColor = System.Drawing.Color.Transparent;
            this.pictureBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBird.Image = global::FlappyBirdGame.Properties.Resources.fireeee;
            this.pictureBird.Location = new System.Drawing.Point(159, 268);
            this.pictureBird.Name = "pictureBird";
            this.pictureBird.Size = new System.Drawing.Size(39, 54);
            this.pictureBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBird.TabIndex = 20;
            this.pictureBird.TabStop = false;
            this.pictureBird.Click += new System.EventHandler(this.pictureBird_Click);
            // 
            // pictureBottom
            // 
            this.pictureBottom.BackgroundImage = global::FlappyBirdGame.Properties.Resources.stonePipe2;
            this.pictureBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBottom.Location = new System.Drawing.Point(613, 465);
            this.pictureBottom.Name = "pictureBottom";
            this.pictureBottom.Size = new System.Drawing.Size(131, 502);
            this.pictureBottom.TabIndex = 0;
            this.pictureBottom.TabStop = false;
            this.pictureBottom.Click += new System.EventHandler(this.pictureBottom_Click);
            // 
            // pictureGround
            // 
            this.pictureGround.BackgroundImage = global::FlappyBirdGame.Properties.Resources.groundSoil;
            this.pictureGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureGround.Location = new System.Drawing.Point(-32520, 639);
            this.pictureGround.Name = "pictureGround";
            this.pictureGround.Size = new System.Drawing.Size(65535, 128);
            this.pictureGround.TabIndex = 25;
            this.pictureGround.TabStop = false;
            // 
            // gameScore
            // 
            this.gameScore.Appearance.BackColor = System.Drawing.Color.Teal;
            this.gameScore.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameScore.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gameScore.Appearance.Options.UseBackColor = true;
            this.gameScore.Appearance.Options.UseFont = true;
            this.gameScore.Appearance.Options.UseForeColor = true;
            this.gameScore.Appearance.Options.UseTextOptions = true;
            this.gameScore.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gameScore.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.gameScore.Location = new System.Drawing.Point(384, 674);
            this.gameScore.Name = "gameScore";
            this.gameScore.Size = new System.Drawing.Size(101, 75);
            this.gameScore.TabIndex = 27;
            this.gameScore.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Teal;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(188, 674);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(204, 75);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "SCORE : ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 10);
            this.panel1.TabIndex = 29;
            // 
            // pictureTop
            // 
            this.pictureTop.BackgroundImage = global::FlappyBirdGame.Properties.Resources.stonePipe21;
            this.pictureTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTop.Location = new System.Drawing.Point(613, -301);
            this.pictureTop.Name = "pictureTop";
            this.pictureTop.Size = new System.Drawing.Size(131, 523);
            this.pictureTop.TabIndex = 30;
            this.pictureTop.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.scoreControl);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(94, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 559);
            this.panel2.TabIndex = 31;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // scoreControl
            // 
            this.scoreControl.Appearance.Font = new System.Drawing.Font("Kristen ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreControl.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.scoreControl.Appearance.Options.UseFont = true;
            this.scoreControl.Appearance.Options.UseForeColor = true;
            this.scoreControl.Appearance.Options.UseTextOptions = true;
            this.scoreControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.scoreControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.scoreControl.Location = new System.Drawing.Point(119, 344);
            this.scoreControl.Name = "scoreControl";
            this.scoreControl.Size = new System.Drawing.Size(364, 118);
            this.scoreControl.TabIndex = 7;
            this.scoreControl.Text = "25";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(41, 249);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(522, 103);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Your Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FlappyBirdGame.Properties.Resources.tiger;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(119, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 240);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(372, 497);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(130, 46);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Exit Game";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(148, 497);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(132, 46);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Play Again";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gameScore);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureGround);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.pictureBird);
            this.Controls.Add(this.pictureBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTop)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBird;
        private System.Windows.Forms.PictureBox pictureBottom;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.PictureBox pictureGround;
        private DevExpress.XtraEditors.LabelControl gameScore;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureTop;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl scoreControl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}

