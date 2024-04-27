
namespace Buuble_Game
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Lives_Counter = new System.Windows.Forms.Label();
            this.Score_Counter = new System.Windows.Forms.Label();
            this.Lives = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(530, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(530, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lives_Counter
            // 
            this.Lives_Counter.AutoSize = true;
            this.Lives_Counter.BackColor = System.Drawing.Color.Transparent;
            this.Lives_Counter.Font = new System.Drawing.Font("Malgun Gothic", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lives_Counter.ForeColor = System.Drawing.Color.White;
            this.Lives_Counter.Location = new System.Drawing.Point(619, 103);
            this.Lives_Counter.Name = "Lives_Counter";
            this.Lives_Counter.Size = new System.Drawing.Size(26, 30);
            this.Lives_Counter.TabIndex = 19;
            this.Lives_Counter.Text = "3";
            // 
            // Score_Counter
            // 
            this.Score_Counter.AutoSize = true;
            this.Score_Counter.BackColor = System.Drawing.Color.Transparent;
            this.Score_Counter.Font = new System.Drawing.Font("Malgun Gothic", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Counter.ForeColor = System.Drawing.Color.White;
            this.Score_Counter.Location = new System.Drawing.Point(619, 46);
            this.Score_Counter.Name = "Score_Counter";
            this.Score_Counter.Size = new System.Drawing.Size(26, 30);
            this.Score_Counter.TabIndex = 18;
            this.Score_Counter.Text = "0";
            // 
            // Lives
            // 
            this.Lives.AutoSize = true;
            this.Lives.BackColor = System.Drawing.Color.Transparent;
            this.Lives.Font = new System.Drawing.Font("Malgun Gothic", 24.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lives.ForeColor = System.Drawing.Color.White;
            this.Lives.Location = new System.Drawing.Point(495, 91);
            this.Lives.Name = "Lives";
            this.Lives.Size = new System.Drawing.Size(118, 45);
            this.Lives.TabIndex = 17;
            this.Lives.Text = "Lives :";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Malgun Gothic", 24.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(486, 34);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(127, 45);
            this.Score.TabIndex = 16;
            this.Score.Text = "Score :";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(664, 433);
            this.Controls.Add(this.Lives_Counter);
            this.Controls.Add(this.Score_Counter);
            this.Controls.Add(this.Lives);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lives_Counter;
        private System.Windows.Forms.Label Score_Counter;
        private System.Windows.Forms.Label Lives;
        private System.Windows.Forms.Label Score;
    }
}