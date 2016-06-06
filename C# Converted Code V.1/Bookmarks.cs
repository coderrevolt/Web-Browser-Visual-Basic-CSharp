using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class Bookmarks
{
	private void ListBox2_SelectedIndexChanged(System.Object sender, System.EventArgs e)
	{
		ListBox2.SelectedIndex = ListBox1.SelectedIndex;
	}

	private void Bookmarks_Load(System.Object sender, System.EventArgs e)
	{
		this.TopMost = true;

		Timer1.Start();
	}

	private void Button3_Click(System.Object sender, System.EventArgs e)
	{
		try {
			ListBox1.Items.Remove(ListBox1.SelectedItem);
			ListBox2.Items.Remove(ListBox2.SelectedItem);
			MessageBox.Show("Deleted!");
			Button1.PerformClick();

		} catch (Exception ex) {


		}

	}

	private void Button1_Click(System.Object sender, System.EventArgs e)
	{
		IO.StreamWriter w = default(IO.StreamWriter);

		try {
			int i = 0;
			w = new IO.StreamWriter("C:\\CoderRevolt\\WebBrowser\\V1\\Bookmarks.gwbb");
			for (i = 0; i <= ListBox1.Items.Count - 1; i++) {
				w.WriteLine(ListBox1.Items.Item(i));
			}
			w.Close();

		} catch (Exception ex) {
		}
		try {
			int i = 0;
			w = new IO.StreamWriter("C:\\CoderRevolt\\WebBrowser\\V1\\Bookmarks2.gwbb");
			for (i = 0; i <= ListBox2.Items.Count - 1; i++) {
				w.WriteLine(ListBox2.Items.Item(i));
			}
			w.Close();

		} catch (Exception ex) {
		}
	}


	private void Timer1_Tick(System.Object sender, System.EventArgs e)
	{

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



	private void Button4_Click_1(object sender, EventArgs e)
	{
		this.Hide();
		Button1.PerformClick();
	}
	public Bookmarks()
	{
		Load += Bookmarks_Load;
	}
}
