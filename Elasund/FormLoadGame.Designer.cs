namespace Elasund
{
	partial class FormLoadGame
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
			this.buttonGo = new System.Windows.Forms.Button();
			this.checkBoxFullScreen = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton1024x768 = new System.Windows.Forms.RadioButton();
			this.radioButton1280x800 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonGo
			// 
			this.buttonGo.Location = new System.Drawing.Point(100, 227);
			this.buttonGo.Name = "buttonGo";
			this.buttonGo.Size = new System.Drawing.Size(75, 23);
			this.buttonGo.TabIndex = 0;
			this.buttonGo.Text = "Go!";
			this.buttonGo.UseVisualStyleBackColor = true;
			this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
			// 
			// checkBoxFullScreen
			// 
			this.checkBoxFullScreen.AutoSize = true;
			this.checkBoxFullScreen.Location = new System.Drawing.Point(18, 139);
			this.checkBoxFullScreen.Name = "checkBoxFullScreen";
			this.checkBoxFullScreen.Size = new System.Drawing.Size(76, 17);
			this.checkBoxFullScreen.TabIndex = 1;
			this.checkBoxFullScreen.Text = "FullScreen";
			this.checkBoxFullScreen.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton1280x800);
			this.groupBox1.Controls.Add(this.radioButton1024x768);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(97, 112);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Resolution";
			// 
			// radioButton1024x768
			// 
			this.radioButton1024x768.AutoSize = true;
			this.radioButton1024x768.Checked = true;
			this.radioButton1024x768.Location = new System.Drawing.Point(6, 19);
			this.radioButton1024x768.Name = "radioButton1024x768";
			this.radioButton1024x768.Size = new System.Drawing.Size(78, 17);
			this.radioButton1024x768.TabIndex = 0;
			this.radioButton1024x768.TabStop = true;
			this.radioButton1024x768.Text = "1024 x 768";
			this.radioButton1024x768.UseVisualStyleBackColor = true;
			// 
			// radioButton1280x800
			// 
			this.radioButton1280x800.AutoSize = true;
			this.radioButton1280x800.Location = new System.Drawing.Point(6, 42);
			this.radioButton1280x800.Name = "radioButton1280x800";
			this.radioButton1280x800.Size = new System.Drawing.Size(78, 17);
			this.radioButton1280x800.TabIndex = 1;
			this.radioButton1280x800.Text = "1280 x 800";
			this.radioButton1280x800.UseVisualStyleBackColor = true;
			// 
			// FormLoadGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.checkBoxFullScreen);
			this.Controls.Add(this.buttonGo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLoadGame";
			this.Text = "LoadGame";
			this.Load += new System.EventHandler(this.FormLoadGame_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonGo;
		private System.Windows.Forms.CheckBox checkBoxFullScreen;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1280x800;
		private System.Windows.Forms.RadioButton radioButton1024x768;
	}
}