
using System;
using System.Net;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Configuration;

namespace MyTranslate
{
	public partial class MainForm : Form
	{	
		MyData  trans = new MyData();
		string serialized;
		
		QuickKnow QK = new QuickKnow();
		
		//string name;
		//bool lang = true;
		
		
		public MainForm()
		{
			InitializeComponent();
			Process.Start("TranslatePy.py");
			//for (int i=0; i> Properties.Settings1.Default.sl.Count; i++)
			//	listBox1.Items.Add(Properties.Settings1.Default.tl[i]+"     -     "+ Properties.Settings1.Default.tl[i]);
			//StreamReader fr = new StreamReader("save.txt");
			string[] t = File.ReadAllLines("save.txt");
			foreach (var i in t )
			{
				listBox1.Items.Add(i);
			
			}
			trans.sl = "en";
			trans.tl = "ru";
			timer2.Start();
		}
		
		
	
		
		/*void Button4Click(object sender, EventArgs e)
		{
			
			trans.q = System.Net.WebUtility.UrlEncode(textBox1.Text);
			serialized = JsonConvert.SerializeObject(trans);
			StreamWriter filew = new StreamWriter(@"C:\Users\User\AppData\Local\Temp\DataBase.txt");
			filew.WriteLine(serialized);
			filew.Close();
			StreamReader file = new StreamReader(@"C:\Users\User\AppData\Local\Temp\translate.txt");	
			label2.Text = System.Net.WebUtility.UrlDecode(file.ReadLine());
			file.Close();
			Properties.Settings1.Default.sl.Add(textBox1.Text);			
			Properties.Settings1.Default.tl.Add(label2.Text);
			Properties.Settings1.Default.Save();
			
		}
		*/
		void trigger(object sender, EventArgs e)
		{	
			
			//lang= !lang;
			trans.sl = button1.Text.ToLower();
			button1.Text = button2.Text;
			button2.Text= trans.sl;
			trans.tl = button1.Text.ToLower();
			
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
		save(textBox1.Text,label2.Text);
					
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{	try{
				
				
			
			trans.q = System.Net.WebUtility.UrlEncode(textBox1.Text);
			serialized = JsonConvert.SerializeObject(trans);
			StreamWriter filew = new StreamWriter("DataBase.txt");
			filew.WriteLine(serialized);
			filew.Close();
			//StreamReader file = new StreamReader("translate.txt");	
			label2.Text = System.Net.WebUtility.UrlDecode(File.ReadAllText("translate.txt"));
			//file.Close();
			} catch{}
			
			
		}
		
		
		
	
		
		void Button4Click(object sender, EventArgs e)
		{	
			//for (int i=0; i < Properties.Settings1.Default.sl.Count; i++)
				//listBox1.Items.Add(Properties.Settings1.Default.tl[i]+"            -            "+ Properties.Settings1.Default.tl[i]);
				QK.timer1.Start();
				timer2.Stop();
				QK.Show();
				
				
			
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
		//Properties.Settings1.Default.Save();
			
		}
		
		
		
		
		
		void TextBox1Click(object sender, EventArgs e)
		{
			this.timer2.Start();
			
			
			
			
		}
		
		public void save(Object tx1, Object tx2)
		{
		using (StreamWriter sw = File.AppendText("save.txt")) 
		{
    		sw.WriteLine(tx1 + " - " + tx2);
    		sw.Close();
		}
		
		
		listBox1.Items.Add(tx1 + " - " + tx2);
		
		}
	}
	
	

		 public class MyData
        {
            //public Track[] Tracks { get; set; }
            public string sl { get; set; }
            public string tl { get; set; }
            public  System.String q { get; set; }
            
             
        }
 
	
}
