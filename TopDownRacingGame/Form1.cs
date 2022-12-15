using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Gaming.Input;
using System.Runtime;
using System.Diagnostics;
using SharpDX.XInput;


namespace TopDownRacingGame
{
    public partial class Form1 : Form
    {
        
        int roadspeed;
        int trafficspeed;
        int playerspeed = 12;
        int score;
        int carimage;


        Random rand= new Random();
        Random carposition = new Random();

        bool goleft, goright, goup, godown;

        public Form1()
        {
            InitializeComponent();
            
            resetgame();
            
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright= true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                if (roadspeed < 100)
                {
                    roadspeed++;
                    trafficspeed = roadspeed + 2;
                }

            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                if (roadspeed > 1)
                {
                    roadspeed --;
                    trafficspeed = roadspeed + 2;
                }
            }


        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
                
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
                
            }



        }



        private void gametimerevent(object sender, EventArgs e)
        {


            txtscore.Text = "Score: " + score;
            score++;

            speed.Text = "Speed: " + roadspeed;

            if (goleft == true && player.Left > 10)
            {
                player.Left -= playerspeed;
            }
            if (goright == true && player.Left < 415)
            {
                player.Left += playerspeed;
            }
            


            RoadTrack1.Top += roadspeed;
            RoadTrack2.Top += roadspeed;

            if (RoadTrack2.Top > 475)
            {
                RoadTrack2.Top = -475;
            }
            if (RoadTrack1.Top > 475)
            {
                RoadTrack1.Top = -475;
            }

            ai1.Top += trafficspeed;
            ai2.Top += trafficspeed;

            if (ai1.Top > 486)
            {
                changeaicars(ai1);
            }
            if (ai2.Top > 486)
            {
                changeaicars(ai2);
            }
            if (player.Bounds.IntersectsWith(ai1.Bounds) || player.Bounds.IntersectsWith(ai2.Bounds))
            {
                gameover();
            }
            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }
            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.silver;
               
                
            }
            if (score > 2000)
            {
                award.Image = Properties.Resources.gold;

            }

        }

        private void changeaicars(PictureBox tempcar)
        {
            carimage = rand.Next(1, 9);

            switch (carimage)
            {
                case 1:
                    tempcar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempcar.Image = Properties.Resources.carPink;
                    break;
                case 3:
                    tempcar.Image= Properties.Resources.carGrey;
                    break;
                case 4:
                    tempcar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempcar.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    tempcar.Image = Properties.Resources.carYellow;
                    break;
                case 7:
                    tempcar.Image = Properties.Resources.carGreen;
                    break;
                case 8:
                    tempcar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempcar.Image = Properties.Resources.TruckWhite;
                    break;
            }

            tempcar.Top = carposition.Next(100, 400) * -1;

            if ((string) tempcar.Tag == "carleft")
            {
                tempcar.Left = carposition.Next(5, 200);
            }
            if ((string) tempcar.Tag == "carright")
            {
                tempcar.Left = carposition.Next(245, 422);
            }



        }
        private void gameover()
        {
            playsound();
            gametimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, -5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnstart.Enabled = true;
        }
        private void resetgame()
        {
            btnstart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadspeed = 12;
            trafficspeed = 15;

            ai1.Top = carposition.Next(200,500) * -1;
            ai1.Left = carposition.Next(5, 200);

            ai2.Top = carposition.Next(200, 500) * -1;
            ai2.Left = carposition.Next(245, 422);

            gametimer.Start();

        }

        private void RoadTrack2_Click(object sender, EventArgs e)
        {

        }

        private void restartgame(object sender, EventArgs e)
        {
            resetgame();
        }

        private void keyisupordown(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtscore_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void playsound()
        {
            System.Media.SoundPlayer playcrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playcrash.Play();
        }
    }
}
