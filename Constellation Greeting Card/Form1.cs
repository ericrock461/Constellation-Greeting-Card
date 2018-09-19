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
            //deletes everything on-screen after clicking program
            titleLabel.Visible = false;
            titleLabel.Refresh();
            this.BackgroundImage = null;
            clickLabel.Visible = false;
            clickLabel.Refresh();

            //sets up drawing tools needed for later
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Aquamarine, 4);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            g.Clear(Color.Black);

            //individually draw every 'star' and keep them on-screen
            //beginning with unrelated stars, which have less time between appearances   

            g.FillEllipse(drawBrush, 134, 143, 3, 3);
            Thread.Sleep(1000);
            g.FillEllipse(drawBrush, 367, 84, 3, 3);
            Thread.Sleep(900);
            g.FillEllipse(drawBrush, 256, 231, 3, 3);
            Thread.Sleep(800);
            g.FillEllipse(drawBrush, 140, 313, 3, 3);
            Thread.Sleep(600);
            g.FillEllipse(drawBrush, 427, 354, 3, 3);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 118, 262, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 118, 262, 3, 3);
            Thread.Sleep(100);
            g.FillEllipse(drawBrush, 118, 262, 3, 3);
            Thread.Sleep(100);
            //remember to add 40 degrees to all future little stars


            //now the constellation stars, which have more time between appearances
            g.FillEllipse(drawBrush, 78, 222, 8, 8);
            Thread.Sleep(1000);       
            g.FillEllipse(drawBrush, 154, 185, 8, 8);
            Thread.Sleep(1000);          
            g.FillEllipse(drawBrush, 212, 191, 8, 8);
            Thread.Sleep(1000);          
            g.FillEllipse(drawBrush, 284, 194, 6, 6);
            Thread.Sleep(1000);
            g.FillEllipse(drawBrush, 321, 242, 8, 8);
            Thread.Sleep(1000);
            g.FillEllipse(drawBrush, 418, 205, 8, 8);
            Thread.Sleep(1000);
            g.FillEllipse(drawBrush, 401, 135, 8, 8);
            Thread.Sleep(1000);                               

            //make lines between the stars to draw the constellation/asterism
            g.DrawLine(drawPen, 82, 226, 158, 189);
            Thread.Sleep(700);
            //ADD SOUNDS
            g.DrawLine(drawPen, 158, 189, 216, 195);
            Thread.Sleep(700);
            g.DrawLine(drawPen, 216, 195, 288, 198);
            Thread.Sleep(700);
            g.DrawLine(drawPen, 288, 198, 325, 246);
            Thread.Sleep(700);
            g.DrawLine(drawPen, 325, 246, 422, 209);
            Thread.Sleep(700);
            g.DrawLine(drawPen, 422, 209, 405, 139);
            Thread.Sleep(700);
            g.DrawLine(drawPen, 405, 139, 288, 198);
            Thread.Sleep(700);

            g.DrawString("The Big Dipp...er is blah blah blah", drawFont, drawBrush, 50, 40);
            //stay on here, don't go away and do weird stuff pls.
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
