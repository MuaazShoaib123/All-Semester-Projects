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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        PictureBox door;
        PictureBox player;
        ProgressBar player_power;
        PictureBox enemy;
        ProgressBar enemy_power;
        ProgressBar enemy_power2;
        PictureBox fire;
        PictureBox enemy_fire;
        PictureBox enemy2_fire;
        PictureBox score_increaser;
        PictureBox enemy2;
        PictureBox power_increaser;
        PictureBox live_increaser;
        List<PictureBox> movefire = new List<PictureBox>();
        List<PictureBox> moveenemyfire = new List<PictureBox>();
        string enemydirection = "Left";
        int enemyfiretime = 0;
        int firegenerationtime = 50;
        int count = 1;
        int count1 = 1;
        int temp = 0;
        int count2 = 0;
        int live = 0;
        int power = 1;
        bool flag, flag1, flag2,flag3, flag4, flag5, flag6, flag7, flag8,flag9, visible,visible1,visible2,visible3 = false;
        string enemy2direction = "Right";
        private void Door()
        {
            door = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.door;
            door.Image = img;
            door.Height = img.Height;
            door.Width = img.Width;
            door.BackColor = System.Drawing.Color.Transparent;
            door.Left = (this.Width / 2) - 458;
            door.Top = this.Height - 242;
            Controls.Add(door);
        }
        private void myplayer()
        {
            player = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.My_Player;
            player.Image = img;
            player.Height = img.Height;
            player.Width = img.Width;
            player.BackColor = System.Drawing.Color.Transparent;
            player.Left = (this.Width / 2) - 600;
            player.Top = this.Height - 250;
            this.Controls.Add(player);
            player_power = new ProgressBar();
            player_power.Value = 100;
            player_power.Left = (this.Width / 2) - 600;
            player_power.Top = this.Height - 110;
            this.Controls.Add(player_power);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            Score_Counter.Text = Class1.score.ToString();
            Lives_Counter.Text = Class1.lives.ToString();
            myplayer();
            Door();
            ghost();
            ghost2();
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
            if (enemy2direction == "Right")
            {
                enemy2.Left = enemy2.Left + 10;
                enemy_power2.Left = enemy_power2.Left + 10;
            }
            if (enemy2direction == "Left") {

                enemy2.Left = enemy2.Left - 10;
                enemy_power2.Left = enemy_power2.Left - 10;
            }
            if (enemy.Left <= 0)
            {
                enemydirection = "Right";
            }
            if (enemy.Bounds.IntersectsWith(boundary2.Bounds))
            {
                enemydirection = "Left";
            }
            if (enemyfiretime == firegenerationtime)
            {
                enemy_bullet();
                enemy2_bullet();
                enemyfiretime = 0;
            }
            enemyfiretime++;
            if (enemy2.Bounds.IntersectsWith(boundary2.Bounds))
            {
                enemy2direction = "Right";
            }
            if (enemy2.Left + enemy2.Width >= this.Width)
            {
                enemy2direction = "Left";
            }
            if (count1 == 1)
            {
                score_increaser = new PictureBox();
                Image img = Buuble_Game.Properties.Resources.ScoreIncreaser;
                score_increaser.Image = img;
                score_increaser.Height = img.Height;
                score_increaser.Width = img.Width;
                score_increaser.BackColor = System.Drawing.Color.Transparent;
                score_increaser.Left = enemy.Left + 80;
                score_increaser.Top = enemy.Top + 80;
                Controls.Add(score_increaser);
                score_increaser.Visible = false;
            }
            if (count1 == 3)
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
            if (temp == 1)
            {
                power_increaser = new PictureBox();
                Image img = Buuble_Game.Properties.Resources.PowerIncreaser;
                power_increaser.Image = img;
                power_increaser.Height = img.Height;
                power_increaser.Width = img.Width;
                power_increaser.BackColor = System.Drawing.Color.Transparent;
                power_increaser.Left = (this.Width / 2) - 150;
                power_increaser.Top = this.Height - 660;
                Controls.Add(power_increaser);
                power_increaser.Visible = false;
            }
            if (temp == 3)
            {
                power_increaser.Visible = true;
                power_increaser.Top = power_increaser.Top + 10;
                if (power_increaser.Bounds.IntersectsWith(player.Bounds) && visible1 == false)
                {
                    visible1 = true;
                    if (visible1 == true)
                    {
                        power_increaser.Visible = false;
                        if (player_power.Value != 100)
                        {
                            player_power.Value = player_power.Value + 5;
                        }
                    }
                }
            }
            if (live == 2)
            {
                live_increaser = new PictureBox();
                Image img = Buuble_Game.Properties.Resources.LiveIncreaser;
                live_increaser.Image = img;
                live_increaser.Height = img.Height;
                live_increaser.Width = img.Width;
                live_increaser.BackColor = System.Drawing.Color.Transparent;
                live_increaser.Left = (this.Width / 2) - 200;
                live_increaser.Top = this.Height - 660;
                Controls.Add(live_increaser);
                live_increaser.Visible = false;
            }
            if (live == 4)
            {
                live_increaser.Visible = true;
                live_increaser.Top = live_increaser.Top + 10;
                if (live_increaser.Bounds.IntersectsWith(player.Bounds) && visible2 == false)
                {
                    visible2 = true;
                    if (visible2 == true)
                    {
                        live_increaser.Visible = false;
                        Class1.lives = Class1.lives + 1;
                        Lives_Counter.Text = Class1.lives.ToString();
                    }
                }
            }
            if (count2 == 3)
            {
                score_increaser = new PictureBox();
                Image img = Buuble_Game.Properties.Resources.ScoreIncreaser;
                score_increaser.Image = img;
                score_increaser.Height = img.Height;
                score_increaser.Width = img.Width;
                score_increaser.BackColor = System.Drawing.Color.Transparent;
                score_increaser.Left = (this.Width/2) + 300;
                score_increaser.Top = this.Height - 660;
                Controls.Add(score_increaser);
                score_increaser.Visible = false;
            }
            if (count2 == 6)
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
            if(player.Left + player.Width >= this.Width)
            {
                player.Left = player.Left - 10;
                player_power.Left = player_power.Left - 10;
            }
            if (player.Bounds.IntersectsWith(door.Bounds) && door.Visible == true)
            {
                player.Left = player.Left - 10;
                player_power.Left = player_power.Left - 10;
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                bullet();
            }
            game_over();
            player_collide();
            enemy_collide();
            if (enemy_power.Value == 0)
            {
                enemy.Visible = false;
                enemy_fire.Visible = false;
                enemy_power.Visible = false;
                count = 0;
            }
            if(enemy_power2.Value == 0)
            {
                enemy2.Visible = false;
                enemy2_fire.Visible = false;
                enemy_power2.Visible = false;
                count = 0;
            }
            if(player_power.Value < 0)
            {
                player_power.Value = 100;
                Class1.lives--;
                Lives_Counter.Text = Class1.lives.ToString();
            }
            player_powercheck();
            move_bullet();
            remove_fire();
            bubble_collide();
            door_open();
            level_passed();
        }
        private void ghost()
        {
            enemy = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.enemy1;
            enemy.Image = img;
            enemy.Height = img.Height;
            enemy.Width = img.Width;
            enemy.BackColor = System.Drawing.Color.Transparent;
            enemy.Left = (this.Width / 2) - 700;
            enemy.Top = this.Height - 570;
            Controls.Add(enemy);
            enemy_power = new ProgressBar();
            enemy_power.Value = 100;
            enemy_power.Left = (this.Width / 2) - 650;
            enemy_power.Top = this.Height - 590;
            Controls.Add(enemy_power);
        }
        private void ghost2()
        {
            enemy2 = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.enemy2;
            enemy2.Image = img;
            enemy2.Height = img.Height;
            enemy2.Width = img.Width;
            enemy2.BackColor = System.Drawing.Color.Transparent;
            enemy2.Left = (this.Width / 2) - 20;
            enemy2.Top = this.Height - 480;
            Controls.Add(enemy2);
            enemy_power2 = new ProgressBar();
            enemy_power2.Value = 100;
            enemy_power2.Left = (this.Width / 2) + 20;
            enemy_power2.Top = this.Height - 500;
            Controls.Add(enemy_power2);
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
        private void enemy2_bullet()
        {
            enemy2_fire = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.enemy2fire;
            enemy2_fire.Image = img;
            enemy2_fire.Height = img.Height;
            enemy2_fire.Width = img.Width;
            enemy2_fire.BackColor = System.Drawing.Color.Transparent;
            enemy2_fire.Left = enemy2.Left + 80;
            enemy2_fire.Top = enemy2.Top + 60;
            moveenemyfire.Add(enemy2_fire);
            Controls.Add(enemy2_fire);
        }
        private void move_bullet()
        {
            foreach (PictureBox fire in movefire)
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
            for (int x = 0; x < movefire.Count; x = x + 1)
            {
                if (movefire[x].Bottom <= 0)
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
                if (enemy_power2.Value > 0)
                {
                    if (fire.Bounds.IntersectsWith(enemy2.Bounds))
                    {
                        enemy_power2.Value = enemy_power2.Value - 1;
                        fire.Visible = false;
                    }
                }
            }
        }
        private void player_collide()
        {
            foreach (PictureBox fire in moveenemyfire)
            {
                if (player_power.Value > 0 && count == 1)
                {
                    if (fire.Bounds.IntersectsWith(player.Bounds))
                    {

                        player_power.Value = player_power.Value - 2;
                        fire.Visible = false;
                    }
                }
            }
        }
        private void bubble_collide()
        {
            foreach (PictureBox fire in movefire)
            {
                if (fire.Bounds.IntersectsWith(bubble11.Bounds) && flag == false)
                {
                    flag = true;
                    bubble11.Visible = false;
                    fire.Visible = false;
                    if (flag == true)
                    {
                        count1++;
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble2.Bounds) && flag1 == false)
                {
                    flag1 = true;
                    bubble2.Visible = false;
                    fire.Visible = false;
                    if (flag1 == true)
                    {
                        count1++;
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble3.Bounds) && flag2 == false)
                {
                    flag2 = true;
                    bubble3.Visible = false;
                    fire.Visible = false;
                    if (flag2 == true)
                    { 
                        count1++;
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble4.Bounds) && flag3 == false)
                {
                    temp++;
                    live++;
                    count2++;
                    flag3 = true;
                    bubble4.Visible = false;
                    fire.Visible = false;
                    if (flag3 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble5.Bounds) && flag4 == false)
                {
                    temp++;
                    live++;
                    count2++;
                    flag4 = true;
                    bubble5.Visible = false;
                    fire.Visible = false;
                    if (flag4 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble6.Bounds) && flag5 == false)
                {
                    temp++;
                    live++;
                    count2++;
                    flag5 = true;
                    bubble6.Visible = false;
                    fire.Visible = false;
                    if (flag5 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble7.Bounds) && flag6 == false)
                {
                    temp++;
                    live++;
                    count2++;
                    flag6 = true;
                    bubble7.Visible = false;
                    fire.Visible = false;
                    if (flag6 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble8.Bounds) && flag7 == false)
                {
                    temp++;
                    live++;
                    count2++;
                    flag7 = true;
                    bubble8.Visible = false;
                    fire.Visible = false;
                    if (flag7 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble9.Bounds) && flag8 == false)
                {
                    temp++;
                    live++;
                    count2++;
                    flag8 = true;
                    bubble9.Visible = false;
                    fire.Visible = false;
                    if (flag8 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble10.Bounds) && flag9 == false)
                {
                    temp++;
                    live++;
                    count2++;
                    flag9 = true;
                    bubble10.Visible = false;
                    fire.Visible = false;
                    if (flag9 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
            }
        }
        private void door_open()
        {
            if (bubble11.Visible == false && bubble2.Visible == false && bubble3.Visible == false){
                door.Visible = false;
                count = 1;
            }
        }
        private void level_passed()
        {
            if (bubble4.Visible == false && bubble5.Visible == false && bubble6.Visible == false && bubble7.Visible == false && bubble8.Visible == false && bubble9.Visible == false && bubble10.Visible == false){
                Game_Timer.Enabled = false;
                Class1.count = 1;
                Form3 f = new Form3();
                f.Show();
                this.Hide();
            }
        }
        private void player_powercheck()
        {
            if (player_power.Value <= 0)
            {
                player_power.Value = 100;
                Class1.lives--;
                Lives_Counter.Text = Class1.lives.ToString();
            }
        }
        private void game_over()
        {
            if (Class1.lives == 0)
            {
                Application.Exit();
            }
        }
    }
}
