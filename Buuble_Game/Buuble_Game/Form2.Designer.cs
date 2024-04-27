
namespace Buuble_Game
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.boundary3 = new System.Windows.Forms.Panel();
            this.Game_Timer = new System.Windows.Forms.Timer(this.components);
            this.boundary2 = new System.Windows.Forms.Panel();
            this.boundary1 = new System.Windows.Forms.Panel();
            this.Lives_Counter = new System.Windows.Forms.Label();
            this.Score_Counter = new System.Windows.Forms.Label();
            this.Lives = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.bubble11 = new System.Windows.Forms.PictureBox();
            this.bubble7 = new System.Windows.Forms.PictureBox();
            this.bubble6 = new System.Windows.Forms.PictureBox();
            this.bubble8 = new System.Windows.Forms.PictureBox();
            this.bubble9 = new System.Windows.Forms.PictureBox();
            this.bubble5 = new System.Windows.Forms.PictureBox();
            this.bubble4 = new System.Windows.Forms.PictureBox();
            this.bubble3 = new System.Windows.Forms.PictureBox();
            this.bubble2 = new System.Windows.Forms.PictureBox();
            this.bubble10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bubble11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble10)).BeginInit();
            this.SuspendLayout();
            // 
            // boundary3
            // 
            this.boundary3.BackColor = System.Drawing.Color.Black;
            this.boundary3.Location = new System.Drawing.Point(-5, 706);
            this.boundary3.Name = "boundary3";
            this.boundary3.Size = new System.Drawing.Size(1453, 48);
            this.boundary3.TabIndex = 0;
            // 
            // Game_Timer
            // 
            this.Game_Timer.Enabled = true;
            this.Game_Timer.Interval = 30;
            this.Game_Timer.Tick += new System.EventHandler(this.Game_Timer_Tick);
            // 
            // boundary2
            // 
            this.boundary2.BackColor = System.Drawing.Color.Black;
            this.boundary2.Location = new System.Drawing.Point(318, 60);
            this.boundary2.Name = "boundary2";
            this.boundary2.Size = new System.Drawing.Size(58, 499);
            this.boundary2.TabIndex = 8;
            // 
            // boundary1
            // 
            this.boundary1.BackColor = System.Drawing.Color.Black;
            this.boundary1.Location = new System.Drawing.Point(6, 12);
            this.boundary1.Name = "boundary1";
            this.boundary1.Size = new System.Drawing.Size(1442, 48);
            this.boundary1.TabIndex = 7;
            // 
            // Lives_Counter
            // 
            this.Lives_Counter.AutoSize = true;
            this.Lives_Counter.BackColor = System.Drawing.Color.Transparent;
            this.Lives_Counter.Font = new System.Drawing.Font("Malgun Gothic", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lives_Counter.ForeColor = System.Drawing.Color.Black;
            this.Lives_Counter.Location = new System.Drawing.Point(1393, 132);
            this.Lives_Counter.Name = "Lives_Counter";
            this.Lives_Counter.Size = new System.Drawing.Size(26, 30);
            this.Lives_Counter.TabIndex = 15;
            this.Lives_Counter.Text = "3";
            // 
            // Score_Counter
            // 
            this.Score_Counter.AutoSize = true;
            this.Score_Counter.BackColor = System.Drawing.Color.Transparent;
            this.Score_Counter.Font = new System.Drawing.Font("Malgun Gothic", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Counter.ForeColor = System.Drawing.Color.Black;
            this.Score_Counter.Location = new System.Drawing.Point(1393, 75);
            this.Score_Counter.Name = "Score_Counter";
            this.Score_Counter.Size = new System.Drawing.Size(26, 30);
            this.Score_Counter.TabIndex = 14;
            this.Score_Counter.Text = "0";
            // 
            // Lives
            // 
            this.Lives.AutoSize = true;
            this.Lives.BackColor = System.Drawing.Color.Transparent;
            this.Lives.Font = new System.Drawing.Font("Malgun Gothic", 24.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lives.ForeColor = System.Drawing.Color.Black;
            this.Lives.Location = new System.Drawing.Point(1260, 120);
            this.Lives.Name = "Lives";
            this.Lives.Size = new System.Drawing.Size(118, 45);
            this.Lives.TabIndex = 13;
            this.Lives.Text = "Lives :";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Malgun Gothic", 24.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Black;
            this.Score.Location = new System.Drawing.Point(1260, 63);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(127, 45);
            this.Score.TabIndex = 12;
            this.Score.Text = "Score :";
            // 
            // bubble11
            // 
            this.bubble11.BackColor = System.Drawing.Color.Transparent;
            this.bubble11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bubble11.BackgroundImage")));
            this.bubble11.Location = new System.Drawing.Point(12, 75);
            this.bubble11.Name = "bubble11";
            this.bubble11.Size = new System.Drawing.Size(87, 87);
            this.bubble11.TabIndex = 22;
            this.bubble11.TabStop = false;
            // 
            // bubble7
            // 
            this.bubble7.BackColor = System.Drawing.Color.Transparent;
            this.bubble7.Image = ((System.Drawing.Image)(resources.GetObject("bubble7.Image")));
            this.bubble7.Location = new System.Drawing.Point(796, 184);
            this.bubble7.Name = "bubble7";
            this.bubble7.Size = new System.Drawing.Size(106, 99);
            this.bubble7.TabIndex = 21;
            this.bubble7.TabStop = false;
            // 
            // bubble6
            // 
            this.bubble6.BackColor = System.Drawing.Color.Transparent;
            this.bubble6.Image = ((System.Drawing.Image)(resources.GetObject("bubble6.Image")));
            this.bubble6.Location = new System.Drawing.Point(664, 94);
            this.bubble6.Name = "bubble6";
            this.bubble6.Size = new System.Drawing.Size(106, 99);
            this.bubble6.TabIndex = 20;
            this.bubble6.TabStop = false;
            // 
            // bubble8
            // 
            this.bubble8.BackColor = System.Drawing.Color.Transparent;
            this.bubble8.Image = ((System.Drawing.Image)(resources.GetObject("bubble8.Image")));
            this.bubble8.Location = new System.Drawing.Point(922, 78);
            this.bubble8.Name = "bubble8";
            this.bubble8.Size = new System.Drawing.Size(106, 99);
            this.bubble8.TabIndex = 19;
            this.bubble8.TabStop = false;
            // 
            // bubble9
            // 
            this.bubble9.BackColor = System.Drawing.Color.Transparent;
            this.bubble9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bubble9.BackgroundImage")));
            this.bubble9.Image = ((System.Drawing.Image)(resources.GetObject("bubble9.Image")));
            this.bubble9.Location = new System.Drawing.Point(1074, 184);
            this.bubble9.Name = "bubble9";
            this.bubble9.Size = new System.Drawing.Size(106, 99);
            this.bubble9.TabIndex = 18;
            this.bubble9.TabStop = false;
            // 
            // bubble5
            // 
            this.bubble5.BackColor = System.Drawing.Color.Transparent;
            this.bubble5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bubble5.BackgroundImage")));
            this.bubble5.Image = ((System.Drawing.Image)(resources.GetObject("bubble5.Image")));
            this.bubble5.Location = new System.Drawing.Point(532, 194);
            this.bubble5.Name = "bubble5";
            this.bubble5.Size = new System.Drawing.Size(106, 99);
            this.bubble5.TabIndex = 17;
            this.bubble5.TabStop = false;
            // 
            // bubble4
            // 
            this.bubble4.BackColor = System.Drawing.Color.Transparent;
            this.bubble4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bubble4.BackgroundImage")));
            this.bubble4.Location = new System.Drawing.Point(398, 94);
            this.bubble4.Name = "bubble4";
            this.bubble4.Size = new System.Drawing.Size(106, 99);
            this.bubble4.TabIndex = 16;
            this.bubble4.TabStop = false;
            // 
            // bubble3
            // 
            this.bubble3.BackColor = System.Drawing.Color.Transparent;
            this.bubble3.Image = ((System.Drawing.Image)(resources.GetObject("bubble3.Image")));
            this.bubble3.Location = new System.Drawing.Point(225, 75);
            this.bubble3.Name = "bubble3";
            this.bubble3.Size = new System.Drawing.Size(87, 87);
            this.bubble3.TabIndex = 11;
            this.bubble3.TabStop = false;
            // 
            // bubble2
            // 
            this.bubble2.BackColor = System.Drawing.Color.Transparent;
            this.bubble2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bubble2.BackgroundImage")));
            this.bubble2.Location = new System.Drawing.Point(119, 75);
            this.bubble2.Name = "bubble2";
            this.bubble2.Size = new System.Drawing.Size(87, 87);
            this.bubble2.TabIndex = 10;
            this.bubble2.TabStop = false;
            // 
            // bubble10
            // 
            this.bubble10.BackColor = System.Drawing.Color.Transparent;
            this.bubble10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bubble10.BackgroundImage")));
            this.bubble10.Location = new System.Drawing.Point(1114, 78);
            this.bubble10.Name = "bubble10";
            this.bubble10.Size = new System.Drawing.Size(87, 87);
            this.bubble10.TabIndex = 9;
            this.bubble10.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1450, 753);
            this.Controls.Add(this.bubble11);
            this.Controls.Add(this.bubble7);
            this.Controls.Add(this.bubble6);
            this.Controls.Add(this.bubble8);
            this.Controls.Add(this.bubble9);
            this.Controls.Add(this.bubble5);
            this.Controls.Add(this.bubble4);
            this.Controls.Add(this.Lives_Counter);
            this.Controls.Add(this.Score_Counter);
            this.Controls.Add(this.Lives);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.bubble3);
            this.Controls.Add(this.bubble2);
            this.Controls.Add(this.bubble10);
            this.Controls.Add(this.boundary2);
            this.Controls.Add(this.boundary1);
            this.Controls.Add(this.boundary3);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bubble11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubble10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel boundary3;
        private System.Windows.Forms.Timer Game_Timer;
        private System.Windows.Forms.PictureBox bubble3;
        private System.Windows.Forms.PictureBox bubble2;
        private System.Windows.Forms.PictureBox bubble10;
        private System.Windows.Forms.Panel boundary2;
        private System.Windows.Forms.Panel boundary1;
        private System.Windows.Forms.Label Lives_Counter;
        private System.Windows.Forms.Label Score_Counter;
        private System.Windows.Forms.Label Lives;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox bubble7;
        private System.Windows.Forms.PictureBox bubble6;
        private System.Windows.Forms.PictureBox bubble8;
        private System.Windows.Forms.PictureBox bubble9;
        private System.Windows.Forms.PictureBox bubble5;
        private System.Windows.Forms.PictureBox bubble4;
        private System.Windows.Forms.PictureBox bubble11;
    }
}