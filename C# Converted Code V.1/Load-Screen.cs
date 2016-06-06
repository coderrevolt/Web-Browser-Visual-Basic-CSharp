using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class Form1
{
	private void Form1_Load(object sender, EventArgs e)
	{
		//Get the timer to start
		Prog_In_Timer.Start();
	}

	private void Prog_In_Timer_Tick(object sender, EventArgs e)
	{
		//Inrement by +1 in progressbar #1 (get it started) 
		ProgressBar1.Increment(+1);


		//Add percent towards the central label
		Label2.Text = "Loading... " + ProgressBar1.Value.ToString + "%";
		IO.StreamReader r = default(IO.StreamReader);


		//Self-setup and checkup

		if (ProgressBar1.Value == "1") {
			if (My.Computer.FileSystem.DirectoryExists("C:\\CoderRevolt\\WebBrowser\\V1")) {
				//Check if returning user
			} else {
				//If user is new, then create core directory folder
				My.Computer.FileSystem.CreateDirectory("C:\\CoderRevolt\\WebBrowser\\V1");
			}

		}

		//Make sure History and Bookmarks panels are loaded up for next ProgressCheck @ Value '10'
		if (ProgressBar1.Value == "5") {
			Hist.Show();
			Hist.Hide();

			Bookmarks.Show();
			Bookmarks.Hide();

		}

		//Bookmark Self-Check and Setup
		if (ProgressBar1.Value == "10") {
			if (My.Computer.FileSystem.FileExists("C:\\CoderRevolt\\WebBrowser\\V1\\Bookmarks.gwbb")) {
				r = new IO.StreamReader("C:\\CoderRevolt\\WebBrowser\\V1\\Bookmarks.gwbb");
				while ((r.Peek() > -1)) {
					Bookmarks.ListBox1.Items.Add(r.ReadLine);
				}
				r.Close();

			} else {
			}
			if (My.Computer.FileSystem.FileExists("C:\\CoderRevolt\\WebBrowser\\V1\\Bookmarks2.gwbb")) {
				r = new IO.StreamReader("C:\\CoderRevolt\\WebBrowser\\V1\\Bookmarks2.gwbb");
				while ((r.Peek() > -1)) {
					Bookmarks.ListBox2.Items.Add(r.ReadLine);
				}
				r.Close();

			} else {
			}
		}

		//History Self-Check and Setup 
		if (ProgressBar1.Value == "20") {
			if (My.Computer.FileSystem.FileExists("C:\\CoderRevolt\\WebBrowser\\V1\\History1.gwbb")) {
				r = new IO.StreamReader("C:\\CoderRevolt\\WebBrowser\\V1\\History1.gwbb");
				while ((r.Peek() > -1)) {
					Hist.ListBox1.Items.Add(r.ReadLine);
				}
				r.Close();

			} else {
			}
			if (My.Computer.FileSystem.FileExists("C:\\CoderRevolt\\WebBrowser\\V1\\History2.gwbb")) {
				r = new IO.StreamReader("C:\\CoderRevolt\\WebBrowser\\V1\\History2.gwbb");
				while ((r.Peek() > -1)) {
					Hist.ListBox2.Items.Add(r.ReadLine);
				}
				r.Close();

			} else {
			}
		}
		if (ProgressBar1.Value == "100") {
			Prog_In_Timer.Stop();
			this.Hide();

			Main.Show();

		}


	}
	public Form1()
	{
		Load += Form1_Load;
	}
}