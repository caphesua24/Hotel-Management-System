using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();

			txbUsername.Text = "ADMIN";
			txbPassword.Text = "123";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(txbUsername.Text != "ADMIN" || txbPassword.Text == "123") 
			{
				Dashboard db = new Dashboard();
				db.Show();
				this.Hide();
			}
			else
			{
				lbInvalid.Visible = true;
			}
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			txbPassword.UseSystemPasswordChar = true;
			btnHide.Visible = false;
			btnShow.Visible = true;
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			txbPassword.UseSystemPasswordChar = false;
			btnShow.Visible = false;
			btnHide.Visible = true;
		}
	}
}
