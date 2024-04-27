using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
using Buuble_Game.Variables;

namespace Buuble_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox player;
        PictureBox enemy;
        PictureBox fire;
        PictureBox enemy_fire;
        PictureBox score_increaser;
        ProgressBar player_power;
        ProgressBar enemy_power;
        PictureBox powerincreaser;
        List<PictureBox> movefire = new List<PictureBox>();
        List<PictureBox> moveenemyfire = new List<PictureBox>();
        List<PictureBox> movepower = new List<PictureBox>();
        string enemydirection = "Right";
        int enemyfiretime = 0;
        int firegenerationtime = 50;
        int count = 1;
        int temp = 0;
        int count1 = 0;
        int power = 1;
        bool flag,flag1,flag2,flag3,flag4,flag5,visible ,visible1= false;
        private void Form1_Load(object sender, EventArgs e)
        {
            ghost();
            myplayer();
        }
        private void myplayer()
        {
             player = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.My_Player;
            player.Image = img;
            player.Height = img.Height ;
            player.Width = img.Width ;
            player.BackColor = System.Drawing.Color.Transparent;
            player.Left = (this.Width / 2) -20;
            player.Top = this.Height - 250;
            this.Controls.Add(player);
            player_power = new ProgressBar();
            player_power.Value = 100;
            player_power.Left = (this.Width / 2) - 20;
            player_power.Top = this.Height - 100;
            this.Controls.Add(player_power);
        }
        private void Game_Timer_Tick(object sender, EventArgs e)
        {
            if (enemydirection == "Left")
            {
                enemy.Left = enemy.Left - 10;
                enemy_power.Left = enemy_power.Left - 10;
            }
            if (enemydirection == "Right")
            {
                enemy.Left = enemy.Left + 10;
                enemy_power.Left = enemy_power.Left + 10;
            }
            if (enemy.Left <= 0)
            {
                enemydirection = "Right";
            }
            if (temp == 2)
            {
                score_increaser = new PictureBox();
                Image img = Buuble_Game.Properties.Resources.ScoreIncreaser;
                score_increaser.Image = img;
                score_increaser.Height = img.Height;
                score_increaser.Width = img.Width;
                score_increaser.BackColor = System.Drawing.Color.Transparent;
                score_increaser.Left = (this.Width / 2) - 170;
                score_increaser.Top = this.Height - 660;
                Controls.Add(score_increaser);
                score_increaser.Visible = false;

            }

            if (count1 == 3)
            {
                powerincreaser = new PictureBox();
                Image img = Buuble_Game.Properties.Resources.PowerIncreaser;
                powerincreaser.Image = img;
                powerincreaser.Height = img.Height;
                powerincreaser.Width = img.Width;
                powerincreaser.BackColor = System.Drawing.Color.Transparent;
                powerincreaser.Left = (this.Width / 2) - 150;
                powerincreaser.Top = this.Height - 660;
                Controls.Add(powerincreaser);
                powerincreaser.Visible = false;
            }
            if(player_power.Value > 100)
            {
                player_power.Value = 100;
            }
            if (count1 == 4)
            {
                powerincreaser.Visible = true;
                powerincreaser.Top = powerincreaser.Top + 10;
                if (powerincreaser.Bounds.IntersectsWith(player.Bounds) && visible1 == false )
                {
                    visible1 = true;
                    if (visible == true)
                    {
                        if (player_power.Value != 100)
                        {
                            powerincreaser.Visible = false;
                            player_power.Value = player_power.Value + 5;
                        }
                    }
                }
            }
            if(temp == 3)
            {
                score_increaser.Visible = true;
                score_increaser.Top = score_increaser.Top + 10;
                if (score_increaser.Bounds.IntersectsWith(player.Bounds) && visible == false)
                {
                    visible = true;
                    if (visible == true)
                    {
                        score_increaser.Visible = false;
                        Class1.score = Class1.score + 50;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
            }
            if (enemy.Left + enemy.Width >= this.Width)
            {
                enemydirection = "Left";
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.Left = player.Left - 10;
                player_power.Left = player_power.Left - 10;
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.Left = player.Left + 10;
                player_power.Left = player_power.Left + 10;
            }
            if (player.Left <= 0)
            {
                player.Left = player.Left + 10;
                player_power.Left = player_power.Left + 10;
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                bullet();
            }
            if (player.Left + player.Width >= this.Width)
            {
                player.Left = player.Left - 10;
                player_power.Left = player_power.Left - 10;
            }
            move_bullet();
            remove_fire();
            enemyfiretime++;
            if (enemyfiretime == firegenerationtime)
            {
                enemy_bullet();
                enemyfiretime = 0;
            }
            player_collide();
            if (player_power.Value == 0)
            {
                Class1.lives--;
                player_power.Value = 100;
                Lives_Counter.Text = Class1.lives.ToString();
            }
            if(Class1.lives == 0)
            {
                Form6 f = new Form6();
                f.Show();
                this.Hide();
            }
            enemy_collide();
            if (enemy_power.Value == 0)
            {
                enemy.Visible = false;
                enemy_fire.Visible = false;
                enemy_power.Visible = false;
                count = 0;
            }
            bubbles_collide();
            levelpassed();
        }
        private void ghost()
        {
            enemy = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.enemy1;
            enemy.Image = img;
            enemy.Height = img.Height;
            enemy.Width = img.Width;
            enemy.BackColor = System.Drawing.Color.Transparent;
            enemy.Left = (this.Width / 2) - 20;
            enemy.Top = this.Height - 500;
            Controls.Add(enemy);
            enemy_power = new ProgressBar();
            enemy_power.Value = 100;
            enemy_power.Left = (this.Width / 2) + 30;
            enemy_power.Top = this.Height - 520;
            Controls.Add(enemy_power);
        }
        private void bullet()
        {
            fire = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.fire;
            fire.Image = img;
            fire.Height = img.Height;
            fire.Width = img.Width;
            fire.BackColor = System.Drawing.Color.Transparent;
            fire.Left = player.Left + 50;
            fire.Top = player.Top - 60;
            movefire.Add(fire);
            Controls.Add(fire);
        }
        private void enemy_bullet()
        {
            enemy_fire = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.enemyfire;
            enemy_fire.Image = img;
            enemy_fire.Height = img.Height;
            enemy_fire.Width = img.Width;
            enemy_fire.BackColor = System.Drawing.Color.Transparent;
            enemy_fire.Left = enemy.Left + 80;
            enemy_fire.Top = enemy.Top + 60;
            moveenemyfire.Add(enemy_fire);
            Controls.Add(enemy_fire);
        }
        private void move_bullet()
        {
            foreach (PictureBox fire in movefire )
            {
                fire.Top = fire.Top - 10;
            }
            foreach (PictureBox enemyfire in moveenemyfire)
            {
                enemyfire.Top = enemyfire.Top + 10;
            }
                    
        }
        private void remove_fire()
        {
            for(int x = 0; x < movefire.Count; x = x + 1)
            {
                if(movefire[x].Bottom <= 0)
                {
                    movefire.Remove(movefire[x]);
                }
            }
            for (int x = 0; x < moveenemyfire.Count; x = x + 1)
            {
                if (moveenemyfire[x].Top == this.Height)
                {
                    moveenemyfire.Remove(moveenemyfire[x]);
                }
            }
        }

        private void player_collide()
        {
            foreach (PictureBox fire in moveenemyfire)
            {
                if (player_power.Value > 0 && count == 1 )
                {
                    if (fire.Bounds.IntersectsWith(player.Bounds))
                    {
                        player_power.Value = player_power.Value - 2;
                        fire.Visible = false;
                    }
                }
            }
        }
        private void enemy_collide()
        {
            foreach (PictureBox fire in movefire)
            {
                if (enemy_power.Value > 0)
                {
                    if (fire.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        enemy_power.Value = enemy_power.Value - 1;
                        fire.Visible = false;
                    }
                }
            }
        }
        private void bubbles_collide()
        {
            foreach (PictureBox fire in movefire)
            {
                if (fire.Bounds.IntersectsWith(Bubble1.Bounds) && flag == false)
                    {
                    flag = true;
                    Bubble1.Visible = false;
                    fire.Visible = false;
                    if (flag == true)
                    {
                        temp = temp + 1;
                        count1++;
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(Bubble2.Bounds) && flag1 == false)
                {
                    flag1 = true;
                    Bubble2.Visible = false;
                    fire.Visible = false;
                    if (flag1 == true)
                    {
                        temp = temp + 1;
                        count1++;
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(Bubble3.Bounds) && flag2 == false)
                {
                    flag2 = true;
                    Bubble3.Visible = false;
                    fire.Visible = false;
                    if (flag2 == true)
                    {
                        temp = temp + 1;
                        count1++;
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(Bubble4.Bounds) && flag3 == false)
                {
                    flag3 = true;
                    Bubble4.Visible = false;
                    fire.Visible = false;
                    if (flag3 == true)
                    {
                        temp = temp + 1;
                        count1++;
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                 if (fire.Bounds.IntersectsWith(Bubble5.Bounds) && flag4 == false)
                {
                    flag4 = true;
                    Bubble5.Visible = false;
                    fire.Visible = false;
                    if (flag4 == true)
                    {
                        temp = temp + 1;
                        count1++;
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(Bubble6.Bounds) && flag5 == false)
                {
                    flag5 = true;
                    Bubble6.Visible = false;
                    fire.Visible = false;
                    if (flag5 == true)
                    {
                        temp = temp + 1;
                        count1++;
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
            }
        }
        private void levelpassed()
        {
            if (Bubble1.Visible == false && Bubble2.Visible == false && Bubble3.Visible == false && Bubble4.Visible == false && Bubble5.Visible == false && Bubble6.Visible == false)
            {
                Game_Timer.Enabled = false;
                Form3 f = new Form3();
                f.Show();
                this.Hide();
            }
        }
            
    }
}
