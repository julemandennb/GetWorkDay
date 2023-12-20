namespace GetWorkDay
{
    partial class TextBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxurlorfile = new System.Windows.Forms.TextBox();
            label1 = new Label();
            labelErorr = new Label();
            buttonGetFile = new Button();
            SuspendLayout();
            // 
            // textBoxurlorfile
            // 
            textBoxurlorfile.Location = new Point(12, 34);
            textBoxurlorfile.Name = "textBoxurlorfile";
            textBoxurlorfile.Size = new Size(406, 23);
            textBoxurlorfile.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 1;
            label1.Text = "url or paht to file ical";
            // 
            // labelErorr
            // 
            labelErorr.AutoSize = true;
            labelErorr.Location = new Point(12, 60);
            labelErorr.Name = "labelErorr";
            labelErorr.Size = new Size(0, 15);
            labelErorr.TabIndex = 2;
            // 
            // buttonGetFile
            // 
            buttonGetFile.Location = new Point(397, 67);
            buttonGetFile.Name = "buttonGetFile";
            buttonGetFile.Size = new Size(75, 23);
            buttonGetFile.TabIndex = 3;
            buttonGetFile.Text = "Get file";
            buttonGetFile.UseVisualStyleBackColor = true;
            buttonGetFile.Click += buttonGetFile_Click;
            // 
            // TextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 102);
            Controls.Add(buttonGetFile);
            Controls.Add(labelErorr);
            Controls.Add(label1);
            Controls.Add(textBoxurlorfile);
            Name = "TextBox";
            Text = "TextBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxurlorfile;
        private Label label1;
        private Label labelErorr;
        private Button buttonGetFile;
    }
}