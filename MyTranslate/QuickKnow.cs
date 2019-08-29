/*
 * Created by SharpDevelop.
 * User: User
 * Date: 31.07.2017
 * Time: 14:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MyTranslate
{
	/// <summary>
	/// Description of QuickKnow.
	/// </summary>
	public partial class QuickKnow : Form
	{	
		string serializ;
		//MainForm m = new MainForm();
		
		MyData  trans = new MyData();
		MainForm m;
		
		public QuickKnow()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			trans.sl = "en";
			trans.tl = "ru";
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox1Click(object sender, EventArgs e)
		{
			
			//m.timer2.Start();
			this.Visible = false;
			
			
		
			
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			//button4.Text = Clipboard.GetText();
			try{
			
				if (textBox1.Text != Clipboard.GetText())
				
			{
			this.Visible = true;
			m.timer2.Stop();
			textBox1.Text = Clipboard.GetText();
			if ((int)Clipboard.GetText()[0] > 64 && (int)Clipboard.GetText()[0] <123)
			{
			trans.tl ="ru";
			trans.sl = "en";
			}
			else 
			{trans.tl = "en";
			trans.sl = "ru";
			}
			
			trans.q = System.Net.WebUtility.UrlEncode(Clipboard.GetText());
			serializ = JsonConvert.SerializeObject(trans);
			StreamWriter filew = new StreamWriter("DataBase.txt");
			filew.WriteLine(serializ);
			filew.Close();
			StreamReader file = new StreamReader("translate.txt");	
			tb2.Text = System.Net.WebUtility.UrlDecode(file.ReadLine());
			file.Close();
			
			
			
			
			
			
			}
			//StreamReader files = new StreamReader("translate.txt");	//C:\Users\User\AppData\Local\Temp\translate.txt"
			tb2.Text = System.Net.WebUtility.UrlDecode(File.ReadAllText("translate.txt"));
			//files.Close();
			
			
			} catch (Exception ex){tb2.Text= ex.ToString();}
			
			
		}
		
		void QuickKnowLoad(object sender, EventArgs e)
		{
			m = new MainForm();
			
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			m.save(textBox1.Text, tb2.Text );
			
		}
	}
        
        


}


