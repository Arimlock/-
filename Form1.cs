using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шаг_первый
{
    public partial class Form1 : Form
    {
        //this.Controls.Add(this.SetSizePan);
        //this.Controls.Add(this.MainMenuPan);
        //this.Controls.Add(this.GamePan);
        int defoultWidth;
        bool goUp = false;
        bool goDown = false;
        bool goAway = false;
        int fullStep = 10;
        Point HeroLoc = new  Point(0, 1);
        /// <summary>
        /// Field1_2.X=Field1.Location.X  Field1_2.Y=Field2.Location.X
        /// </summary>
        Point Field1_2 = new Point(0, 6);
        public Form1()
        {
            InitializeComponent();
            defoultWidth = Width;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.W)
                goUp = true;
            if (e.KeyValue == (char)Keys.S)
                goDown = true;
            if (e.KeyValue == (char)Keys.Escape)
                goAway = true;
        }

        private void SetSizeBut_Click(object sender, EventArgs e)
        {
            double scale = Convert.ToDouble(Width) / Convert.ToDouble(defoultWidth);
            SetSizePan.Parent=null;
            MaximizeBox = false;
            MaximumSize = Size;
            MinimumSize = Size;
            Controls.Add(MainMenuPan);
            {/*
            StartGameBut.Location (75, 85);
            StartGameBut.Size(350, 80);
            GoSetSizeBut.Location(75, 170);
            GoSetSizeBut.Size(350, 40);
            */
            }//комментарии
            StartGameBut.Location = new Point(Convert.ToInt32(75 * scale),
                Convert.ToInt32(85 * scale));
            StartGameBut.Size = new Size(Convert.ToInt32(350 * scale),
                Convert.ToInt32(80 * scale));

            GoSetSizeBut.Location = new Point(Convert.ToInt32(75 * scale),
                Convert.ToInt32(170 * scale));
            GoSetSizeBut.Size = new Size(Convert.ToInt32(350 * scale),
                Convert.ToInt32(40 * scale));
        }

        private void GoSetSizeBut_Click(object sender, EventArgs e)
        {
            MainMenuPan.Parent = null;
            Form1.ActiveForm.MaximumSize = new Size(5000,5000);
            Form1.ActiveForm.MinimumSize = new Size(1,1);
            Controls.Add(SetSizePan);
        }

        private void StartGameBut_Click(object sender, EventArgs e)
        {
            MainMenuPan.Parent = null;
            Controls.Add(GamePan);
            {/*
            HeroPic.Location(0, 133);
            HeroPic.Size(83, 83);
                
            StatPan.Location(0, 0);
            StatPan.Size(500, 50);
                
            Field1Pan.Location(0, 50);
            Field1Pan.Size(500, 250);
                
            Field2Pan.Location(500, 50);
            Field2Pan.Size(500, 250);
            */
            }//комментарии
            double scale = Convert.ToDouble(Width) / Convert.ToDouble(defoultWidth);
            HeroPic.Location = new Point(0, Convert.ToInt32(133 * scale));
            HeroPic.Size = new Size(Convert.ToInt32(83 * scale),
                Convert.ToInt32(83 * scale));

            StatPan.Location = new Point(0,0);
            StatPan.Size = new Size(Convert.ToInt32(500 * scale),
                Convert.ToInt32(50 * scale));

            Field1Pan.Location = new Point(0, Convert.ToInt32(50 * scale));
            Field1Pan.Size = new Size(Convert.ToInt32(500 * scale),
                Convert.ToInt32(250 * scale));

            Field2Pan.Location = new Point(Field1Pan.Width, Convert.ToInt32(50 * scale));
            Field2Pan.Size = new Size(Convert.ToInt32(500 * scale),
                Convert.ToInt32(250 * scale));
            Game( Field1Pan, Field2Pan, HeroPic);
            RunningTim.Enabled = true;
        }
        private void Game( Control field1, Control field2, Control hero)
        {

        }
        private void MoveHero(bool goUp)
        {
            if (goUp)
            {
                HeroPic.Location = new Point(0,HeroPic.Location.Y-HeroPic.Height);
            }
            else
            {
                HeroPic.Location = new Point(0,HeroPic.Location.Y+HeroPic.Height);
            }
        }
        private void ExitGame()
        {
            RunningTim.Enabled = false;
            if (MainMenuPan.Parent != null)
            {
                Form1.ActiveForm.Dispose();
            }
            if (MainMenuPan.Parent == null)
            {
                GamePan.Parent = null;
                Controls.Add(MainMenuPan);
            }
        }

        private void RunningTim_Tick(object sender, EventArgs e)
        {
            if (goUp)
            {
                MoveHero(true);
                goUp = false;
            }
            if (goDown)
            {
                MoveHero(false);
                goDown = false;
            }
            if (goAway)
            {
                ExitGame();
                goAway = false;
            }
            fullStep += 2;
            Field1Pan.Location = new Point(Field1Pan.Location.X - Convert.ToInt32(0.2 * Field1Pan.Width), Field1Pan.Location.Y);
            Field2Pan.Location = new Point(Field2Pan.Location.X - Convert.ToInt32(0.2 * Field1Pan.Width), Field1Pan.Location.Y);
            if (Field1Pan.Location.X <= -Field1Pan.Width)
                Field1Pan.Location = new Point(Field2Pan.Location.X+Field2Pan.Width,Field1Pan.Location.Y);
            if (Field2Pan.Location.X <= -Field2Pan.Width)
                Field2Pan.Location = new Point(Field1Pan.Location.X + Field1Pan.Width, Field2Pan.Location.Y);
        }
    }
}
