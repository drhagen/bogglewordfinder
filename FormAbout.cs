using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Boggle2
{
    public partial class FormAbout : Form
    {
		private int CenterIcoX;
		private int CenterIcoY;
		private int LongOutIco;
		private int LongInIco;
		private int ShortOutIco;
		private int ShortInIco;

		private Point[] StarRed;
		private Point[] StarBlue;

        public FormAbout()
        {
            InitializeComponent();

			//Draw the Star logo
			CenterIcoX = 50;
			CenterIcoY = 50;
			LongOutIco = 40;
			LongInIco = 5;
			ShortOutIco = 20;
			ShortInIco = 5;

			StarRed = new Point[8] 
				{
		            new Point(CenterIcoX, CenterIcoY - LongOutIco),
					new Point(CenterIcoX + LongInIco, CenterIcoY - LongInIco),
		            new Point(CenterIcoX + LongOutIco, CenterIcoY),
					new Point(CenterIcoX + LongInIco, CenterIcoY + LongInIco),
		            new Point(CenterIcoX, CenterIcoY + LongOutIco),
					new Point(CenterIcoX - LongInIco, CenterIcoY + LongInIco),
		            new Point(CenterIcoX - LongOutIco, CenterIcoY),
					new Point(CenterIcoX - LongInIco, CenterIcoY - LongInIco),
		        };
			StarBlue = new Point[8]
				{
					new Point(CenterIcoX, CenterIcoY - ShortInIco),
					new Point(CenterIcoX + ShortOutIco, CenterIcoY - ShortOutIco),
					new Point(CenterIcoX + ShortInIco, CenterIcoY),
					new Point(CenterIcoX + ShortOutIco, CenterIcoY + ShortOutIco),
					new Point(CenterIcoX, CenterIcoY + ShortInIco),
					new Point(CenterIcoX - ShortOutIco, CenterIcoY + ShortOutIco),
					new Point(CenterIcoX - ShortInIco, CenterIcoY),
					new Point(CenterIcoX - ShortOutIco, CenterIcoY - ShortOutIco),
				};
        }

        private void FormAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        
        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormAbout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }

		public void CenterToForm1(Point corner)
		{
			Point newloc = new Point(corner.X + 50, corner.Y + 50);
			this.Location = newloc;
		}

		private void FormAbout_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillPolygon(Brushes.Blue, StarBlue);
			g.FillPolygon(Brushes.Red, StarRed);
		}

    }
}