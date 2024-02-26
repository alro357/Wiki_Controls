    public partial class Form1 : Form
    {
        ListBox lista = new ListBox();

        public Form1()
        {
            InitializeComponent();
            lista.SelectionMode = SelectionMode.MultiExtended;
            lista.Items.Add("Barcelona");
            lista.Items.Add("Tarragona");
            lista.Items.Add("Madrid");
            Controls.Add(lista);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
