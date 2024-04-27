
namespace Buuble_Game
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
            this.Game_Timer = new System.Windows.Forms.Timer(this.components);
            this.Bubble1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bubble2 = new System.Windows.Forms.PictureBox();
            this.Bubble6 = new System.Windows.Forms.PictureBox();
            this.Bubble5 = new System.Windows.Forms.PictureBox();
            this.Bubble3 = new System.Windows.Forms.PictureBox();
            this.Bubble4 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Lives = new System.Windows.Forms.Label();
            this.Score_Counter = new System.Windows.Forms.Label();
            this.Lives_Counter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble4)).BeginInit();
            this.SuspendLayout();
            // 
            // Game_Timer
            // 
            this.Game_Timer.Enabled = true;
            this.Game_Timer.Interval = 18;
            this.Game_Timer.Tick += new System.EventHandler(this.Game_Timer_Tick);
            // 
            // Bubble1
            // 
            this.Bubble1.BackColor = System.Drawing.Color.Transparent;
            this.Bubble1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bubble1.BackgroundImage")));
            this.Bubble1.Location = new System.Drawing.Point(32, 57);
            this.Bubble1.Name = "Bubble1";
            this.Bubble1.Size = new System.Drawing.Size(106, 99);
            this.Bubble1.TabIndex = 0;
            this.Bubble1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(-5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 49);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(-5, 635);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 44);
            this.panel2.TabIndex = 2;
            // 
            // Bubble2
            // 
            this.Bubble2.BackColor = System.Drawing.Color.Transparent;
            this.Bubble2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bubble2.BackgroundImage")));
            this.Bubble2.Image = ((System.Drawing.Image)(resources.GetObject("Bubble2.Image")));
            this.Bubble2.Location = new System.Drawing.Point(180, 57);
            this.Bubble2.Name = "Bubble2";
            this.Bubble2.Size = new System.Drawing.Size(106, 99);
            this.Bubble2.TabIndex = 3;
            this.Bubble2.TabStop = false;
            // 
            // Bubble6
            // 
            this.Bubble6.BackColor = System.Drawing.Color.Transparent;
            this.Bubble6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bubble6.BackgroundImage")));
            this.Bubble6.Image = ((System.Drawing.Image)(resources.GetObject("Bubble6.Image")));
            this.Bubble6.Location = new System.Drawing.Point(946, 57);
            this.Bubble6.Name = "Bubble6";
            this.Bubble6.Size = new System.Drawing.Size(106, 99);
            this.Bubble6.TabIndex = 4;
            this.Bubble6.TabStop = false;
            // 
            // Bubble5
            // 
            this.Bubble5.BackColor = System.Drawing.Color.Transparent;
            this.Bubble5.Image = ((System.Drawing.Image)(resources.GetObject("Bubble5.Image")));
            this.Bubble5.Location = new System.Drawing.Point(816, 57);
            this.Bubble5.Name = "Bubble5";
            this.Bubble5.Size = new System.Drawing.Size(106, 99);
            this.Bubble5.TabIndex = 5;
            this.Bubble5.TabStop = false;
            // 
            // Bubble3
            // 
            this.Bubble3.BackColor = System.Drawing.Color.Transparent;
            this.Bubble3.Image = ((System.Drawing.Image)(resources.GetObject("Bubble3.Image")));
            this.Bubble3.Location = new System.Drawing.Point(454, 57);
            this.Bubble3.Name = "Bubble3";
            this.Bubble3.Size = new System.Drawing.Size(106, 99);
            this.Bubble3.TabIndex = 6;
            this.Bubble3.TabStop = false;
            // 
            // Bubble4
            // 
            this.Bubble4.BackColor = System.Drawing.Color.Transparent;
            this.Bubble4.Image = ((System.Drawing.Image)(resources.GetObject("Bubble4.Image")));
            this.Bubble4.Location = new System.Drawing.Point(577, 57);
            this.Bubble4.Name = "Bubble4";
            this.Bubble4.Size = new System.Drawing.Size(106, 99);
            this.Bubble4.TabIndex = 7;
            this.Bubble4.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Malgun Gothic", 24.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Black;
            this.Score.Location = new System.Drawing.Point(1078, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(127, 45);
            this.Score.TabIndex = 8;
            this.Score.Text = "Score :";
            // 
            // Lives
            // 
            this.Lives.AutoSize = true;
            this.Lives.BackColor = System.Drawing.Color.Transparent;
            this.Lives.Font = new System.Drawing.Font("Malgun Gothic", 24.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lives.ForeColor = System.Drawing.Color.Black;
            this.Lives.Location = new System.Drawing.Point(1078, 67);
            this.Lives.Name = "Lives";
            this.Lives.Size = new System.Drawing.Size(118, 45);
            this.Lives.TabIndex = 9;
            this.Lives.Text = "Lives :";
            // 
            // Score_Counter
            // 
            this.Score_Counter.AutoSize = true;
            this.Score_Counter.BackColor = System.Drawing.Color.Transparent;
            this.Score_Counter.Font = new System.Drawing.Font("Malgun Gothic", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Counter.ForeColor = System.Drawing.Color.Black;
            this.Score_Counter.Location = new System.Drawing.Point(1202, 21);
            this.Score_Counter.Name = "Score_Counter";
            this.Score_Counter.Size = new System.Drawing.Size(26, 30);
            this.Score_Counter.TabIndex = 10;
            this.Score_Counter.Text = "0";
            // 
            // Lives_Counter
            // 
            this.Lives_Counter.AutoSize = true;
            this.Lives_Counter.BackColor = System.Drawing.Color.Transparent;
            this.Lives_Counter.Font = new System.Drawing.Font("Malgun Gothic", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lives_Counter.ForeColor = System.Drawing.Color.Black;
            this.Lives_Counter.Location = new System.Drawing.Point(1202, 82);
            this.Lives_Counter.Name = "Lives_Counter";
            this.Lives_Counter.Size = new System.Drawing.Size(26, 30);
            this.Lives_Counter.TabIndex = 11;
            this.Lives_Counter.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1273, 679);
            this.Controls.Add(this.Lives_Counter);
            this.Controls.Add(this.Score_Counter);
            this.Controls.Add(this.Lives);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Bubble4);
            this.Controls.Add(this.Bubble3);
            this.Controls.Add(this.Bubble5);
            this.Controls.Add(this.Bubble6);
            this.Controls.Add(this.Bubble2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bubble1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackColorChanged += new System.EventHandler(this.Form1_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bubble1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bubble4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Game_Timer;
        private System.Windows.Forms.PictureBox Bubble1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Bubble2;
        private System.Windows.Forms.PictureBox Bubble6;
        private System.Windows.Forms.PictureBox Bubble5;
        private System.Windows.Forms.PictureBox Bubble3;
        private System.Windows.Forms.PictureBox Bubble4;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Lives;
        private System.Windows.Forms.Label Score_Counter;
        private System.Windows.Forms.Label Lives_Counter;
    }
}

