namespace GetWorkDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddDato_Click(object sender, EventArgs e)
        {
            DateTime dateTime = this.dateTimePickeradd.Value.Date;
            this.listBoxDato.Items.Add(dateTime);
        }

        private void buttonAddEvertName_Click(object sender, EventArgs e)
        {
            this.listBoxevertname.Items.Add(this.textBoxEvertName.Text);
        }

        private void listBoxDato_SelectedIndexChanged(dynamic sender, EventArgs e)
        {
            int SelectedIndex = sender.SelectedIndex;
            if (SelectedIndex != -1)
                this.listBoxDato.Items.RemoveAt(SelectedIndex);
        }

        private void listBoxevertname_SelectedIndexChanged(dynamic sender, EventArgs e)
        {
            int SelectedIndex = sender.SelectedIndex;
            if (SelectedIndex != -1)
                this.listBoxevertname.Items.RemoveAt(SelectedIndex);
        }
    }
}