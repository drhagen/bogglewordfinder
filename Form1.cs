using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Boggle2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private IContainer components;

		private FormHelp FormHelp1;
		private FormAbout FormAbout1;

		private MainMenu MainMenu;
		private MenuItem Menu10Item;
		private MenuItem Menu11Item;
		private MenuItem MenuBar1;
		private MenuItem Menu12Item;
		private MenuItem Menu20Item;
		private MenuItem Menu21Item;
		private MenuItem MenuBar2;
		private MenuItem Menu22Item;

		private TextBox AnswerBox;
		private Label BogLbl;
		private TextBox Loc00Box;
		private TextBox Loc01Box;
		private TextBox Loc02Box;
		private TextBox Loc03Box;
		private TextBox Loc10Box;
		private TextBox Loc11Box;
		private TextBox Loc12Box;
		private TextBox Loc13Box;
		private TextBox Loc20Box;
		private TextBox Loc21Box;
		private TextBox Loc22Box;
		private TextBox Loc23Box;
		private TextBox Loc30Box;
		private TextBox Loc31Box;
		private TextBox Loc32Box;
		private TextBox Loc33Box;
		private Button RandBtn;
		private Button DispAllBtn;

		private GroupBox LengthGrp;
		private TextBox MinBox;
		private TextBox MaxBox;
		private Label MinLbl;
		private Label MaxLbl;

		private string[] Dictionary;
		private char[,] Block;
		private TextBox[,] BoggleSquare;
		private int Min;
		private int Max;
		private ArrayList Answers;
		private char[,] Dice;
		private Random rdm;

		private bool MaxMinAllowEntry;
		private Point TextBoxCornerPoint;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			FormHelp1 = new FormHelp();
			FormAbout1 = new FormAbout();

			BoggleSquare = new TextBox[,] 
			{
				{Loc00Box, Loc10Box, Loc20Box, Loc30Box}, 
				{Loc01Box, Loc11Box, Loc21Box, Loc31Box}, 
				{Loc02Box, Loc12Box, Loc22Box, Loc32Box}, 
				{Loc03Box, Loc13Box, Loc23Box, Loc33Box}
			};
			Dice = new char[16,6]
			{
				{'R', 'L', 'T', 'Y', 'E', 'T'},
				{'D', 'E', 'R', 'X', 'L', 'I'},
				{'F', 'A', 'K', 'P', 'S', 'F'},
				{'Q', 'I', 'M', 'N', 'H', 'U'},
				{'T', 'T', 'A', 'O', 'O', 'W'},
				{'D', 'I', 'Y', 'S', 'T', 'T'},
				{'B', 'O', 'B', 'A', 'J', 'O'},
				{'N', 'E', 'I', 'S', 'E', 'U'},
				{'L', 'V', 'E', 'R', 'D', 'Y'},
				{'P', 'C', 'H', 'O', 'A', 'S'},
				{'W', 'H', 'E', 'V', 'T', 'R'},
				{'E', 'A', 'G', 'A', 'N', 'E'},
				{'E', 'S', 'T', 'I', 'S', 'O'},
				{'T', 'C', 'I', 'U', 'O', 'M'},
				{'R', 'N', 'Z', 'N', 'L', 'H'},
				{'N', 'E', 'E', 'H', 'W', 'G'}
			};
			rdm = new Random();
			LoadDictionary();
			Answers = new ArrayList();
			TextBoxCornerPoint = new Point(AnswerBox.Width - 5, AnswerBox.Height - 20);
			
			foreach(TextBox s in BoggleSquare)
			{
				s.KeyPress += new KeyPressEventHandler(s_KeyPress);
				s.Enter +=new EventHandler(s_Enter);
				s.Click +=new EventHandler(s_Click);
            }
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.AnswerBox = new System.Windows.Forms.TextBox();
			this.BogLbl = new System.Windows.Forms.Label();
			this.RandBtn = new System.Windows.Forms.Button();
			this.Loc13Box = new System.Windows.Forms.TextBox();
			this.Loc12Box = new System.Windows.Forms.TextBox();
			this.Loc11Box = new System.Windows.Forms.TextBox();
			this.Loc10Box = new System.Windows.Forms.TextBox();
			this.Loc23Box = new System.Windows.Forms.TextBox();
			this.Loc22Box = new System.Windows.Forms.TextBox();
			this.Loc21Box = new System.Windows.Forms.TextBox();
			this.Loc20Box = new System.Windows.Forms.TextBox();
			this.Loc33Box = new System.Windows.Forms.TextBox();
			this.Loc32Box = new System.Windows.Forms.TextBox();
			this.Loc31Box = new System.Windows.Forms.TextBox();
			this.Loc30Box = new System.Windows.Forms.TextBox();
			this.Loc03Box = new System.Windows.Forms.TextBox();
			this.Loc02Box = new System.Windows.Forms.TextBox();
			this.Loc01Box = new System.Windows.Forms.TextBox();
			this.Loc00Box = new System.Windows.Forms.TextBox();
			this.DispAllBtn = new System.Windows.Forms.Button();
			this.MinBox = new System.Windows.Forms.TextBox();
			this.MaxBox = new System.Windows.Forms.TextBox();
			this.MinLbl = new System.Windows.Forms.Label();
			this.MaxLbl = new System.Windows.Forms.Label();
			this.LengthGrp = new System.Windows.Forms.GroupBox();
			this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
			this.Menu10Item = new System.Windows.Forms.MenuItem();
			this.Menu11Item = new System.Windows.Forms.MenuItem();
			this.MenuBar1 = new System.Windows.Forms.MenuItem();
			this.Menu12Item = new System.Windows.Forms.MenuItem();
			this.Menu20Item = new System.Windows.Forms.MenuItem();
			this.Menu21Item = new System.Windows.Forms.MenuItem();
			this.MenuBar2 = new System.Windows.Forms.MenuItem();
			this.Menu22Item = new System.Windows.Forms.MenuItem();
			this.LengthGrp.SuspendLayout();
			this.SuspendLayout();
			// 
			// AnswerBox
			// 
			this.AnswerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.AnswerBox.Location = new System.Drawing.Point(240, 8);
			this.AnswerBox.Multiline = true;
			this.AnswerBox.Name = "AnswerBox";
			this.AnswerBox.Size = new System.Drawing.Size(280, 400);
			this.AnswerBox.TabIndex = 21;
			// 
			// BogLbl
			// 
			this.BogLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.BogLbl.Location = new System.Drawing.Point(44, 25);
			this.BogLbl.Name = "BogLbl";
			this.BogLbl.Size = new System.Drawing.Size(113, 21);
			this.BogLbl.TabIndex = 57;
			this.BogLbl.Text = "Boggle Square";
			this.BogLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RandBtn
			// 
			this.RandBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.RandBtn.Location = new System.Drawing.Point(60, 160);
			this.RandBtn.Name = "RandBtn";
			this.RandBtn.Size = new System.Drawing.Size(87, 24);
			this.RandBtn.TabIndex = 17;
			this.RandBtn.Text = "Randomize";
			this.RandBtn.Click += new System.EventHandler(this.RandBtn_Click);
			// 
			// Loc13Box
			// 
			this.Loc13Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc13Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc13Box.Location = new System.Drawing.Point(140, 76);
			this.Loc13Box.MaxLength = 1;
			this.Loc13Box.Name = "Loc13Box";
			this.Loc13Box.Size = new System.Drawing.Size(27, 20);
			this.Loc13Box.TabIndex = 8;
			this.Loc13Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc12Box
			// 
			this.Loc12Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc12Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc12Box.Location = new System.Drawing.Point(107, 76);
			this.Loc12Box.MaxLength = 1;
			this.Loc12Box.Name = "Loc12Box";
			this.Loc12Box.Size = new System.Drawing.Size(26, 20);
			this.Loc12Box.TabIndex = 7;
			this.Loc12Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc11Box
			// 
			this.Loc11Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc11Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc11Box.Location = new System.Drawing.Point(73, 76);
			this.Loc11Box.MaxLength = 1;
			this.Loc11Box.Name = "Loc11Box";
			this.Loc11Box.Size = new System.Drawing.Size(27, 20);
			this.Loc11Box.TabIndex = 6;
			this.Loc11Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc10Box
			// 
			this.Loc10Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc10Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc10Box.Location = new System.Drawing.Point(40, 76);
			this.Loc10Box.MaxLength = 1;
			this.Loc10Box.Name = "Loc10Box";
			this.Loc10Box.Size = new System.Drawing.Size(27, 20);
			this.Loc10Box.TabIndex = 5;
			this.Loc10Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc23Box
			// 
			this.Loc23Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc23Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc23Box.Location = new System.Drawing.Point(140, 104);
			this.Loc23Box.MaxLength = 1;
			this.Loc23Box.Name = "Loc23Box";
			this.Loc23Box.Size = new System.Drawing.Size(27, 20);
			this.Loc23Box.TabIndex = 12;
			this.Loc23Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc22Box
			// 
			this.Loc22Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc22Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc22Box.Location = new System.Drawing.Point(107, 104);
			this.Loc22Box.MaxLength = 1;
			this.Loc22Box.Name = "Loc22Box";
			this.Loc22Box.Size = new System.Drawing.Size(26, 20);
			this.Loc22Box.TabIndex = 11;
			this.Loc22Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc21Box
			// 
			this.Loc21Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc21Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc21Box.Location = new System.Drawing.Point(73, 104);
			this.Loc21Box.MaxLength = 1;
			this.Loc21Box.Name = "Loc21Box";
			this.Loc21Box.Size = new System.Drawing.Size(27, 20);
			this.Loc21Box.TabIndex = 10;
			this.Loc21Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc20Box
			// 
			this.Loc20Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc20Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc20Box.Location = new System.Drawing.Point(40, 104);
			this.Loc20Box.MaxLength = 1;
			this.Loc20Box.Name = "Loc20Box";
			this.Loc20Box.Size = new System.Drawing.Size(27, 20);
			this.Loc20Box.TabIndex = 9;
			this.Loc20Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc33Box
			// 
			this.Loc33Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc33Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc33Box.Location = new System.Drawing.Point(140, 132);
			this.Loc33Box.MaxLength = 1;
			this.Loc33Box.Name = "Loc33Box";
			this.Loc33Box.Size = new System.Drawing.Size(27, 20);
			this.Loc33Box.TabIndex = 16;
			this.Loc33Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc32Box
			// 
			this.Loc32Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc32Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc32Box.Location = new System.Drawing.Point(107, 132);
			this.Loc32Box.MaxLength = 1;
			this.Loc32Box.Name = "Loc32Box";
			this.Loc32Box.Size = new System.Drawing.Size(26, 20);
			this.Loc32Box.TabIndex = 15;
			this.Loc32Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc31Box
			// 
			this.Loc31Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc31Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc31Box.Location = new System.Drawing.Point(73, 132);
			this.Loc31Box.MaxLength = 1;
			this.Loc31Box.Name = "Loc31Box";
			this.Loc31Box.Size = new System.Drawing.Size(27, 20);
			this.Loc31Box.TabIndex = 14;
			this.Loc31Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc30Box
			// 
			this.Loc30Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc30Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc30Box.Location = new System.Drawing.Point(40, 132);
			this.Loc30Box.MaxLength = 1;
			this.Loc30Box.Name = "Loc30Box";
			this.Loc30Box.Size = new System.Drawing.Size(27, 20);
			this.Loc30Box.TabIndex = 13;
			this.Loc30Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc03Box
			// 
			this.Loc03Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc03Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc03Box.Location = new System.Drawing.Point(140, 49);
			this.Loc03Box.MaxLength = 1;
			this.Loc03Box.Name = "Loc03Box";
			this.Loc03Box.Size = new System.Drawing.Size(27, 20);
			this.Loc03Box.TabIndex = 4;
			this.Loc03Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc02Box
			// 
			this.Loc02Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc02Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc02Box.Location = new System.Drawing.Point(107, 49);
			this.Loc02Box.MaxLength = 1;
			this.Loc02Box.Name = "Loc02Box";
			this.Loc02Box.Size = new System.Drawing.Size(26, 20);
			this.Loc02Box.TabIndex = 3;
			this.Loc02Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc01Box
			// 
			this.Loc01Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc01Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc01Box.Location = new System.Drawing.Point(73, 49);
			this.Loc01Box.MaxLength = 1;
			this.Loc01Box.Name = "Loc01Box";
			this.Loc01Box.Size = new System.Drawing.Size(27, 20);
			this.Loc01Box.TabIndex = 2;
			this.Loc01Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Loc00Box
			// 
			this.Loc00Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Loc00Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Loc00Box.Location = new System.Drawing.Point(40, 49);
			this.Loc00Box.MaxLength = 1;
			this.Loc00Box.Name = "Loc00Box";
			this.Loc00Box.Size = new System.Drawing.Size(27, 20);
			this.Loc00Box.TabIndex = 1;
			this.Loc00Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DispAllBtn
			// 
			this.DispAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.DispAllBtn.ForeColor = System.Drawing.Color.Red;
			this.DispAllBtn.Location = new System.Drawing.Point(120, 296);
			this.DispAllBtn.Name = "DispAllBtn";
			this.DispAllBtn.Size = new System.Drawing.Size(93, 26);
			this.DispAllBtn.TabIndex = 20;
			this.DispAllBtn.Text = "Display All";
			this.DispAllBtn.Click += new System.EventHandler(this.DispAllBtn_Click);
			// 
			// MinBox
			// 
			this.MinBox.Location = new System.Drawing.Point(33, 21);
			this.MinBox.MaxLength = 2;
			this.MinBox.Name = "MinBox";
			this.MinBox.Size = new System.Drawing.Size(27, 20);
			this.MinBox.TabIndex = 2;
			this.MinBox.Text = "4";
			this.MinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.MinBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinBox_KeyPress);
			this.MinBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MinBox_KeyDown);
			// 
			// MaxBox
			// 
			this.MaxBox.Location = new System.Drawing.Point(100, 21);
			this.MaxBox.MaxLength = 2;
			this.MaxBox.Name = "MaxBox";
			this.MaxBox.Size = new System.Drawing.Size(27, 20);
			this.MaxBox.TabIndex = 4;
			this.MaxBox.Text = "16";
			this.MaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.MaxBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxBox_KeyPress);
			this.MaxBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaxBox_KeyDown);
			// 
			// MinLbl
			// 
			this.MinLbl.Location = new System.Drawing.Point(7, 21);
			this.MinLbl.Name = "MinLbl";
			this.MinLbl.Size = new System.Drawing.Size(26, 21);
			this.MinLbl.TabIndex = 1;
			this.MinLbl.Text = "Min";
			this.MinLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MaxLbl
			// 
			this.MaxLbl.Location = new System.Drawing.Point(73, 21);
			this.MaxLbl.Name = "MaxLbl";
			this.MaxLbl.Size = new System.Drawing.Size(27, 21);
			this.MaxLbl.TabIndex = 3;
			this.MaxLbl.Text = "Max";
			this.MaxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LengthGrp
			// 
			this.LengthGrp.Controls.Add(this.MaxLbl);
			this.LengthGrp.Controls.Add(this.MinLbl);
			this.LengthGrp.Controls.Add(this.MaxBox);
			this.LengthGrp.Controls.Add(this.MinBox);
			this.LengthGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.LengthGrp.Location = new System.Drawing.Point(47, 222);
			this.LengthGrp.Name = "LengthGrp";
			this.LengthGrp.Size = new System.Drawing.Size(133, 48);
			this.LengthGrp.TabIndex = 18;
			this.LengthGrp.TabStop = false;
			this.LengthGrp.Text = "Length of Words";
			// 
			// MainMenu
			// 
			this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu10Item,
            this.Menu20Item});
			// 
			// Menu10Item
			// 
			this.Menu10Item.Index = 0;
			this.Menu10Item.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu11Item,
            this.MenuBar1,
            this.Menu12Item});
			this.Menu10Item.Text = "Control";
			// 
			// Menu11Item
			// 
			this.Menu11Item.Index = 0;
			this.Menu11Item.Shortcut = System.Windows.Forms.Shortcut.F2;
			this.Menu11Item.Text = "Reset";
			this.Menu11Item.Click += new System.EventHandler(this.Menu11Item_Click);
			// 
			// MenuBar1
			// 
			this.MenuBar1.Index = 1;
			this.MenuBar1.Text = "-";
			// 
			// Menu12Item
			// 
			this.Menu12Item.Index = 2;
			this.Menu12Item.Text = "Exit";
			this.Menu12Item.Click += new System.EventHandler(this.Menu12Item_Click);
			// 
			// Menu20Item
			// 
			this.Menu20Item.Index = 1;
			this.Menu20Item.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu21Item,
            this.MenuBar2,
            this.Menu22Item});
			this.Menu20Item.Text = "Help";
			// 
			// Menu21Item
			// 
			this.Menu21Item.Index = 0;
			this.Menu21Item.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.Menu21Item.Text = "Help";
			this.Menu21Item.Click += new System.EventHandler(this.Menu21Item_Click);
			// 
			// MenuBar2
			// 
			this.MenuBar2.Index = 1;
			this.MenuBar2.Text = "-";
			// 
			// Menu22Item
			// 
			this.Menu22Item.Index = 2;
			this.Menu22Item.Text = "About...";
			this.Menu22Item.Click += new System.EventHandler(this.Menu22Item_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(531, 419);
			this.Controls.Add(this.LengthGrp);
			this.Controls.Add(this.DispAllBtn);
			this.Controls.Add(this.BogLbl);
			this.Controls.Add(this.RandBtn);
			this.Controls.Add(this.Loc13Box);
			this.Controls.Add(this.Loc12Box);
			this.Controls.Add(this.Loc11Box);
			this.Controls.Add(this.Loc10Box);
			this.Controls.Add(this.Loc23Box);
			this.Controls.Add(this.Loc22Box);
			this.Controls.Add(this.Loc21Box);
			this.Controls.Add(this.Loc20Box);
			this.Controls.Add(this.Loc33Box);
			this.Controls.Add(this.Loc32Box);
			this.Controls.Add(this.Loc31Box);
			this.Controls.Add(this.Loc30Box);
			this.Controls.Add(this.Loc03Box);
			this.Controls.Add(this.Loc02Box);
			this.Controls.Add(this.Loc01Box);
			this.Controls.Add(this.Loc00Box);
			this.Controls.Add(this.AnswerBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(537, 464);
			this.Menu = this.MainMenu;
			this.MinimumSize = new System.Drawing.Size(537, 464);
			this.Name = "Form1";
			this.Text = "Boggle Word Finder";
			this.LengthGrp.ResumeLayout(false);
			this.LengthGrp.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void LoadDictionary()
			//Loads the dictionary
		{
			string dir = Directory.GetCurrentDirectory();
			ArrayList data = new ArrayList();
			StreamReader rdr = new StreamReader(dir + "\\" + "dictionary.txt");
			string word;
			while((word = rdr.ReadLine()) != null)
			{
				data.Add(word);
			}
			rdr.Close();
			Dictionary = data.ToArray(typeof(string)) as string[];
		}

		private void RandBtn_Click(object sender, System.EventArgs e)
			//Rolls the dice and puts in the letters
		{
			ArrayList ilist = new ArrayList(16);
			int temp;
			while(true)
			{
				temp = rdm.Next(0, 16);
				if(!ilist.Contains(temp))
				{
					ilist.Add(temp);
				}
				if(ilist.Count == 16) break;
			}
			for(int i = 0; i < 16; i++)
			{
				BoggleSquare[i % 4, i / 4].Text = Dice[int.Parse(ilist[i].ToString()), rdm.Next(0, 5)].ToString();
			}	
		}

		private void DispAllBtn_Click(object sender, System.EventArgs e)
		{
			bool go = true;
			foreach(TextBox s in BoggleSquare)
			{
				if(s.Text == "")
				{
					go = false;
					string msg = "All sixteen fields must be filled before the square can be solved.";
					MessageBox.Show(this, msg, "Blank field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				}
			}
			if(go)
			{
				Answers.Clear();
				Block = new char[4,4]
				{
					{char.Parse(Loc00Box.Text), char.Parse(Loc10Box.Text), char.Parse(Loc20Box.Text), char.Parse(Loc30Box.Text)}, 
					{char.Parse(Loc01Box.Text), char.Parse(Loc11Box.Text), char.Parse(Loc21Box.Text), char.Parse(Loc31Box.Text)}, 
					{char.Parse(Loc02Box.Text), char.Parse(Loc12Box.Text), char.Parse(Loc22Box.Text), char.Parse(Loc32Box.Text)}, 
					{char.Parse(Loc03Box.Text), char.Parse(Loc13Box.Text), char.Parse(Loc23Box.Text), char.Parse(Loc33Box.Text)}
				};
				if(MinBox.Text != "") Min = int.Parse(MinBox.Text);
				else Min = 4;
				if(MaxBox.Text != "") Max = int.Parse(MaxBox.Text);
				else Max = 99;

				for(int i = 0; i < Dictionary.Length; i++)
				{
					string word = Dictionary[i];
					if(word.Length >= Min && word.Length <= Max)
					{
						if(WordFinder(0, word.ToUpper(), new int[word.Length]))
						{
							Answers.Add(word);
						}
					}
				}
			
				string display = "";
				for(int i = 0; i < Answers.Count; i++)
				{
					display += Answers[i].ToString() + " ";
				}
				AnswerBox.Text = display;
				AnswerBox.ScrollBars = ScrollBars.None;
				if (AnswerBox.GetCharIndexFromPosition(TextBoxCornerPoint) < AnswerBox.Lines[0].Length - 1)
				{
					AnswerBox.ScrollBars = ScrollBars.Vertical;
				}
			}
		}

		public bool WordFinder(int q, string word, int[] poslist)
			//Primary search function
        {	
            /*  
			 * Give WordFinder a word and it will return whether or not the word exists
			 * in the Boggle block. 
			 * 
			 * Activater: WordFinder(0, string 'word', new char['word'.Length], new int['word'.Length})
			 * 
			 * Static Passed Items:
			 * 1. string word: gets passed this from the Dictionary
			 * 
			 * Variable Passed Items:
			 * 1. int q: how many loops have been created
			 * 2. char[] aword: gets built along the way
			 * 3. int[] poslist: list of all positions listed in aword
			 * 
			 * Returned Item:
			 * 1. bool answer: whether or not it was found
			*/
		
			bool answer = false;
			if(q == 0)
				//For the first loop
			{
				for(int loc = 0; loc < 16; loc++)
				{
					poslist[0] = loc;
					if(word[0] == Block[loc % 4, loc / 4] && WordFinder(1, word, poslist))
					{
						answer = true;
						break;
					}
				}
				return answer;
			}

			else if(q != word.Length && q != 0)
				//For the loops inbetween
			{
				for(int i = 0; i < 8; i++)
				{
					int loc = ModPos(poslist[q - 1], i);
					bool goodloc = true;
					
					if(loc == -1) goodloc = false;
					else if(word[q] != Block[loc % 4, loc / 4]) goodloc = false;
					for(int j = 0; j < q; j++)
						//Looks to see if this position has already been used
					{
						if(loc == poslist[j])
						{
							goodloc = false;
						}
					}
					if(goodloc)
					{
						poslist[q] = loc;
						if(WordFinder(q + 1, word, poslist))
						{
							answer = true;
							break;
						}
					}
				}
				return answer;
			}

			else if(q == word.Length)
				//No loops left, it passes
			{
				return true;
			}
			else return false;
		}

		private int ModPos(int loc, int dir)
			//With a given position and direction, it returns the new position
		{
			int[] pos = new int[2]{loc % 4, loc / 4};
			if(dir == 0)
			{
				pos[1] = pos[1] - 1;
			}
			else if(dir == 1)
			{
				pos[0] = pos[0] + 1;
				pos[1] = pos[1] - 1;
			}
			else if(dir == 2)
			{
				pos[0] = pos[0] + 1;
			}
			else if(dir == 3)
			{
				pos[0] = pos[0] + 1;
				pos[1] = pos[1] + 1;
			}
			else if(dir == 4)
			{
				pos[1] = pos[1] + 1;
			}
			else if(dir == 5)
			{
				pos[0] = pos[0] - 1;
				pos[1] = pos[1] + 1;
			}
			else if(dir == 6)
			{
				pos[0] = pos[0] - 1;
			}
			else if(dir == 7)
			{
				pos[0] = pos[0] - 1;
				pos[1] = pos[1] - 1;
			}

			if(pos[0] < 0 || pos[0] > 3 || pos[1] < 0 || pos[1] > 3)
			{
				return -1;
			}
			else
			{
				return pos[0] + pos[1] * 4;
			}
		}

		//***Menu functions***//
		private void Menu11Item_Click(object sender, System.EventArgs e)
			//Reset button
		{
			foreach(TextBox s in BoggleSquare)
			{
				s.Text = "";
			}
			AnswerBox.Text = "";
			MinBox.Text = "4";
			MaxBox.Text = "16";
		}

		private void Menu12Item_Click(object sender, System.EventArgs e)
			//Exit button
		{
			this.Close();
		}

		private void Menu21Item_Click(object sender, System.EventArgs e)
			//Help button
		{
			FormHelp1.CenterToForm1(this.Location);
			FormHelp1.Show();
			FormHelp1.BringToFront();
        }

		private void Menu22Item_Click(object sender, System.EventArgs e)
			//About button
		{
			FormAbout1.CenterToForm1(this.Location);
            FormAbout1.Show();
			FormAbout1.BringToFront();
		}

		//***Letterbox functions***//
		private void s_KeyPress(object sender, KeyPressEventArgs e)
		    //Replaces a letter in the letterbox and ignores all non-letter characters
        {
			if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
			{
				(sender as TextBox).Text = e.KeyChar.ToString();
			}
                e.Handled = true;
        }

        private void s_Enter(object sender, EventArgs e)
			//Highlights the letterbox when it is tabbed
        {
            (sender as TextBox).SelectAll();
        }

		private void s_Click(object sender, EventArgs e)
			//Highlights the letterbox when it is clicked
		{
			(sender as TextBox).SelectAll();
		}

		//***Disallow non-numerical inputs in Minbox/Maxbox***//
		private void MinBox_KeyDown(object sender, KeyEventArgs e)
		{
			MaxMinAllowEntry = false;
			if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back)
			{
				MaxMinAllowEntry = true;
			}
		}

		private void MaxBox_KeyDown(object sender, KeyEventArgs e)
		{
			MaxMinAllowEntry = false;
			if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
			{
				MaxMinAllowEntry = true;
			}
		}

		private void MinBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!MaxMinAllowEntry)
			{
				e.Handled = true;
			}
		}

		private void MaxBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!MaxMinAllowEntry)
			{
				e.Handled = true;
			}
		}
	}
}
