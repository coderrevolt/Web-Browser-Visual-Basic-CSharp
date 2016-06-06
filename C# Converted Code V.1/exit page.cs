using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class exit_page
{
	private void Button1_Click(System.Object sender, System.EventArgs e)
	{
		Application.Exit();

	}

	private void Button2_Click(System.Object sender, System.EventArgs e)
	{
		this.Close();
		Main.Enabled = true;
		Main.Show();


	}


	private void exit_page_Load(object sender, EventArgs e)
	{
	}
	public exit_page()
	{
		Load += exit_page_Load;
	}
}