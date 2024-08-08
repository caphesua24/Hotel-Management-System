namespace HotelManagementSystem
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbInvalid = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txbPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txbUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnHide = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.btnShow);
			this.panel1.Controls.Add(this.lbInvalid);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txbUsername);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.txbPassword);
			this.panel1.Controls.Add(this.btnHide);
			this.panel1.Location = new System.Drawing.Point(300, 185);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(600, 420);
			this.panel1.TabIndex = 0;
			// 
			// lbInvalid
			// 
			this.lbInvalid.AutoSize = true;
			this.lbInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbInvalid.ForeColor = System.Drawing.Color.Red;
			this.lbInvalid.Location = new System.Drawing.Point(350, 347);
			this.lbInvalid.Name = "lbInvalid";
			this.lbInvalid.Size = new System.Drawing.Size(190, 16);
			this.lbInvalid.TabIndex = 6;
			this.lbInvalid.Text = "Invalid Username or Password";
			this.lbInvalid.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(317, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "HOTEL MANAGEMENT SYSTEM";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button1.Location = new System.Drawing.Point(319, 304);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(259, 34);
			this.button1.TabIndex = 5;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txbPassword
			// 
			this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txbPassword.Location = new System.Drawing.Point(319, 256);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.Size = new System.Drawing.Size(233, 26);
			this.txbPassword.TabIndex = 4;
			this.txbPassword.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(315, 234);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(367, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(173, 31);
			this.label2.TabIndex = 0;
			this.label2.Text = "LOGIN FORM";
			// 
			// txbUsername
			// 
			this.txbUsername.BackColor = System.Drawing.Color.White;
			this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txbUsername.Location = new System.Drawing.Point(319, 199);
			this.txbUsername.Name = "txbUsername";
			this.txbUsername.Size = new System.Drawing.Size(259, 26);
			this.txbUsername.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(315, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 19);
			this.label3.TabIndex = 1;
			this.label3.Text = "Username:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(300, 420);
			this.panel2.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(29, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(236, 38);
			this.label5.TabIndex = 2;
			this.label5.Text = "LUXURY HOTEL";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(50, 163);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Location = new System.Drawing.Point(1145, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(20, 20);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Location = new System.Drawing.Point(1168, 12);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(20, 20);
			this.button4.TabIndex = 3;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnShow
			// 
			this.btnShow.BackColor = System.Drawing.Color.White;
			this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
			this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnShow.Location = new System.Drawing.Point(552, 256);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(26, 26);
			this.btnShow.TabIndex = 8;
			this.btnShow.Text = "button5";
			this.btnShow.UseVisualStyleBackColor = false;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// btnHide
			// 
			this.btnHide.BackColor = System.Drawing.Color.White;
			this.btnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHide.BackgroundImage")));
			this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnHide.Location = new System.Drawing.Point(552, 256);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(26, 26);
			this.btnHide.TabIndex = 9;
			this.btnHide.Text = "button3";
			this.btnHide.UseVisualStyleBackColor = false;
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1200, 800);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbInvalid;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Button btnHide;
	}
}

