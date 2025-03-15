namespace DBS25P156
{
    partial class EventRegistrationForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            ContactTextBox = new TextBox();
            Contact = new Label();
            BackToLogin = new Label();
            InstituteTextBox = new TextBox();
            Institute = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            RegisterAs = new Label();
            textBox3 = new TextBox();
            NameOfStudent = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Fee = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            errorProvider7 = new ErrorProvider(components);
            errorProvider8 = new ErrorProvider(components);
            errorProvider9 = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider9).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(278, 19);
            label1.Name = "label1";
            label1.Size = new Size(299, 40);
            label1.TabIndex = 3;
            label1.Text = "Event Registration Form";
            // 
            // ContactTextBox
            // 
            ContactTextBox.BackColor = Color.LightGray;
            ContactTextBox.Font = new Font("Poppins", 10.2F);
            ContactTextBox.ForeColor = SystemColors.ActiveCaptionText;
            ContactTextBox.Location = new Point(20, 129);
            ContactTextBox.Name = "ContactTextBox";
            ContactTextBox.Size = new Size(375, 33);
            ContactTextBox.TabIndex = 2;
            ContactTextBox.Enter += ContactTextBox_Enter;
            ContactTextBox.Leave += ContactTextBox_Leave;
            // 
            // Contact
            // 
            Contact.BackColor = Color.Transparent;
            Contact.Font = new Font("Poppins", 10.2F);
            Contact.ForeColor = SystemColors.ButtonHighlight;
            Contact.Location = new Point(20, 100);
            Contact.Name = "Contact";
            Contact.Size = new Size(114, 30);
            Contact.TabIndex = 22;
            Contact.Text = "Contact";
            Contact.Click += Email_Click;
            // 
            // BackToLogin
            // 
            BackToLogin.AutoSize = true;
            BackToLogin.BackColor = Color.Transparent;
            BackToLogin.Cursor = Cursors.Hand;
            BackToLogin.FlatStyle = FlatStyle.Flat;
            BackToLogin.Font = new Font("Poppins", 9F, FontStyle.Underline);
            BackToLogin.ForeColor = SystemColors.ButtonHighlight;
            BackToLogin.Location = new Point(160, 717);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(104, 26);
            BackToLogin.TabIndex = 0;
            BackToLogin.Text = "Go To Home";
            BackToLogin.Click += BackToLogin_Click;
            // 
            // InstituteTextBox
            // 
            InstituteTextBox.BackColor = Color.LightGray;
            InstituteTextBox.Font = new Font("Poppins", 10.2F);
            InstituteTextBox.ForeColor = SystemColors.ActiveCaptionText;
            InstituteTextBox.Location = new Point(20, 193);
            InstituteTextBox.Name = "InstituteTextBox";
            InstituteTextBox.Size = new Size(375, 33);
            InstituteTextBox.TabIndex = 3;
            InstituteTextBox.Enter += InstituteTextBox_Enter;
            InstituteTextBox.Leave += InstituteTextBox_Leave;
            // 
            // Institute
            // 
            Institute.BackColor = Color.Transparent;
            Institute.Font = new Font("Poppins", 10.2F);
            Institute.ForeColor = SystemColors.ButtonHighlight;
            Institute.Location = new Point(20, 165);
            Institute.Name = "Institute";
            Institute.Size = new Size(150, 22);
            Institute.TabIndex = 18;
            Institute.Text = "Institute";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(82, 668);
            button1.Name = "button1";
            button1.Size = new Size(241, 37);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(RegisterAs);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(NameOfStudent);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(Fee);
            groupBox2.Controls.Add(ContactTextBox);
            groupBox2.Controls.Add(Contact);
            groupBox2.Controls.Add(BackToLogin);
            groupBox2.Controls.Add(InstituteTextBox);
            groupBox2.Controls.Add(Institute);
            groupBox2.Controls.Add(button1);
            groupBox2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(266, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(437, 749);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registration";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.LightGray;
            textBox7.Font = new Font("Poppins", 10.2F);
            textBox7.ForeColor = SystemColors.ActiveCaptionText;
            textBox7.Location = new Point(20, 541);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(375, 33);
            textBox7.TabIndex = 39;
            textBox7.Visible = false;
            textBox7.Enter += textBox7_Enter;
            textBox7.Leave += textBox7_Leave;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Poppins", 10.2F);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(20, 513);
            label10.Name = "label10";
            label10.Size = new Size(150, 22);
            label10.TabIndex = 40;
            label10.Text = "Team Name";
            label10.Visible = false;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(20, 290);
            label9.Name = "label9";
            label9.Size = new Size(150, 30);
            label9.TabIndex = 38;
            label9.Text = "Participant 2:";
            label9.Visible = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGray;
            textBox4.Font = new Font("Poppins", 10.2F);
            textBox4.ForeColor = SystemColors.ActiveCaptionText;
            textBox4.Location = new Point(20, 353);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(375, 33);
            textBox4.TabIndex = 32;
            textBox4.Visible = false;
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poppins", 10.2F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(20, 324);
            label6.Name = "label6";
            label6.Size = new Size(114, 30);
            label6.TabIndex = 37;
            label6.Text = "Name";
            label6.Visible = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightGray;
            textBox5.Font = new Font("Poppins", 10.2F);
            textBox5.ForeColor = SystemColors.ActiveCaptionText;
            textBox5.Location = new Point(20, 419);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(375, 33);
            textBox5.TabIndex = 33;
            textBox5.Visible = false;
            textBox5.Enter += textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Poppins", 10.2F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(20, 386);
            label7.Name = "label7";
            label7.Size = new Size(114, 30);
            label7.TabIndex = 36;
            label7.Text = "Contact";
            label7.Visible = false;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightGray;
            textBox6.Font = new Font("Poppins", 10.2F);
            textBox6.ForeColor = SystemColors.ActiveCaptionText;
            textBox6.Location = new Point(20, 479);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(375, 33);
            textBox6.TabIndex = 34;
            textBox6.Visible = false;
            textBox6.Enter += textBox6_Enter;
            textBox6.Leave += textBox6_Leave;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Poppins", 10.2F);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(20, 451);
            label8.Name = "label8";
            label8.Size = new Size(150, 22);
            label8.TabIndex = 35;
            label8.Text = "Institute";
            label8.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightGray;
            comboBox1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Solo", "Team(2)" });
            comboBox1.Location = new Point(20, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 31);
            comboBox1.TabIndex = 31;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Enter += comboBox1_Enter;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // RegisterAs
            // 
            RegisterAs.BackColor = Color.Transparent;
            RegisterAs.Font = new Font("Poppins", 10.2F);
            RegisterAs.ForeColor = SystemColors.ButtonHighlight;
            RegisterAs.Location = new Point(20, 229);
            RegisterAs.Name = "RegisterAs";
            RegisterAs.Size = new Size(150, 24);
            RegisterAs.TabIndex = 30;
            RegisterAs.Text = "Register As";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.Font = new Font("Poppins", 10.2F);
            textBox3.ForeColor = SystemColors.ActiveCaptionText;
            textBox3.Location = new Point(20, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(375, 33);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.MouseEnter += textBox3_MouseEnter;
            textBox3.MouseHover += textBox3_MouseLeave;
            // 
            // NameOfStudent
            // 
            NameOfStudent.BackColor = Color.Transparent;
            NameOfStudent.Font = new Font("Poppins", 10.2F);
            NameOfStudent.ForeColor = SystemColors.ButtonHighlight;
            NameOfStudent.Location = new Point(20, 38);
            NameOfStudent.Name = "NameOfStudent";
            NameOfStudent.Size = new Size(114, 30);
            NameOfStudent.TabIndex = 28;
            NameOfStudent.Text = "Name";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(129, 627);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 34);
            radioButton2.TabIndex = 26;
            radioButton2.Text = "Paid";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged_1;
            radioButton2.Enter += radioButton1_Enter;
            radioButton2.Leave += radioButton1_Leave;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(20, 627);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 34);
            radioButton1.TabIndex = 4;
            radioButton1.Text = "Pending";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.VisibleChanged += radioButton1_VisibleChanged;
            radioButton1.Click += radioButton1_Click;
            radioButton1.Enter += radioButton1_Enter;
            radioButton1.Leave += radioButton1_Leave;
            // 
            // Fee
            // 
            Fee.BackColor = Color.Transparent;
            Fee.Font = new Font("Poppins", 10.2F);
            Fee.ForeColor = SystemColors.ButtonHighlight;
            Fee.Location = new Point(20, 587);
            Fee.Name = "Fee";
            Fee.Size = new Size(191, 37);
            Fee.TabIndex = 24;
            Fee.Text = "Fee: 500";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            errorProvider8.ContainerControl = this;
            // 
            // errorProvider9
            // 
            errorProvider9.ContainerControl = this;
            // 
            // EventRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(845, 840);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Name = "EventRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventRegistrationForm";
            Load += EventRegistrationForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider8).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ContactTextBox;
        private Label Contact;
        private Label BackToLogin;
        private TextBox InstituteTextBox;
        private Label Institute;
        private Button button1;
        private GroupBox groupBox2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private Label Fee;
        private ErrorProvider errorProvider4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox3;
        private Label NameOfStudent;
        private Label RegisterAs;
        private ComboBox comboBox1;
        private ErrorProvider errorProvider5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private Label label9;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private ErrorProvider errorProvider8;
        private TextBox textBox7;
        private Label label10;
        private ErrorProvider errorProvider9;
    }
}