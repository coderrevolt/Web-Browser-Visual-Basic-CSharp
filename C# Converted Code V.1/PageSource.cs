using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class PageSource
{
	private void PageSource_Load(System.Object sender, System.EventArgs e)
	{
		this.TopMost = true;
		this.txtURL.Text = Main.ComboBox1.Text;

		btnViewSource.PerformClick();

	}

	private void btnViewSource_Click(System.Object sender, System.EventArgs e)
	{
		btnViewSource.Enabled = false;


		System.Net.WebClient WebStream = default(System.Net.WebClient);
		System.IO.Stream SourceCodeStream = default(System.IO.Stream);
		WebStream = new System.Net.WebClient();
		try {
			SourceCodeStream = WebStream.OpenRead(txtURL.Text);
			System.IO.StreamReader objReader = new System.IO.StreamReader(SourceCodeStream);
			txtSource.Text = objReader.ReadToEnd;
		} catch {
			Interaction.MsgBox("Invalid URL" + Constants.vbCrLf + "File looking for cannot be found.", MsgBoxStyle.Exclamation, "Invalid URL");
		}

		btnViewSource.Enabled = true;
	}
	public PageSource()
	{
		Load += PageSource_Load;
	}
}