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
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}


		private void btnMaximize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
			LoginForm lg = new LoginForm();
			lg.Show();
		}

		private void btnTransferHide_Click(object sender, EventArgs e)
		{
			panelMainMenu.Visible = false;
			btnTransferShow.Visible = true;
			btnTransferHide.Visible = false;	
		}

		private void btnTransferShow_Click(object sender, EventArgs e)
		{
			panelMainMenu.Visible = true;
			btnTransferHide.Visible = true;
			btnTransferShow.Visible = false;
		}
	}
}
