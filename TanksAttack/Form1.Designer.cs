
namespace TanksAttack
{
    partial class game_window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game_window));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score_lbl = new System.Windows.Forms.Label();
            this.b_1 = new System.Windows.Forms.PictureBox();
            this.en_2 = new System.Windows.Forms.PictureBox();
            this.en_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.over_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.Color.Black;
            this.score_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.score_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_lbl.ForeColor = System.Drawing.Color.Yellow;
            this.score_lbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.score_lbl.Location = new System.Drawing.Point(0, 20);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(63, 19);
            this.score_lbl.TabIndex = 23;
            this.score_lbl.Text = "Score: 0";
            // 
            // b_1
            // 
            this.b_1.BackColor = System.Drawing.Color.Transparent;
            this.b_1.Image = global::TanksAttack.Properties.Resources.tank_bullet;
            this.b_1.Location = new System.Drawing.Point(129, 157);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(34, 11);
            this.b_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b_1.TabIndex = 22;
            this.b_1.TabStop = false;
            // 
            // en_2
            // 
            this.en_2.BackColor = System.Drawing.Color.Transparent;
            this.en_2.Image = ((System.Drawing.Image)(resources.GetObject("en_2.Image")));
            this.en_2.Location = new System.Drawing.Point(499, 220);
            this.en_2.Name = "en_2";
            this.en_2.Size = new System.Drawing.Size(34, 12);
            this.en_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en_2.TabIndex = 21;
            this.en_2.TabStop = false;
            // 
            // en_1
            // 
            this.en_1.BackColor = System.Drawing.Color.Transparent;
            this.en_1.Image = ((System.Drawing.Image)(resources.GetObject("en_1.Image")));
            this.en_1.Location = new System.Drawing.Point(499, 82);
            this.en_1.Name = "en_1";
            this.en_1.Size = new System.Drawing.Size(34, 12);
            this.en_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en_1.TabIndex = 20;
            this.en_1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::TanksAttack.Properties.Resources.wall;
            this.pictureBox9.Location = new System.Drawing.Point(322, 265);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(300, 20);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "block";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::TanksAttack.Properties.Resources.wall;
            this.pictureBox10.Location = new System.Drawing.Point(12, 265);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(287, 20);
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "block";
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = global::TanksAttack.Properties.Resources.enemy_tank;
            this.enemy2.Location = new System.Drawing.Point(539, 205);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(51, 44);
            this.enemy2.TabIndex = 16;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = global::TanksAttack.Properties.Resources.enemy_tank;
            this.enemy1.Location = new System.Drawing.Point(539, 67);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(51, 44);
            this.enemy1.TabIndex = 15;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Black;
            this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox12.Location = new System.Drawing.Point(0, 291);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(634, 20);
            this.pictureBox12.TabIndex = 14;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Black;
            this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox11.Location = new System.Drawing.Point(0, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(634, 20);
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::TanksAttack.Properties.Resources.wall;
            this.pictureBox8.Location = new System.Drawing.Point(322, 26);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(300, 20);
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "block";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TanksAttack.Properties.Resources.wall;
            this.pictureBox3.Location = new System.Drawing.Point(12, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(288, 20);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "block";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::TanksAttack.Properties.Resources.block;
            this.pictureBox7.Location = new System.Drawing.Point(275, 104);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "block";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::TanksAttack.Properties.Resources.block;
            this.pictureBox6.Location = new System.Drawing.Point(165, 199);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "block";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TanksAttack.Properties.Resources.block;
            this.pictureBox5.Location = new System.Drawing.Point(539, 135);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "block";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TanksAttack.Properties.Resources.block;
            this.pictureBox4.Location = new System.Drawing.Point(426, 199);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "block";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TanksAttack.Properties.Resources.block;
            this.pictureBox2.Location = new System.Drawing.Point(29, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "block";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TanksAttack.Properties.Resources.block;
            this.pictureBox1.Location = new System.Drawing.Point(426, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "block";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(72, 141);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(51, 44);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // over_lbl
            // 
            this.over_lbl.AutoSize = true;
            this.over_lbl.BackColor = System.Drawing.Color.Crimson;
            this.over_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.over_lbl.Font = new System.Drawing.Font("Lucida Handwriting", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over_lbl.Location = new System.Drawing.Point(0, 243);
            this.over_lbl.Name = "over_lbl";
            this.over_lbl.Size = new System.Drawing.Size(254, 48);
            this.over_lbl.TabIndex = 24;
            this.over_lbl.Text = "Game Over";
            // 
            // game_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::TanksAttack.Properties.Resources.background_img;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.over_lbl);
            this.Controls.Add(this.b_1);
            this.Controls.Add(this.en_2);
            this.Controls.Add(this.en_1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "game_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanks Attack";
            this.Load += new System.EventHandler(this.game_window_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_window_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_window_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.b_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox en_1;
        private System.Windows.Forms.PictureBox en_2;
        private System.Windows.Forms.PictureBox b_1;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label over_lbl;
    }
}

