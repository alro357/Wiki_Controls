{
		InitializeComponent();
		LinkLabel linkLabel = new LinkLabel();
		linkLabel.Text = "Institut Vidal i Barraquer";
		linkLabel.Links.Add(0, linkLabel.Text.Length, "https://www.vidalibarraquer.net/");
		linkLabel.LinkClicked += LinkLabel_LinkClicked;
		this.Controls.Add(linkLabel);
}

	private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
	}

