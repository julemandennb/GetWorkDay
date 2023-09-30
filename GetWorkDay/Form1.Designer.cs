namespace GetWorkDay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dateTimePickerFra = new DateTimePicker();
            dateTimePickerTil = new DateTimePicker();
            listBoxDato = new ListBox();
            label3 = new Label();
            dateTimePickeradd = new DateTimePicker();
            buttonAddDato = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            checkBoxsøndag = new CheckBox();
            label4 = new Label();
            checkBoxlørdag = new CheckBox();
            checkBoxmandag = new CheckBox();
            checkBoxfredag = new CheckBox();
            checkBoxonsdag = new CheckBox();
            checkBoxtorsdag = new CheckBox();
            checkBoxtirsdag = new CheckBox();
            groupBox4 = new GroupBox();
            listBoxevertname = new ListBox();
            buttonAddEvertName = new Button();
            textBoxEvertName = new TextBox();
            label5 = new Label();
            buttonGoogle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(135, 17);
            label1.Name = "label1";
            label1.Size = new Size(54, 46);
            label1.TabIndex = 0;
            label1.Text = "Til";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 17);
            label2.Name = "label2";
            label2.Size = new Size(66, 46);
            label2.TabIndex = 1;
            label2.Text = "Fra";
            // 
            // dateTimePickerFra
            // 
            dateTimePickerFra.Location = new Point(6, 66);
            dateTimePickerFra.Name = "dateTimePickerFra";
            dateTimePickerFra.Size = new Size(123, 23);
            dateTimePickerFra.TabIndex = 2;
            // 
            // dateTimePickerTil
            // 
            dateTimePickerTil.Location = new Point(135, 64);
            dateTimePickerTil.Name = "dateTimePickerTil";
            dateTimePickerTil.Size = new Size(125, 23);
            dateTimePickerTil.TabIndex = 3;
            // 
            // listBoxDato
            // 
            listBoxDato.FormattingEnabled = true;
            listBoxDato.ItemHeight = 15;
            listBoxDato.Location = new Point(144, 64);
            listBoxDato.Name = "listBoxDato";
            listBoxDato.Size = new Size(91, 109);
            listBoxDato.TabIndex = 4;
            listBoxDato.SelectedIndexChanged += listBoxDato_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 19);
            label3.Name = "label3";
            label3.Size = new Size(241, 37);
            label3.TabIndex = 5;
            label3.Text = "Dato ikke skal med";
            // 
            // dateTimePickeradd
            // 
            dateTimePickeradd.Location = new Point(6, 97);
            dateTimePickeradd.Name = "dateTimePickeradd";
            dateTimePickeradd.Size = new Size(132, 23);
            dateTimePickeradd.TabIndex = 6;
            // 
            // buttonAddDato
            // 
            buttonAddDato.Location = new Point(6, 68);
            buttonAddDato.Name = "buttonAddDato";
            buttonAddDato.Size = new Size(75, 23);
            buttonAddDato.TabIndex = 7;
            buttonAddDato.Text = "Add til list";
            buttonAddDato.UseVisualStyleBackColor = true;
            buttonAddDato.Click += buttonAddDato_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerTil);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePickerFra);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 109);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxDato);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(buttonAddDato);
            groupBox2.Controls.Add(dateTimePickeradd);
            groupBox2.Location = new Point(289, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 185);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxsøndag);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(checkBoxlørdag);
            groupBox3.Controls.Add(checkBoxmandag);
            groupBox3.Controls.Add(checkBoxfredag);
            groupBox3.Controls.Add(checkBoxonsdag);
            groupBox3.Controls.Add(checkBoxtorsdag);
            groupBox3.Controls.Add(checkBoxtirsdag);
            groupBox3.Location = new Point(15, 121);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(154, 208);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false; 
            // 
            // checkBoxsøndag
            // 
            checkBoxsøndag.AutoSize = true;
            checkBoxsøndag.Location = new Point(6, 177);
            checkBoxsøndag.Name = "checkBoxsøndag";
            checkBoxsøndag.Size = new Size(65, 19);
            checkBoxsøndag.TabIndex = 16;
            checkBoxsøndag.Text = "søndag";
            checkBoxsøndag.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 15);
            label4.Name = "label4";
            label4.Size = new Size(155, 46);
            label4.TabIndex = 0;
            label4.Text = "weekend";
            // 
            // checkBoxlørdag
            // 
            checkBoxlørdag.AutoSize = true;
            checkBoxlørdag.Location = new Point(6, 157);
            checkBoxlørdag.Name = "checkBoxlørdag";
            checkBoxlørdag.Size = new Size(60, 19);
            checkBoxlørdag.TabIndex = 15;
            checkBoxlørdag.Text = "lørdag";
            checkBoxlørdag.UseVisualStyleBackColor = true;
            // 
            // checkBoxmandag
            // 
            checkBoxmandag.AutoSize = true;
            checkBoxmandag.Location = new Point(6, 64);
            checkBoxmandag.Name = "checkBoxmandag";
            checkBoxmandag.Size = new Size(70, 19);
            checkBoxmandag.TabIndex = 1;
            checkBoxmandag.Text = "mandag";
            checkBoxmandag.UseVisualStyleBackColor = true;
            // 
            // checkBoxfredag
            // 
            checkBoxfredag.AutoSize = true;
            checkBoxfredag.Location = new Point(6, 138);
            checkBoxfredag.Name = "checkBoxfredag";
            checkBoxfredag.Size = new Size(60, 19);
            checkBoxfredag.TabIndex = 14;
            checkBoxfredag.Text = "fredag";
            checkBoxfredag.UseVisualStyleBackColor = true;
            // 
            // checkBoxonsdag
            // 
            checkBoxonsdag.AutoSize = true;
            checkBoxonsdag.Location = new Point(6, 102);
            checkBoxonsdag.Name = "checkBoxonsdag";
            checkBoxonsdag.Size = new Size(65, 19);
            checkBoxonsdag.TabIndex = 12;
            checkBoxonsdag.Text = "onsdag";
            checkBoxonsdag.UseVisualStyleBackColor = true;
            // 
            // checkBoxtorsdag
            // 
            checkBoxtorsdag.AutoSize = true;
            checkBoxtorsdag.Location = new Point(6, 120);
            checkBoxtorsdag.Name = "checkBoxtorsdag";
            checkBoxtorsdag.Size = new Size(66, 19);
            checkBoxtorsdag.TabIndex = 13;
            checkBoxtorsdag.Text = "torsdag";
            checkBoxtorsdag.UseVisualStyleBackColor = true;
            // 
            // checkBoxtirsdag
            // 
            checkBoxtirsdag.AutoSize = true;
            checkBoxtirsdag.Location = new Point(6, 82);
            checkBoxtirsdag.Name = "checkBoxtirsdag";
            checkBoxtirsdag.Size = new Size(62, 19);
            checkBoxtirsdag.TabIndex = 11;
            checkBoxtirsdag.Text = "tirsdag";
            checkBoxtirsdag.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBoxevertname);
            groupBox4.Controls.Add(buttonAddEvertName);
            groupBox4.Controls.Add(textBoxEvertName);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(289, 203);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(245, 189);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            // 
            // listBoxevertname
            // 
            listBoxevertname.FormattingEnabled = true;
            listBoxevertname.ItemHeight = 15;
            listBoxevertname.Location = new Point(144, 62);
            listBoxevertname.Name = "listBoxevertname";
            listBoxevertname.Size = new Size(91, 109);
            listBoxevertname.TabIndex = 8;
            listBoxevertname.SelectedIndexChanged += listBoxevertname_SelectedIndexChanged;
            // 
            // buttonAddEvertName
            // 
            buttonAddEvertName.Location = new Point(27, 67);
            buttonAddEvertName.Name = "buttonAddEvertName";
            buttonAddEvertName.Size = new Size(75, 23);
            buttonAddEvertName.TabIndex = 8;
            buttonAddEvertName.Text = "Add til list";
            buttonAddEvertName.UseVisualStyleBackColor = true;
            buttonAddEvertName.Click += buttonAddEvertName_Click;
            // 
            // textBoxEvertName
            // 
            textBoxEvertName.Location = new Point(6, 96);
            textBoxEvertName.Name = "textBoxEvertName";
            textBoxEvertName.Size = new Size(117, 23);
            textBoxEvertName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 26);
            label5.Name = "label5";
            label5.Size = new Size(216, 25);
            label5.TabIndex = 8;
            label5.Text = "evert nave ikke skal med";
            // 
            // buttonGoogle
            // 
            buttonGoogle.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGoogle.Location = new Point(8, 341);
            buttonGoogle.Name = "buttonGoogle";
            buttonGoogle.Size = new Size(158, 23);
            buttonGoogle.TabIndex = 10;
            buttonGoogle.Text = "google credentials File upload";
            buttonGoogle.UseVisualStyleBackColor = true;
            buttonGoogle.Click += buttonGoogle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(buttonGoogle);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerFra;
        private DateTimePicker dateTimePickerTil;
        private ListBox listBoxDato;
        private Label label3;
        private DateTimePicker dateTimePickeradd;
        private Button buttonAddDato;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox checkBoxsøndag;
        private Label label4;
        private CheckBox checkBoxlørdag;
        private CheckBox checkBoxmandag;
        private CheckBox checkBoxfredag;
        private CheckBox checkBoxonsdag;
        private CheckBox checkBoxtorsdag;
        private CheckBox checkBoxtirsdag;
        private GroupBox groupBox4;
        private Button buttonAddEvertName;
        private TextBox textBoxEvertName;
        private Label label5;
        private ListBox listBoxevertname;
        private Button buttonGoogle;
    }
}