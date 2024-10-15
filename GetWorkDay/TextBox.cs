using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GetWorkDay
{
    public partial class TextBox : Form
    {
        private icalRead icalRead;
        public string path;
        public bool notClick = false;

        public TextBox(icalRead icalRead = null, string text = "")
        {
            InitializeComponent();
            this.icalRead = icalRead;
            this.label1.Text = text;
        }

        private void buttonGetFile_Click(object sender, EventArgs e)
        {
            string url = this.textBoxurlorfile.Text;

            if (url != "")
            {
                bool isok = false;

                if (this.icalRead != null)
                    isok = this.icalRead.ReadGoogle(url);
                else
                {

                    this.path = url;
                    if (this.path != "")
                        isok = true;

                }

                if (isok)
                {
                    notClick = true;
                    this.Close();
                }

                this.labelErorr.Text = "Erorr can not read file";

            }
        }
    }
}
