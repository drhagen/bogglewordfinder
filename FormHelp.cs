using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Boggle2
{
	/// <summary>
	/// Summary description for HelpForm.
	/// </summary>
	public class FormHelp : System.Windows.Forms.Form
	{
		private Label TitleLbl;
		private Label Gen1Lbl;
		private Label Use1Lbl;
		private Label Use2Lbl;
		private Label Use3Lbl;
		private Label Gen0Lbl;
		private Label Use0Lbl;
		private Label Dict0Lbl;
		private Label Dict1Lbl;
        private Label Works0Lbl;
        private Label Works1Lbl;
		private Button OkBtn;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormHelp()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
			this.OkBtn = new System.Windows.Forms.Button();
			this.TitleLbl = new System.Windows.Forms.Label();
			this.Gen1Lbl = new System.Windows.Forms.Label();
			this.Use1Lbl = new System.Windows.Forms.Label();
			this.Use2Lbl = new System.Windows.Forms.Label();
			this.Use3Lbl = new System.Windows.Forms.Label();
			this.Gen0Lbl = new System.Windows.Forms.Label();
			this.Use0Lbl = new System.Windows.Forms.Label();
			this.Dict0Lbl = new System.Windows.Forms.Label();
			this.Dict1Lbl = new System.Windows.Forms.Label();
			this.Works0Lbl = new System.Windows.Forms.Label();
			this.Works1Lbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OkBtn
			// 
			this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.OkBtn.Location = new System.Drawing.Point(112, 392);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(72, 24);
			this.OkBtn.TabIndex = 0;
			this.OkBtn.Text = "OK";
			this.OkBtn.Click += new System.EventHandler(this.OKbtn_Click);
			// 
			// TitleLbl
			// 
			this.TitleLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLbl.ForeColor = System.Drawing.Color.Red;
			this.TitleLbl.Location = new System.Drawing.Point(125, 9);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(50, 20);
			this.TitleLbl.TabIndex = 1;
			this.TitleLbl.Text = "Help";
			this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Gen1Lbl
			// 
			this.Gen1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Gen1Lbl.Location = new System.Drawing.Point(12, 60);
			this.Gen1Lbl.Name = "Gen1Lbl";
			this.Gen1Lbl.Size = new System.Drawing.Size(270, 56);
			this.Gen1Lbl.TabIndex = 2;
			this.Gen1Lbl.Text = "This program uses a dictionary to find all the words in a square of letters accor" +
				"ding to the popular word game Boggle. If you know how to play the game, this pro" +
				"gram should be self-evident.";
			// 
			// Use1Lbl
			// 
			this.Use1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Use1Lbl.Location = new System.Drawing.Point(12, 136);
			this.Use1Lbl.Name = "Use1Lbl";
			this.Use1Lbl.Size = new System.Drawing.Size(270, 30);
			this.Use1Lbl.TabIndex = 3;
			this.Use1Lbl.Text = "1. Type in each letter of the square you want to solve, or press \"Randomize\" to c" +
				"reate a new square.";
			// 
			// Use2Lbl
			// 
			this.Use2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Use2Lbl.Location = new System.Drawing.Point(12, 166);
			this.Use2Lbl.Name = "Use2Lbl";
			this.Use2Lbl.Size = new System.Drawing.Size(270, 30);
			this.Use2Lbl.TabIndex = 4;
			this.Use2Lbl.Text = "2. Type integers into the \"Min\" and \"Max\" text boxes to set the range for the len" +
				"gths of the words displayed.";
			// 
			// Use3Lbl
			// 
			this.Use3Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Use3Lbl.Location = new System.Drawing.Point(12, 196);
			this.Use3Lbl.Name = "Use3Lbl";
			this.Use3Lbl.Size = new System.Drawing.Size(270, 28);
			this.Use3Lbl.TabIndex = 5;
			this.Use3Lbl.Text = "3. Click \"Display All\" to display all the words found in the square.";
			// 
			// Gen0Lbl
			// 
			this.Gen0Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Gen0Lbl.ForeColor = System.Drawing.Color.Red;
			this.Gen0Lbl.Location = new System.Drawing.Point(12, 40);
			this.Gen0Lbl.Name = "Gen0Lbl";
			this.Gen0Lbl.Size = new System.Drawing.Size(84, 20);
			this.Gen0Lbl.TabIndex = 6;
			this.Gen0Lbl.Text = "General:";
			this.Gen0Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Use0Lbl
			// 
			this.Use0Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Use0Lbl.ForeColor = System.Drawing.Color.Red;
			this.Use0Lbl.Location = new System.Drawing.Point(12, 116);
			this.Use0Lbl.Name = "Use0Lbl";
			this.Use0Lbl.Size = new System.Drawing.Size(84, 20);
			this.Use0Lbl.TabIndex = 7;
			this.Use0Lbl.Text = "How to Use:";
			this.Use0Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Dict0Lbl
			// 
			this.Dict0Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Dict0Lbl.ForeColor = System.Drawing.Color.Red;
			this.Dict0Lbl.Location = new System.Drawing.Point(12, 310);
			this.Dict0Lbl.Name = "Dict0Lbl";
			this.Dict0Lbl.Size = new System.Drawing.Size(84, 20);
			this.Dict0Lbl.TabIndex = 8;
			this.Dict0Lbl.Text = "Dictionary:";
			this.Dict0Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Dict1Lbl
			// 
			this.Dict1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Dict1Lbl.Location = new System.Drawing.Point(12, 330);
			this.Dict1Lbl.Name = "Dict1Lbl";
			this.Dict1Lbl.Size = new System.Drawing.Size(270, 54);
			this.Dict1Lbl.TabIndex = 9;
			this.Dict1Lbl.Text = "You can use your own text dictionary by naming it \"dictionary.txt\" and placing it" +
				" in the same directory as the executable. Each word must be follwed by a return " +
				"character in order to be read properly.";
			// 
			// Works0Lbl
			// 
			this.Works0Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Works0Lbl.ForeColor = System.Drawing.Color.Red;
			this.Works0Lbl.Location = new System.Drawing.Point(12, 224);
			this.Works0Lbl.Name = "Works0Lbl";
			this.Works0Lbl.Size = new System.Drawing.Size(84, 20);
			this.Works0Lbl.TabIndex = 10;
			this.Works0Lbl.Text = "How it Works:";
			this.Works0Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Works1Lbl
			// 
			this.Works1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Works1Lbl.Location = new System.Drawing.Point(12, 244);
			this.Works1Lbl.Name = "Works1Lbl";
			this.Works1Lbl.Size = new System.Drawing.Size(270, 66);
			this.Works1Lbl.TabIndex = 11;
			this.Works1Lbl.Text = resources.GetString("Works1Lbl.Text");
			// 
			// FormHelp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(294, 425);
			this.Controls.Add(this.Works1Lbl);
			this.Controls.Add(this.Works0Lbl);
			this.Controls.Add(this.Dict1Lbl);
			this.Controls.Add(this.Dict0Lbl);
			this.Controls.Add(this.Use0Lbl);
			this.Controls.Add(this.Gen0Lbl);
			this.Controls.Add(this.Use3Lbl);
			this.Controls.Add(this.Use2Lbl);
			this.Controls.Add(this.Use1Lbl);
			this.Controls.Add(this.Gen1Lbl);
			this.Controls.Add(this.TitleLbl);
			this.Controls.Add(this.OkBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormHelp";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Help";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHelp_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHelp_KeyDown);
			this.ResumeLayout(false);

		}
		#endregion

		public void CenterToForm1(Point corner)
		{
			Point newloc = new Point(corner.X + 50, corner.Y + 50);
			this.Location = newloc;
		}

        private void FormHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormHelp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }

	}
}
