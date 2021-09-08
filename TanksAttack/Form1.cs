using System;
using System.Drawing;
using System.Windows.Forms;

// Да, я знаю, это форма, это примитивно, оно выглядит убого и лагает, 
// но я очень старался, поэтому не кидайте палками. (

namespace TanksAttack
{
    public partial class game_window : Form
    {
        // Клавиши
        bool _up, _down, _right;
        // Теги для сущностей
        string _blockTag = "block", _enemyTag = "enemy";
        Random _random = new Random();
        // Рекорд
        int _iteration, _score;

        public game_window()
        {
            InitializeComponent();
            over_lbl.Visible = false;
        }

        // Здесь мы будем поднимать уровень игрока, когда он будет убивать врагов
        void Game_Result()
        {
            foreach(Control control in this.Controls)
            {
                if(control is PictureBox && control.Tag == "block")
                {
                    if (player.Bounds.IntersectsWith(control.Bounds) 
                        || player.Bounds.IntersectsWith(en_1.Bounds)
                        || player.Bounds.IntersectsWith(en_2.Bounds)
                        || player.Bounds.IntersectsWith(enemy1.Bounds)
                        || player.Bounds.IntersectsWith(enemy2.Bounds))
                    {
                        over_lbl.Visible = true;
                        timer1.Stop();
                    }

                    if (score_lbl.Text == "Score: 200")
                    {
                        over_lbl.Text = "Level Up!";
                        over_lbl.Visible = true;
                        timer1.Stop();
                    }
                }
            }
        }

        // Здесь мы задаёи движение танка игрока по пикселям
        void Player_Move()
        {
            if (_up == true)
                if (player.Top > 50)
                    player.Top -= 5;
                
            if (_down == true)
                if (player.Top < 220)
                    player.Top += 5;

            if (_right == true)
                player.Left += 5;
        }

        // Здесь мы задаём движение спрайтов и увеличиваем рекорд
        // в процессе продвижения по уровню
        void Block()
        {
            foreach (Control sprite in this.Controls)
            {
                if (sprite is PictureBox && sprite.Tag == _blockTag)
                    if (sprite.Left < -150)
                    {
                        sprite.Left = 700;
                        _score += 1;
                        score_lbl.Text = "Score: " + _score;
                    }
                    if (_right == true)
                        sprite.Left -= 5;
            }
        }

        // Здесь мы задаём движение для вражеских пуль и пуль игрока
        void Bullets()
        {
            b_1.Left += 20;
            if (b_1.Left > 400)
            {
                b_1.Left = player.Left + 40;
                b_1.Top = player.Top;
                b_1.Image = Properties.Resources.tank_bullet;
            }
            en_1.Left -= 20;
            if (en_1.Left < 10)
            {
                en_1.Image = Properties.Resources.enemy_bullet;
                en_1.Left = enemy1.Left;
                en_1.Top = enemy1.Top + 8;
            }
            en_2.Left -= 20;
            if (en_2.Left < 10)
            {
                en_2.Image = Properties.Resources.enemy_bullet;
                en_2.Left = enemy2.Left;
                en_2.Top = enemy2.Top + 8;
            }
        }

        // Здесь мы рандомно генерируем врагов и увеличиваем
        // рекорд в случае попадания по врагу
        void Enemys()
        {
            foreach (Control sprite in this.Controls)
            {
                if (sprite is PictureBox && sprite.Tag == _enemyTag)
                {
                    sprite.Left -= 6;
                    if (sprite.Left < 10)
                    {
                        _iteration = _random.Next(50, 600);
                        sprite.Location = new Point(800, 100);
                    }

                    if (b_1.Bounds.IntersectsWith(sprite.Bounds))
                    {
                        _score += 5;
                        score_lbl.Text = "Score: " + _score;
                        sprite.Left = 800;
                        b_1.Image = Properties.Resources.explosion;
                    }
                }
            }
        }

        // Таймер отвечает за весь геймплей
        private void timer1_Tick(object sender, EventArgs e)
        {
            Player_Move();
            Block();
            Enemys();
            Bullets();
            Game_Result();
        }

        // Здесь мы ставим прозрачный фон, чтобы он не подтягивался
        // вместе с основным фоном, а также просим пользователя зарегистрироваться
        private void game_window_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
            this.WindowState = FormWindowState.Minimized;
            MessageBox.Show("Чтобы Ваш прогресс не был потерян, пройдите регистрацию в приложении одноимённого сервиса!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Здесь мы задаём управление
        private void game_window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _up = true;
                    break;
                case Keys.Down:
                    _down = true;
                    break;
                case Keys.Right:
                    _right = true;
                    break;
            }
        }

        private void game_window_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: 
                    _up = false; 
                    break;
                case Keys.Down: 
                    _down = false; 
                    break;
                case Keys.Right: 
                    _right = false; 
                    break;
            }
        }
    }
}
