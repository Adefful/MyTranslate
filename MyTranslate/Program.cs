﻿/*
 * Created by SharpDevelop.
 * User: User
 * Date: 27.07.2017
 * Time: 20:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MyTranslate
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{ 
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			
		}
		
	}
}
