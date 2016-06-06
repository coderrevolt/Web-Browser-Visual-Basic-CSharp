using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
public class Main
{
	//Credits: Steve Aura <> http://www.coderrevolt.com
	//Copyrights: MIT MIT License

	int @int = 0;
	int i = 1;
	private void Loading(object sender, Windows.Forms.WebBrowserProgressChangedEventArgs e)
	{
		try {
			ToolStripProgressBar1.Maximum = e.MaximumProgress;
			ToolStripProgressBar1.Value = e.CurrentProgress;



		} catch (Exception ex) {
		}


	}

	private void historyin()
	{


		IO.StreamWriter w = default(IO.StreamWriter);
		Hist.ListBox1.Items.Add(((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).DocumentTitle);
		Hist.ListBox2.Items.Add(ComboBox1.Text);



		//Saving History
		int i = 0;
		w = new IO.StreamWriter("C:\\CoderRevolt\\WebBrowser\\V1\\History1.gwbb");
		for (i = 0; i <= Hist.ListBox1.Items.Count - 1; i++) {
			w.WriteLine(Hist.ListBox1.Items.Item(i));
		}
		w.Close();
		//
		int ii = 0;
		w = new IO.StreamWriter("C:\\CoderRevolt\\WebBrowser\\V1\\History2.gwbb");
		for (ii = 0; ii <= Hist.ListBox2.Items.Count - 1; ii++) {
			w.WriteLine(Hist.ListBox2.Items.Item(ii));
		}
		w.Close();
	}
	private void Done(object sender, Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
	{
		TabControl1.SelectedTab.Text = ((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).DocumentTitle;
		ComboBox1.Text = ((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).Url.ToString;
		//History
		if (ToolStripProgressBar1.Value == "0") {
			historyin();


		} else {
		}


	}



	private int mousex;
	private int mousey;

	private bool dragged = false;

	private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left == true) {
			dragged = true;
			mousex = e.X;
			mousey = e.Y;
		}
	}
	private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		if (dragged == true) {
			Point oo = new Point();
			oo.X = this.Location.X + (e.X - mousex);
			oo.Y = this.Location.Y + (e.Y - mousey);
			this.Location = oo;
			oo = null;
		}
	}
	private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left == true) {
			dragged = false;
		}
	}
	IO.StreamWriter w;
	private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
	{
		int i = 0;
		w = new IO.StreamWriter("C:\\CoderRevolt\\WebBrowser\\V1\\Bookmarks.gwbb");
		for (i = 0; i <= Bookmarks.ListBox1.Items.Count - 1; i++) {
			w.WriteLine(Bookmarks.ListBox1.Items.Item(i));
		}
		w.Close();

		this.Enabled = false;
		exit_page.Show();

	}

	private void Label1_Click(System.Object sender, System.EventArgs e)
	{
		this.Hide();
		exit_page.Show();

	}
	private void Button2_Click(System.Object sender, System.EventArgs e)
	{
		WebBrowser Browser = new WebBrowser();
		TabControl1.TabPages.Add("New Page");
		TabControl1.SelectTab(@int);
		Browser.Name = "Web Browser";
		Browser.Dock = DockStyle.Fill;
		TabControl1.SelectedTab.Controls.Add(Browser);
		Browser.ProgressChanged += Loading;
		Browser.DocumentCompleted += Done;
		@int = @int + 1;
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).GoHome();
	}
	private void Button3_Click(System.Object sender, System.EventArgs e)
	{
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).GoBack();
	}

	private void Form1_Load(System.Object sender, System.EventArgs e)
	{
		this.TopMost = true;
		WebBrowser Browser = new WebBrowser();
		TabControl1.TabPages.Add("New Page");
		Browser.Name = "Web Browser";
		Browser.Dock = DockStyle.Fill;
		TabControl1.SelectedTab.Controls.Add(Browser);
		Browser.ProgressChanged += Loading;
		Browser.DocumentCompleted += Done;
		@int = @int + 1;
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).Navigate("https://www.google.com");
		background.Start();

	}
	private void Button4_Click(System.Object sender, System.EventArgs e)
	{
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).GoForward();
	}
	private void Button5_Click(System.Object sender, System.EventArgs e)
	{
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).Refresh();
	}
	 datestring = System.DateTime.Now;
	private void background_Tick(System.Object sender, System.EventArgs e)
	{
		ToolStripStatusLabel1.Text = Strings.Format(Now, "hh:mm:ss tt") + " \\- -/ " + Strings.Format(datestring, "Long Date");
		try {
			ToolStripStatusLabel4.Text = ((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).StatusText;

		} catch (Exception ex) {
		}
	}

	private void Button6_Click(System.Object sender, System.EventArgs e)
	{
		if (RadioButton1.Checked == true) {
			((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).Navigate("http://www.google.co.uk/search?hl=en&q=" + ComboBox1.Text);

		}
		if (RadioButton3.Checked == true) {
			((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).Navigate("http://www.bing.com/search?q=" + ComboBox1.Text);

		}
		if (RadioButton2.Checked == true) {
			((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).Navigate(ComboBox1.Text);
			ComboBox1.Items.Add(ComboBox1.Text);
		}
	}

	private void PictureBox3_Click(System.Object sender, System.EventArgs e)
	{
		Process.Start("http://vysilhq.com/");
	}

	private void Label2_Click(System.Object sender, System.EventArgs e)
	{
		this.WindowState = FormWindowState.Minimized;
	}

	private void Button7_Click(System.Object sender, System.EventArgs e)
	{
		try {
			if (!(TabControl1.TabPages.Count == 1)) {
				TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex);
				TabControl1.SelectTab(TabControl1.TabPages.Count - 1);
				@int = @int - 1;
			}
		} catch (Exception ex) {
		}
	}


	private void ComboBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
	{
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).Navigate(ComboBox1.Text);
	}
	[DllImport("user32", EntryPoint = "GetAsyncKeyState", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]

	private static extern int GetKeyPress(int key);


	private void ComboBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
	{
		if (GetKeyPress(Keys.Enter)) {
			Button6.PerformClick();
		}

	}

	private void Label5_Click(System.Object sender, System.EventArgs e)
	{
		if (this.WindowState == FormWindowState.Normal) {
			this.WindowState = FormWindowState.Maximized;
			this.BackgroundImageLayout = ImageLayout.Stretch;
		} else {
			this.WindowState = FormWindowState.Normal;
			this.BackgroundImageLayout = ImageLayout.None;
		}
	}
	private void OrigToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		if (Find_Highlight_Tool.Visible == true) {
			Find_Highlight_Tool.Hide();
		} else {
			Find_Highlight_Tool.Show();
		}
	}
	private bool PanelMOVE = false;
	private Point PanelPOINT = new Point();
	private void Button8_Click(System.Object sender, System.EventArgs e)
	{
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).Stop();
	}

	private void PropertiesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).ShowPropertiesDialog();

	}

	private void PrintToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).ShowPrintDialog();
	}


	private void ToolStripMenuItem6_Click(System.Object sender, System.EventArgs e)
	{
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).ShowPrintPreviewDialog();
	}

	private void ToolStripMenuItem7_Click(System.Object sender, System.EventArgs e)
	{
		((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).ShowPrintDialog();
	}


	private void OpenSourceProjectToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		Process.Start("http://www.steveaura.com/");
	}


	private void ToolStripStatusLabel4_Click(System.Object sender, System.EventArgs e)
	{
	}


	private void ToolStripStatusLabel6_Click(System.Object sender, System.EventArgs e)
	{
	}


	private void RadioButton1_CheckedChanged(System.Object sender, System.EventArgs e)
	{
	}

	private void OptionsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		try {
			Interaction.Shell("rundll32.exe shell32.dll,Control_RunDLL inetcpl.cpl,,0", 5);
		} catch (Exception ex) {
			Interaction.MsgBox(ex.Message.ToString);
		}
	}

	private void ViewPageSourceToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		PageSource.Show();

	}



	private void ToolStripMenuItem2_Click(System.Object sender, System.EventArgs e)
	{
		Button7.PerformClick();
	}


	private void ToolStripMenuItem3_Click(System.Object sender, System.EventArgs e)
	{




	}

	private void AddToBookmarksToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		if (ComboBox1.Text.Contains("http") == true) {
			AddBookmark.Show();
			AddBookmark.TopMost = true;


		} else {
		}

	}

	private void ViewBookmarksToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		if (Bookmarks.Visible == true) {
			Bookmarks.Visible = false;
		} else {
			Bookmarks.Visible = true;

		}
	}

	private void ToolStripMenuItem5_Click(System.Object sender, System.EventArgs e)
	{
		if (Hist.Visible == true) {
			Hist.Hide();

		} else {
			Hist.Show();
		}

	}

	private void CopyToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		 // ERROR: Not supported in C#: OnErrorStatement

		My.Computer.Clipboard.SetText(((WebBrowser)TabControl1.SelectedTab.Controls.Item(0)).Document.Body.InnerText);

	}

	private void PasteToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		 // ERROR: Not supported in C#: OnErrorStatement

		ComboBox1.Text = Clipboard.GetText();

	}

	private void ToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
	{
		Button2.PerformClick();

	}

	private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
	{
		Process.Start("http://www.steveaura.com/");
	}
	public Main()
	{
		Load += Form1_Load;
		FormClosing += Form1_FormClosing;
		MouseUp += Form1_MouseUp;
		MouseMove += Form1_MouseMove;
		MouseDown += Form1_MouseDown;
	}
}