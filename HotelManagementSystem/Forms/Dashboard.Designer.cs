namespace HotelManagementSystem
{
	partial class Dashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.btnExit = new System.Windows.Forms.Button();
			this.btnMaximize = new System.Windows.Forms.Button();
			this.btnTransferShow = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnTransferHide = new System.Windows.Forms.Button();
			this.panelMainMenu = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.panelMainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
			this.btnExit.Location = new System.Drawing.Point(1168, 14);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(20, 20);
			this.btnExit.TabIndex = 1;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnMaximize
			// 
			this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
			this.btnMaximize.Location = new System.Drawing.Point(1145, 14);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(20, 20);
			this.btnMaximize.TabIndex = 0;
			this.btnMaximize.UseVisualStyleBackColor = true;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// btnTransferShow
			// 
			this.btnTransferShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransferShow.BackgroundImage")));
			this.btnTransferShow.FlatAppearance.BorderSize = 0;
			this.btnTransferShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransferShow.Location = new System.Drawing.Point(6, 12);
			this.btnTransferShow.Name = "btnTransferShow";
			this.btnTransferShow.Size = new System.Drawing.Size(25, 25);
			this.btnTransferShow.TabIndex = 1;
			this.btnTransferShow.UseVisualStyleBackColor = true;
			this.btnTransferShow.Visible = false;
			this.btnTransferShow.Click += new System.EventHandler(this.btnTransferShow_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnTransferShow);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(307, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(893, 45);
			this.panel2.TabIndex = 3;
			// 
			// btnTransferHide
			// 
			this.btnTransferHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransferHide.BackgroundImage")));
			this.btnTransferHide.FlatAppearance.BorderSize = 0;
			this.btnTransferHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTransferHide.Location = new System.Drawing.Point(276, 14);
			this.btnTransferHide.Name = "btnTransferHide";
			this.btnTransferHide.Size = new System.Drawing.Size(25, 25);
			this.btnTransferHide.TabIndex = 0;
			this.btnTransferHide.UseVisualStyleBackColor = true;
			this.btnTransferHide.Click += new System.EventHandler(this.btnTransferHide_Click);
			// 
			// panelMainMenu
			// 
			this.panelMainMenu.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panelMainMenu.Controls.Add(this.btnTransferHide);
			this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMainMenu.Name = "panelMainMenu";
			this.panelMainMenu.Size = new System.Drawing.Size(307, 800);
			this.panelMainMenu.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(307, 45);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(893, 100);
			this.panel1.TabIndex = 4;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1200, 800);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnMaximize);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelMainMenu);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel2.ResumeLayout(false);
			this.panelMainMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnMaximize;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnTransferShow;
		private System.Windows.Forms.Button btnTransferHide;
		private System.Windows.Forms.Panel panelMainMenu;
		private System.Windows.Forms.Panel panel1;
	}
}