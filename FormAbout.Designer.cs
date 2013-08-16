namespace Boggle2
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
			this.TitleLbl = new System.Windows.Forms.Label();
			this.LegalLbl = new System.Windows.Forms.Label();
			this.OkBtn = new System.Windows.Forms.Button();
			this.VersionLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLbl.ForeColor = System.Drawing.Color.Red;
			this.TitleLbl.Location = new System.Drawing.Point(120, 16);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(144, 19);
			this.TitleLbl.TabIndex = 0;
			this.TitleLbl.Text = "Boggle Word Finder";
			// 
			// LegalLbl
			// 
			this.LegalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.LegalLbl.Location = new System.Drawing.Point(8, 120);
			this.LegalLbl.Name = "LegalLbl";
			this.LegalLbl.Size = new System.Drawing.Size(268, 88);
			this.LegalLbl.TabIndex = 1;
			this.LegalLbl.Text = resources.GetString("LegalLbl.Text");
			// 
			// OkBtn
			// 
			this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.OkBtn.Location = new System.Drawing.Point(112, 224);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(72, 24);
			this.OkBtn.TabIndex = 2;
			this.OkBtn.Text = "OK";
			this.OkBtn.UseVisualStyleBackColor = true;
			this.OkBtn.Click += new System.EventHandler(this.OKBtn_Click);
			// 
			// VersionLbl
			// 
			this.VersionLbl.AutoSize = true;
			this.VersionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.VersionLbl.Location = new System.Drawing.Point(120, 40);
			this.VersionLbl.Name = "VersionLbl";
			this.VersionLbl.Size = new System.Drawing.Size(124, 26);
			this.VersionLbl.TabIndex = 3;
			this.VersionLbl.Text = "Version 2.0.0\r\nCreated by David Hagen";
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 252);
			this.Controls.Add(this.VersionLbl);
			this.Controls.Add(this.OkBtn);
			this.Controls.Add(this.LegalLbl);
			this.Controls.Add(this.TitleLbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "About Boggle Word Finder";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAbout_Paint);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAbout_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAbout_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label LegalLbl;
        private System.Windows.Forms.Button OkBtn;
		private System.Windows.Forms.Label VersionLbl;
    }
}