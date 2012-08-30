using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elasund
{
	public partial class FormLoadGame : Form
	{
		public FormLoadGame()
		{
			InitializeComponent();
		}

		private void FormLoadGame_Load(object sender, EventArgs e)
		{

		}

		private void buttonGo_Click(object sender, EventArgs e)
		{
			if (checkBoxFullScreen.CheckState == CheckState.Checked)
				Settings.FULL_SCREEN = true;
			else if (checkBoxFullScreen.CheckState == CheckState.Unchecked)
				Settings.FULL_SCREEN = false;

			if (radioButton1024x768.Checked)
			{
				Settings.SCREEN_WIDTH = 1024;
				Settings.SCREEN_HEIGHT = 768;
			}
			else
			{
				Settings.SCREEN_WIDTH = 1280;
				Settings.SCREEN_HEIGHT = 800;
			}

			DialogResult = DialogResult.OK;
		}
	}
}
