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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        PictureBox door;
        PictureBox door2;
        PictureBox player;
        ProgressBar player_power;
        PictureBox enemy;
        ProgressBar enemy_power;
        PictureBox enemy2;
        ProgressBar enemy_power2;
        PictureBox enemy3;
        ProgressBar enemy_power3;
        PictureBox enemy4;
        ProgressBar enemy_power4;
        PictureBox enemy_fire;
        PictureBox enemy2_fire;
        PictureBox enemy3_fire;
        PictureBox enemy4_fire;
        PictureBox fire;
        PictureBox score_increaser;
        PictureBox power_increaser;
        PictureBox live_increaser;
        List<PictureBox> moveenemyfire = new List<PictureBox>();
        List<PictureBox> movefire = new List<PictureBox>();
        List<PictureBox> move2enemyfire = new List<PictureBox>();
        int enemyfiretime = 0;
        int count = 1;
        int count1 = 1;
        int count2 = 0;
        int live = 0;
        int temp = 0;
        int last = 0;
        int firegenerationtime = 50;
        string enemydirection = "Left";
        string enemy2direction = "Right";
        string enemy3direction = "Left";
        string enemy4direction = "Left";
        bool flag, flag1, flag2,flag3,flag4,flag5,flag6,flag7,flag8,flag9,flag10,flag11,flag12,visible,visible1,visible2,visible3,visible4,visible5 = false;
        private void door1()
        {
            door = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.door;
            door.Image = img;
            door.Height = img.Height;
            door.Width = img.Width;
            door.BackColor = System.Drawing.Color.Transparent;
            door.Left = (this.Width / 2) - 538;
            door.Top = this.Height - 242;
            Controls.Add(door);
        }
        private void Door2()
        {
            door2 = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.door2;
            door2.Image = img;
            door2.Height = img.Height;
            door2.Width = img.Width;
            door2.BackColor = System.Drawing.Color.Transparent;
            door2.Left = (this.Width / 2) + 388;
            door2.Top = this.Height - 242;
            Controls.Add(door2);
        }
        private void myplayer()
        {
            player = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.My_Player;
            player.Image = img;
            player.Height = img.Height;
            player.Width = img.Width;
            player.BackColor = System.Drawing.Color.Transparent;
            player.Left = (this.Width / 2) - 680;
            player.Top = this.Height - 250;
            this.Controls.Add(player);
            player_power = new ProgressBar();
            player_power.Value = 100;
            player_power.Left = (this.Width / 2) - 680;
            player_power.Top = this.Height - 110;
            this.Controls.Add(player_power);
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
            enemy.Top = this.Height - 560;
            Controls.Add(enemy);
            enemy_power = new ProgressBar();
            enemy_power.Value = 100;
            enemy_power.Left = (this.Width / 2) - 650;
            enemy_power.Top = this.Height - 570;
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
            enemy2.Top = this.Height - 530;
            Controls.Add(enemy2);
            enemy_power2 = new ProgressBar();
            enemy_power2.Value = 100;
            enemy_power2.Left = (this.Width / 2) + 20;
            enemy_power2.Top = this.Height - 540;
            Controls.Add(enemy_power2);
        }
        private void ghost3()
        {
            enemy3 = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.enemy3;
            enemy3.Image = img;
            enemy3.Height = img.Height;
            enemy3.Width = img.Width;
            enemy3.BackColor = System.Drawing.Color.Transparent;
            enemy3.Left = enemy3.Left + 570;
            enemy3.Top = this.Height - 430;
            Controls.Add(enemy3);
            enemy_power3 = new ProgressBar();
            enemy_power3.Value = 100;
            enemy_power3.Left = enemy_power3.Left + 630;
            enemy_power3.Top = this.Height - 440;
            Controls.Add(enemy_power3);
        }
        private void ghost4()
        {
            enemy4 = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.enemy3;
            enemy4.Image = img;
            enemy4.Height = img.Height;
            enemy4.Width = img.Width;
            enemy4.BackColor = System.Drawing.Color.Transparent;
            enemy4.Left = enemy3.Left + 610;
            enemy4.Top = this.Height - 550;
            Controls.Add(enemy4);
            enemy_power4 = new ProgressBar();
            enemy_power4.Value = 100;
            enemy_power4.Left = enemy_power4.Left + 1240;
            enemy_power4.Top = this.Height - 560;
            Controls.Add(enemy_power4);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Score_Counter.Text = Class1.score.ToString();
            Lives_Counter.Text = Class1.lives.ToString();
            door1();
            Door2();
            myplayer();
            ghost();
            ghost2();
            ghost3();
            ghost4();
        }

        private void Game_timer_Tick(object sender, EventArgs e)
        {
            if(player_power.Value > 100)
            {
                player_power.Value = 100;
            }
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
            if (enemy2direction == "Left")
            {

                enemy2.Left = enemy2.Left - 10;
                enemy_power2.Left = enemy_power2.Left - 10;
            }
            if (enemy3direction == "Left")
            {
                enemy3.Left = enemy3.Left - 10;
                enemy_power3.Left = enemy_power3.Left - 10;

            }
            if (enemy3direction == "Right")
            {
                enemy3.Left = enemy3.Left + 10;
                enemy_power3.Left = enemy_power3.Left + 10;
            }
            if (enemy4direction == "Left")
            {
                enemy4.Left = enemy4.Left - 10;
                enemy_power4.Left = enemy_power4.Left - 10;
            }
            if (enemy4direction == "Right")
            {
                enemy4.Left = enemy4.Left + 10;
                enemy_power4.Left = enemy_power4.Left + 10;
            }
            if (enemy.Left <= 0)
            {
                enemydirection = "Right";
            }
            if (enemy.Bounds.IntersectsWith(panel1.Bounds))
            {
                enemydirection = "Left";
            }
            if (enemy2.Bounds.IntersectsWith(panel1.Bounds))
            {
                enemy2direction = "Right";
            }
            if (enemy2.Bounds.IntersectsWith(panel2.Bounds))
            {
                enemy2direction = "Left";
            }
            if (enemy3.Bounds.IntersectsWith(panel1.Bounds))
            {
                enemy3direction = "Right";
            }
            if (enemy3.Bounds.IntersectsWith(panel2.Bounds))
            {
                enemy3direction = "Left";
            }
            if (enemy4.Bounds.IntersectsWith(panel2.Bounds))
            {
                enemy4direction = "Right";
            }
            if (enemy4.Left + enemy4.Width >= this.Width)
            {
                enemy4direction = "Left";
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
            if (player.Bounds.IntersectsWith(door.Bounds) && door.Visible == true)
            {
                player.Left = player.Left - 10;
                player_power.Left = player_power.Left - 10;
            }
            if (enemyfiretime == firegenerationtime)
            {
                enemy_bullet();
                enemy2_bullet();
                enemy3_bullet();
                enemy4_bullet();
                enemyfiretime = 0;
            }
            enemyfiretime++;
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                bullet();
            }
            if (enemy_power.Value == 0)
            {
                enemy.Visible = false;
                enemy_fire.Visible = false;
                enemy_power.Visible = false;
                count = 0;
            }
            if (enemy_power2.Value == 0)
            {
                enemy2.Visible = false;
                enemy2_fire.Visible = false;
                enemy_power2.Visible = false;
                count = 0;
            }
            if (enemy_power3.Value == 0)
            {
                enemy3.Visible = false;
                enemy3_fire.Visible = false;
                enemy_power3.Visible = false;
                count1 = 0;
            }
            if(door2.Visible == false)
            {
                count1 = 1;
            }
            if (door.Visible == false)
            {
                count = 1;
            }
            if (enemy_power4.Value == 0)
            {
                enemy4.Visible = false;
                enemy4_fire.Visible = false;
                enemy_power4.Visible = false;
                count1 = 0;
            }
            if(player_power.Value < 0)
            {
                player_power.Value = 100;
                Class1.lives--;
                Lives_Counter.Text = Class1.lives.ToString();
            }
            game_over();
            player_powercheck();
            move_bullet();
            remove_fire();
            player_collide();
            enemy_collide();
            bubble_collide();
            door_open();
            door2_open();
            through_powerups();
            level_passed();
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
        private void enemy3_bullet()
        {
            enemy3_fire = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.enemy3fire;
            enemy3_fire.Image = img;
            enemy3_fire.Height = img.Height;
            enemy3_fire.Width = img.Width;
            enemy3_fire.BackColor = System.Drawing.Color.Transparent;
            enemy3_fire.Left = enemy3.Left + 80;
            enemy3_fire.Top = enemy3.Top + 60;
            move2enemyfire.Add(enemy3_fire);
            Controls.Add(enemy3_fire);
        }
        private void enemy4_bullet()
        {
            enemy4_fire = new PictureBox();
            Image img = Buuble_Game.Properties.Resources.enemy3fire;
            enemy4_fire.Image = img;
            enemy4_fire.Height = img.Height;
            enemy4_fire.Width = img.Width;
            enemy4_fire.BackColor = System.Drawing.Color.Transparent;
            enemy4_fire.Left = enemy4.Left + 80;
            enemy4_fire.Top = enemy4.Top + 60;
            move2enemyfire.Add(enemy4_fire);
            Controls.Add(enemy4_fire);
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
            foreach (PictureBox enemy2fire in move2enemyfire)
            {
                enemy2fire.Top = enemy2fire.Top + 10;
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
            for (int x = 0; x < move2enemyfire.Count; x = x + 1)
            {
                if (move2enemyfire[x].Top == this.Height)
                {
                    move2enemyfire.Remove(move2enemyfire[x]);
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
                if (enemy_power3.Value > 0)
                {
                    if (fire.Bounds.IntersectsWith(enemy3.Bounds))
                    {
                        enemy_power3.Value = enemy_power3.Value - 1;
                        fire.Visible = false;
                    }
                }
                if (enemy_power4.Value > 0)
                {
                    if (fire.Bounds.IntersectsWith(enemy4.Bounds))
                    {
                        enemy_power4.Value = enemy_power4.Value - 1;
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
                        player_powercheck();
                        player_power.Value = player_power.Value - 2;
                        fire.Visible = false;
                    }
                }
            }
            foreach (PictureBox fire in move2enemyfire)
            {
                if (player_power.Value > 0 && count1 == 1)
                {
                    if (fire.Bounds.IntersectsWith(player.Bounds))
                    {
                        player_powercheck();
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
                        count2++;
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
                        count2++;
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
                        count2++;
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble4.Bounds) && flag3 == false)
                {
                    temp++;
                    live++;
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
                    flag9 = true;
                    bubble10.Visible = false;
                    fire.Visible = false;
                    if (flag9 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble12.Bounds) && flag10 == false)
                {
                    last++;
                    flag10 = true;
                    bubble12.Visible = false;
                    fire.Visible = false;
                    if (flag10 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble13.Bounds) && flag11 == false)
                {
                    last++;
                    flag11 = true;
                    bubble13.Visible = false;
                    fire.Visible = false;
                    if (flag11 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                if (fire.Bounds.IntersectsWith(bubble14.Bounds) && flag12 == false)
                {
                    last++;
                    flag12 = true;
                    bubble14.Visible = false;
                    fire.Visible = false;
                    if (flag12 == true)
                    {
                        Class1.score = Class1.score + 10;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
            }
        }
        private void door_open()
        {
            if (bubble11.Visible == false && bubble2.Visible == false && bubble3.Visible == false)
            {
                door.Visible = false;
            }
        }
        private void door2_open()
        {
            if (bubble4.Visible == false && bubble5.Visible == false && bubble6.Visible == false && bubble7.Visible == false && bubble8.Visible == false && bubble9.Visible == false && bubble10.Visible == false)
            {
                door2.Visible = false;
            }
        }
        private void player_powercheck()
        {
            if(player_power.Value <= 0)
            {
                player_power.Value = 100;
                Class1.lives--;
                Lives_Counter.Text = Class1.lives.ToString();
            }
            if(player_power.Value > 100)
            {
                player_power.Value = 100;
            }
        }
        private void through_powerups()
        {
            if (count2 == 1)
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
                power_increaser = new PictureBox();
                Image img1 = Buuble_Game.Properties.Resources.PowerIncreaser;
                power_increaser.Image = img1;
                power_increaser.Height = img1.Height;
                power_increaser.Width = img1.Width;
                power_increaser.BackColor = System.Drawing.Color.Transparent;
                power_increaser.Left = enemy.Left + 100;
                power_increaser.Top = enemy.Top + 100;
                Controls.Add(power_increaser);
                power_increaser.Visible = false;
            }
            if (count2 == 2)
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
            if (live == 3)
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
            if (temp == 2)
            {
                score_increaser = new PictureBox();
                Image img = Buuble_Game.Properties.Resources.ScoreIncreaser;
                score_increaser.Image = img;
                score_increaser.Height = img.Height;
                score_increaser.Width = img.Width;
                score_increaser.BackColor = System.Drawing.Color.Transparent;
                score_increaser.Left = (this.Width / 2) + 300;
                score_increaser.Top = this.Height - 660;
                Controls.Add(score_increaser);
                score_increaser.Visible = false;
                power_increaser = new PictureBox();
                Image img1 = Buuble_Game.Properties.Resources.PowerIncreaser;
                power_increaser.Image = img1;
                power_increaser.Height = img1.Height;
                power_increaser.Width = img1.Width;
                power_increaser.BackColor = System.Drawing.Color.Transparent;
                power_increaser.Left = enemy2.Left + 100;
                power_increaser.Top = enemy2.Top + 100;
                Controls.Add(power_increaser);
                power_increaser.Visible = false;
            }
            if (temp == 4)
            {
                score_increaser.Visible = true;
                score_increaser.Top = score_increaser.Top + 10;
                if (score_increaser.Bounds.IntersectsWith(player.Bounds) && visible3 == false)
                {
                    visible3 = true;
                    if (visible3 == true)
                    {
                        score_increaser.Visible = false;
                        Class1.score = Class1.score + 50;
                        Score_Counter.Text = Class1.score.ToString();
                    }
                }
                power_increaser.Visible = true;
                power_increaser.Top = power_increaser.Top + 10;
                if (power_increaser.Bounds.IntersectsWith(player.Bounds) && visible4 == false)
                {
                    visible4 = true;
                    if (visible4 == true)
                    {
                        power_increaser.Visible = false;
                        if (player_power.Value != 100 )
                        {
                            player_power.Value = player_power.Value + 5;
                        }
                    }
                }
            }
            if (last == 1)
            {
                power_increaser = new PictureBox();
                Image img1 = Buuble_Game.Properties.Resources.PowerIncreaser;
                power_increaser.Image = img1;
                power_increaser.Height = img1.Height;
                power_increaser.Width = img1.Width;
                power_increaser.BackColor = System.Drawing.Color.Transparent;
                power_increaser.Left = enemy4.Left + 20;
                power_increaser.Top = enemy4.Top + 10;
                Controls.Add(power_increaser);
                power_increaser.Visible = false;

            }
            if (last == 2)
            {
                power_increaser.Visible = true;
                power_increaser.Top = power_increaser.Top + 10;
                if (power_increaser.Bounds.IntersectsWith(player.Bounds) && visible5 == false)
                {
                    visible5 = true;
                    if (visible5 == true)
                    {
                        power_increaser.Visible = false;
                        if (player_power.Value != 100)
                        {
                            player_power.Value = player_power.Value + 5;
                        }
                    }
                }
            }
        }
        private void level_passed()
        {
            if(bubble12.Visible == false && bubble13.Visible == false && bubble14.Visible == false)
            {
                Game_timer.Enabled = false;
                Form6 f = new Form6();
                f.Show();
                this.Hide();
            }
        }
        private void game_over()
        {
            if(Class1.lives == 0)
            {
                Game_timer.Enabled = false;
                Form6 f = new Form6();
                f.Show();
                this.Hide();
            }
        }
    }
}
