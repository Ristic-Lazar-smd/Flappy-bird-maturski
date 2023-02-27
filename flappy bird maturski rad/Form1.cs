using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird_maturski_rad
{
    public partial class Form1 : Form
    {      
        Form2 f2 = new Form2();       
        int ceviSpeed = 2;
        int a = 5;
        int gravitacija = 2;
        int score = 0;
        public static int fscore = 0; //final score
        int yptice = 0;
        int visina = 0;
        int razmak = 475;
        Random broj = new Random();

        public Form1()
        {
            InitializeComponent();
        }
    
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            yptice += gravitacija;
            flappyBird.Top +=yptice;          
            scoreText.Text = "" + score;
            scoreText.Visible = true;
            int x = 0;
            int y = 0;
            int y1 = 0;

            if (score == a) //povecavamo brzinu na svakih 5
            {
                ceviSpeed++;
                a += 5;
            }

            if (cevdole.Left < -80)
            {
                x = cevdole2.Location.X + 220;

                visina = broj.Next(180, 475);
                y = visina;

                cevdole.Location = new Point(x, y);
                score += 1;

                y1 = y - razmak;
                cevgore.Location = new Point(x, y1);
            }

            else if (cevdole2.Left < -80)
            {
                x = cevdole.Location.X + 220;

                visina = broj.Next(180, 475);
                y = visina;

                cevdole2.Location = new Point(x, y);
                score += 1;

                y1 = y - razmak;
                cevgore2.Location = new Point(x, y1);
            }

            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                fscore = score;
                scoreText.Text = "0";
                score = 0;
                endGame();
                
            }
            else if (flappyBird.Bounds.IntersectsWith(cevdole.Bounds))
            {
                fscore = score;
                scoreText.Text = "0";
                score = 0;
                endGame();               
            }
            else if (flappyBird.Bounds.IntersectsWith(cevgore.Bounds))
            {
                fscore = score;
                scoreText.Text = "0";
                score = 0;
                endGame();               
            }
            else if (flappyBird.Bounds.IntersectsWith(cevgore2.Bounds))
            {
                fscore = score;
                scoreText.Text = "0";
                score = 0;
                endGame();               
            }
            else if (flappyBird.Bounds.IntersectsWith(cevdole2.Bounds))
            {
                fscore = score;
                scoreText.Text = "0";
                score = 0;
                endGame();  
            }          
            else if (flappyBird.Bounds.IntersectsWith(nebo.Bounds))
            {
                fscore = score;
                scoreText.Text = "0";
                score = 0;
                endGame();              
            }
        }

        private void skok(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yptice = -15;
                flappyBird.Top += yptice;
                gameTimer.Start();
                Cevi.Start();
                label1.Visible = false;
            }
            else if (e.KeyCode == Keys.R)
            {
                Application.Restart();
            }
        }

        private void endGame()
        {            
            gameTimer.Stop();
            Cevi.Stop();
            f2.ShowDialog();
            Close();            
        }
     
        private void Cevi_Tick(object sender, EventArgs e)
        {
            cevdole.Left -= ceviSpeed;
            cevgore.Left -= ceviSpeed;
            cevgore2.Left -= ceviSpeed;
            cevdole2.Left -= ceviSpeed;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int z = broj.Next(180, 475);
            cevdole.Top = z;
            cevgore.Top = z - razmak;

            int z1 = broj.Next(180, 475);
            cevdole2.Top = z1;
            cevgore2.Top = z1 - razmak;       
        }
    }
}
