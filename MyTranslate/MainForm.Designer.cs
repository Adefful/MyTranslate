/*
 * Created by SharpDevelop.
 * User: User
 * Date: 27.07.2017
 * Time: 20:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyTranslate
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.l1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.l2 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// l1
			// 
			this.l1.BackColor = System.Drawing.Color.Black;
			this.l1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l1.Location = new System.Drawing.Point(10, 9);
			this.l1.Name = "l1";
			this.l1.Size = new System.Drawing.Size(295, 101);
			this.l1.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.AllowDrop = true;
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listBox1.Font = new System.Drawing.Font("Lasco", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 28;
			this.listBox1.Location = new System.Drawing.Point(0, 153);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(622, 282);
			this.listBox1.TabIndex = 2;
			// 
			// l2
			// 
			this.l2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.l2.BackColor = System.Drawing.Color.Black;
			this.l2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.l2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l2.Location = new System.Drawing.Point(315, 9);
			this.l2.Name = "l2";
			this.l2.Size = new System.Drawing.Size(295, 101);
			this.l2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(349, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(261, 99);
			this.label2.TabIndex = 5;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 99);
			this.label1.TabIndex = 7;
			this.label1.Click += new System.EventHandler(this.TextBox1Click);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Lasco", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.textBox1.Location = new System.Drawing.Point(12, 47);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(258, 27);
			this.textBox1.TabIndex = 8;
			this.textBox1.Click += new System.EventHandler(this.TextBox1Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Lasco", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.SystemColors.GrayText;
			this.button1.Location = new System.Drawing.Point(269, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 63);
			this.button1.TabIndex = 9;
			this.button1.Text = "En";
			this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.trigger);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Lasco", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.SystemColors.GrayText;
			this.button2.Location = new System.Drawing.Point(311, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 63);
			this.button2.TabIndex = 10;
			this.button2.Text = "Ru";
			this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.trigger);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Lasco", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.SystemColors.GrayText;
			this.button3.Location = new System.Drawing.Point(269, 69);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(82, 41);
			this.button3.TabIndex = 11;
			this.button3.Text = "Save";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// button4
			// 
			this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(269, 109);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(82, 32);
			this.button4.TabIndex = 12;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(622, 435);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.l2);
			this.Controls.Add(this.l1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuicKnow";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button4;
		public System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label l2;
		private System.Windows.Forms.Label l1;
		
		
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			
		}
	}
}
