

namespace GetWorkDay
{
    public partial class Form1 : Form
    {
        private icalRead icalRead;

        public Form1()
        {
            InitializeComponent();
            this.icalRead = new icalRead();
            this.buttonMakePdf.Enabled = true;

        }

        private void buttonAddDato_Click(object sender, EventArgs e)
        {
            DateTime dateTime = this.dateTimePickeradd.Value.Date;
            this.listBoxDato.Items.Add(dateTime);
        }

        private void buttonAddEvertName_Click(object sender, EventArgs e)
        {
            this.listBoxevertname.Items.Add(this.textBoxAddEvertName.Text);
            this.textBoxAddEvertName.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBoxWorkHome.Items.Add(this.textBoxWorkHome.Text);
            this.textBoxWorkHome.Text = "";

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

        private void listBoxWorkHome_SelectedIndexChanged(dynamic sender, EventArgs e)
        {
            int SelectedIndex = sender.SelectedIndex;
            if (SelectedIndex != -1)
                this.listBoxWorkHome.Items.RemoveAt(SelectedIndex);

        }


        private void buttonIclurl_Click(object sender, EventArgs e)
        {

            TextBox textBox = new TextBox(icalRead);
            textBox.ShowDialog();

            if (icalRead.calendarEvent.Count > 0)
                this.buttonMakePdf.Enabled = true;
            else
                this.buttonMakePdf.Enabled = false;
        }

        private void buttonMakePdf_Click(object sender, EventArgs e)
        {
            DateTime start = this.dateTimePickerFra.Value;
            DateTime end = this.dateTimePickerTil.Value;
            List<DateTime> DatoNotWork = listBoxDato.Items.Cast<DateTime>().ToList();
            List<string> EvertnameNotWork = this.listBoxevertname.Items.Cast<string>().ToList();
            List<string> EvertnameWokeHome = this.listBoxWorkHome.Items.Cast<string>().ToList();
            List<bool> weekDay = new List<bool> { !this.checkBoxsøndag.Checked,!this.checkBoxmandag.Checked, !this.checkBoxtirsdag.Checked , !this.checkBoxonsdag.Checked, !this.checkBoxtorsdag.Checked, !this.checkBoxfredag.Checked, !this.checkBoxlørdag.Checked };

            new findWorkDays(this.icalRead).StartGernarePdf(start, end, DatoNotWork, EvertnameNotWork, EvertnameWokeHome, weekDay);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}