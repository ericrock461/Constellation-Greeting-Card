using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

/* 
 Erich Rock
 September 17 2018
 Program for an interactive greeting card 
 */

namespace Constellation_Greeting_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //sets up drawing tools needed for later
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Aquamarine, 4);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Arial", 9, FontStyle.Bold);

            //deletes everything on-screen after clicking program
            titleLabel.Visible = false;
            titleLabel.Refresh();
            this.BackgroundImage = null;
            clickLabel.Visible = false;
            clickLabel.Refresh();

            //clears screen to black
            g.Clear(Color.Black);
            Thread.Sleep(1000);

            //individually draw every 'star' and keep them on-screen
            //beginning with unrelated stars, which have less time between appearances   
            g.FillEllipse(drawBrush, 134, 143, 3, 3);
            Thread.Sleep(1000);
            g.FillEllipse(drawBrush, 379, 84, 3, 3);
            Thread.Sleep(900);
            g.FillEllipse(drawBrush, 256, 231, 3, 3);
            Thread.Sleep(900);
            g.FillEllipse(drawBrush, 140, 313, 3, 3);
            Thread.Sleep(700);
            g.FillEllipse(drawBrush, 427, 354, 3, 3);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 118, 262, 3, 3);
            Thread.Sleep(400);
            g.FillEllipse(drawBrush, 83, 422, 3, 3);
            Thread.Sleep(250);
            g.FillEllipse(drawBrush, 158, 302, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 454, 162, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 235, 170, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 435, 286, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 171, 345, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 57, 182, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 410, 335, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 73, 176, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 51, 291, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 235, 170, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 166, 84, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 443, 265, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 297, 148, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 428, 83, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 226, 245, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 68, 125, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 256, 331, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 247, 372, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 331, 308, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 360, 346, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 293, 137, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 244, 102, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 144, 205, 3, 3);         
            Thread.Sleep(1000);
            //the last small star has a longer delay
           
            //now the constellation stars, which have more time between appearances
            g.FillEllipse(drawBrush, 78, 222, 8, 8);
            SoundPlayer player = new SoundPlayer(Properties.Resources.bellDing);
            player.Play();
            Thread.Sleep(1000);

            g.FillEllipse(drawBrush, 154, 185, 8, 8);
            player = new SoundPlayer(Properties.Resources.bellDing);
            player.Play();
            Thread.Sleep(1000);

            g.FillEllipse(drawBrush, 212, 191, 8, 8);
            player = new SoundPlayer(Properties.Resources.bellDing);
            player.Play();
            Thread.Sleep(1000);

            g.FillEllipse(drawBrush, 284, 194, 6, 6);
            player = new SoundPlayer(Properties.Resources.quickDing);
            player.Play();
            Thread.Sleep(1000);

            g.FillEllipse(drawBrush, 321, 242, 8, 8);
            player = new SoundPlayer(Properties.Resources.potDing);
            player.Play();
            Thread.Sleep(1000);

            g.FillEllipse(drawBrush, 418, 205, 8, 8);
            player = new SoundPlayer(Properties.Resources.potDing);
            player.Play();
            Thread.Sleep(1000);

            g.FillEllipse(drawBrush, 401, 135, 8, 8);
            player = new SoundPlayer(Properties.Resources.potDing);
            player.Play();
            Thread.Sleep(1000);                               

            //make lines between the stars to draw the constellation/asterism
            g.DrawLine(drawPen, 82, 226, 158, 189);
            player = new SoundPlayer(Properties.Resources.shotLaser);
            player.Play();
            Thread.Sleep(700);

            g.DrawLine(drawPen, 158, 189, 216, 195);
            player = new SoundPlayer(Properties.Resources.shotLaser);
            player.Play();
            Thread.Sleep(700);

            g.DrawLine(drawPen, 216, 195, 288, 198);
            player = new SoundPlayer(Properties.Resources.shotLaser);
            player.Play();
            Thread.Sleep(700);

            g.DrawLine(drawPen, 288, 198, 325, 246);
            player = new SoundPlayer(Properties.Resources.shotLaser);
            player.Play();
            Thread.Sleep(700);

            g.DrawLine(drawPen, 325, 246, 422, 209);
            player = new SoundPlayer(Properties.Resources.shotLaser);
            player.Play();
            Thread.Sleep(700);

            g.DrawLine(drawPen, 422, 209, 405, 139);
            player = new SoundPlayer(Properties.Resources.shotLaser);
            player.Play();
            Thread.Sleep(1600);
            //pause for effect...

            //the last line drawn has a comedic sound
            g.DrawLine(drawPen, 405, 139, 288, 198);
            player = new SoundPlayer(Properties.Resources.weakLaser);
            player.Play();
            Thread.Sleep(700);

            //add a paragraph of text once constellation is drawn (with a sound to accompany)
            player = new SoundPlayer(Properties.Resources.warpSound);
            player.Play();
            g.DrawString("The Big Dipper, or the Plough is a large asterism consisting of seven bright stars" +
                "\nof the constellation Ursa Major; six of them are of second magnitude and one," +
                "\nMegrez (δ), of third magnitude (Megrez is the star in the middle). " +
                "\nIt's name comes from it's interesting shape. " +
                "\nIt is recognized as a distinct grouping in many cultures.", drawFont, drawBrush, 50, 20);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
