//Interactive Postcard
//Adam Monteith
//September 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.White, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //Show Florida and Name
            Font drawFont = new Font("Arial", 40, FontStyle.Bold);
            g.DrawString("Florida", drawFont, drawBrush, Width / 2 - 100, Height / 2 - 50);
            g.DrawString("By Adam Monteith", drawFont, drawBrush, Width / 2 - 250, Height / 2 - 5);

            //Play Sound and Clear to White while Boop Plays
            Refresh();
            Thread.Sleep(1500);
            SoundPlayer player = new SoundPlayer(Properties.Resources.boop);
            player.Play();
            g.Clear(Color.White);

            //Show Have Fun in White
            Font drawFont2 = new Font("Microsoft Sans Serif", 40, FontStyle.Bold);
            g.DrawString("Have Fun!!!", drawFont2, drawBrush, Width / 2 - 100, Height / 2 - 50);

            //Display Letters One By One, while Beep is playing
            Thread.Sleep(500);
            SolidBrush drawBrush2 = new SolidBrush(Color.Yellow);
            g.DrawString("H", drawFont2, drawBrush2, Width / 2 - 220, Height / 2 - 50);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.beep);
            player2.Play();

            Thread.Sleep(1000);
            g.DrawString("A", drawFont2, drawBrush2, Width / 2 - 180, Height / 2 - 50);
            player2.Play();

            Thread.Sleep(1000);
            g.DrawString("V", drawFont2, drawBrush2, Width / 2 - 140, Height / 2 - 50);
            player2.Play();

            Thread.Sleep(1000);
            g.DrawString("E", drawFont2, drawBrush2, Width / 2 - 100, Height / 2 - 50);
            player2.Play();

            Thread.Sleep(1000);
            g.DrawString("F", drawFont2, drawBrush2, Width / 2 - 20, Height / 2 - 50);
            player2.Play();

            Thread.Sleep(1000);
            g.DrawString("U", drawFont2, drawBrush2, Width / 2 - -15, Height / 2 - 50);
            player2.Play();

            Thread.Sleep(1000);
            g.DrawString("N", drawFont2, drawBrush2, Width / 2 - -60, Height / 2 - 50);
            player2.Play();

            Thread.Sleep(1000);
            g.DrawString("!", drawFont2, drawBrush2, Width / 2 - -100, Height / 2 - 50);
            player2.Play();

            Thread.Sleep(1000);
            g.DrawString("!", drawFont2, drawBrush2, Width / 2 - -120, Height / 2 - 50);
            player2.Play();

            //Sun Appears
            Thread.Sleep(1000);
            g.FillEllipse(drawBrush2, this.Width / 2 - 430, this.Height / 2 - 300, 200, 200);
            Pen drawPen2 = new Pen(Color.Yellow, 10);






        }
    }
}
