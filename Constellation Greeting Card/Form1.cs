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
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            g.Clear(Color.Black);

            //individually draw every 'star' and keep them on-screen
            g.FillEllipse(drawBrush, 120, 125, 8, 8);
            Thread.Sleep(1000);       
            g.FillEllipse(drawBrush, 150, 135, 8, 8);
            Thread.Sleep(1000);          
            g.FillEllipse(drawBrush, 180, 140, 8, 8);
            Thread.Sleep(1000);          
            g.FillEllipse(drawBrush, 210, 145, 8, 8);
            Thread.Sleep(1000);
            g.FillEllipse(drawBrush, 260, 150, 8, 8);
            Thread.Sleep(1000);
            g.FillEllipse(drawBrush, 210, 210, 8, 8);
            Thread.Sleep(1000);           
            g.FillEllipse(drawBrush, 250, 230, 8, 8);
            Thread.Sleep(1000);
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
