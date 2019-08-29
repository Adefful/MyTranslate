/*
 * Created by SharpDevelop.
 * User: User
 * Date: 31.07.2017
 * Time: 14:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyTranslate
{
	partial class QuickKnow
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tb2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tb2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(1, -13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(354, 181);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// tb2
			// 
			this.tb2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb2.Cursor = System.Windows.Forms.Cursors.Default;
			this.tb2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tb2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tb2.Location = new System.Drawing.Point(3, 102);
			this.tb2.Multiline = true;
			this.tb2.Name = "tb2";
			this.tb2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb2.Size = new System.Drawing.Size(348, 76);
			this.tb2.TabIndex = 2;
			this.tb2.Click += new System.EventHandler(this.TextBox1Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.textBox1.Location = new System.Drawing.Point(3, 18);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(348, 78);
			this.textBox1.TabIndex = 1;
			this.textBox1.Click += new System.EventHandler(this.TextBox1Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(361, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(19, 157);
			this.button1.TabIndex = 1;
			this.button1.Text = "save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// QuickKnow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(378, 171);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(1, 1);
			this.Name = "QuickKnow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "QuickKnow";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.QuickKnowLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tb2;
		private System.Windows.Forms.TextBox textBox1;
	}
}
