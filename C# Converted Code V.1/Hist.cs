using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class Hist
{
	IO.StreamWriter w;
	private void save()
	{
		int i = 0;
		w = new IO.StreamWriter("C:\\CoderRevolt\\WebBrowser\\V1\\History1.gwbb");
		for (i = 0; i <= ListBox1.Items.Count - 1; i++) {
			w.WriteLine(ListBox1.Items.Item(i));
		}
		w.Close();
		//
		int ii = 0;
		w = new IO.StreamWriter("C:\\CoderRevolt\\WebBrowser\\V1\\History2.gwbb");
		for (ii = 0; ii <= ListBox1.Items.Count - 1; ii++) {
			w.WriteLine(ListBox1.Items.Item(ii));
		}
		w.Close();
	}
	private void FindHistory(string searchString)
	{
		if (searchString != string.Empty) {
			int index = ListBox1.FindString(searchString);
			if (index != -1) {
				ListBox1.SetSelected(index, true);
			} else {
				MessageBox.Show("could not match any history for " + TextBox1.Text);
			}
		}
	}

	private void Button7_Click(System.Object sender, System.EventArgs e)
	{
		FindHistory(TextBox1.Text);
	}

	private void Button1_Click(System.Object sender, System.EventArgs e)
	{
		ListBox1.Items.Clear();
		ListBox2.Items.Clear();
		save();

	}


	private void ListBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
	{

		try {

		} catch (Exception ex) {
		}


	}


	private void History_Load(System.Object sender, System.EventArgs e)
	{




		this.TopMost = true;

		Timer1.Start();

	}

	private void History_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
	{


	}

	private void Timer1_Tick(System.Object sender, System.EventArgs e)
	{
		ListBox2.SelectedIndex = ListBox1.SelectedIndex;
	}

	private void Button3_Click(System.Object sender, System.EventArgs e)
	{
		MessageBox.Show("Deleted!");
	}

	private void Button2_Click(System.Object sender, System.EventArgs e)
	{
		try {
			Main.RadioButton2.Checked = true;

			Main.ComboBox1.Text = ListBox2.SelectedItem.ToString;
			Main.Button6.PerformClick();

		} catch (Exception ex) {
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		this.Hide();
	}
	public Hist()
	{
		FormClosing += History_FormClosing;
		Load += History_Load;
	}
}
