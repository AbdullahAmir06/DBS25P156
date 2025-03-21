namespace DBS25P156.UI
{
    partial class Vendor_SponserHomePage
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
            groupBox1 = new GroupBox();
            BackToLogin = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            Names = new Label();
            ContactTextBox = new TextBox();
            Contact = new Label();
            ServiceTypeTextBox = new TextBox();
            ServiceType = new Label();
            groupBox2 = new GroupBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BackToLogin);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(Names);
            groupBox1.Controls.Add(ContactTextBox);
            groupBox1.Controls.Add(Contact);
            groupBox1.Controls.Add(ServiceTypeTextBox);
            groupBox1.Controls.Add(ServiceType);
            groupBox1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(480, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vendor Registration";
            // 
            // BackToLogin
            // 
            BackToLogin.AutoSize = true;
            BackToLogin.BackColor = Color.Transparent;
            BackToLogin.Cursor = Cursors.Hand;
            BackToLogin.FlatStyle = FlatStyle.Flat;
            BackToLogin.Font = new Font("Poppins", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            BackToLogin.ForeColor = SystemColors.ButtonHighlight;
            BackToLogin.Location = new Point(165, 313);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(70, 30);
            BackToLogin.TabIndex = 0;
            BackToLogin.Text = "Logout";
            BackToLogin.Click += BackToLogin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(78, 268);
            button1.Name = "button1";
            button1.Size = new Size(241, 37);
            button1.TabIndex = 4;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.Font = new Font("Poppins", 10.2F);
            textBox3.ForeColor = SystemColors.ActiveCaptionText;
            textBox3.Location = new Point(17, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(375, 33);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // Names
            // 
            Names.BackColor = Color.Transparent;
            Names.Font = new Font("Poppins", 10.2F);
            Names.ForeColor = SystemColors.ButtonHighlight;
            Names.Location = new Point(17, 45);
            Names.Name = "Names";
            Names.Size = new Size(114, 30);
            Names.TabIndex = 34;
            Names.Text = "Name";
            // 
            // ContactTextBox
            // 
            ContactTextBox.BackColor = Color.LightGray;
            ContactTextBox.Font = new Font("Poppins", 10.2F);
            ContactTextBox.ForeColor = SystemColors.ActiveCaptionText;
            ContactTextBox.Location = new Point(17, 140);
            ContactTextBox.Name = "ContactTextBox";
            ContactTextBox.Size = new Size(375, 33);
            ContactTextBox.TabIndex = 2;
            ContactTextBox.TextChanged += ContactTextBox_TextChanged;
            ContactTextBox.Enter += ContactTextBox_Enter;
            ContactTextBox.Leave += ContactTextBox_Leave;
            // 
            // Contact
            // 
            Contact.BackColor = Color.Transparent;
            Contact.Font = new Font("Poppins", 10.2F);
            Contact.ForeColor = SystemColors.ButtonHighlight;
            Contact.Location = new Point(17, 111);
            Contact.Name = "Contact";
            Contact.Size = new Size(114, 30);
            Contact.TabIndex = 33;
            Contact.Text = "Contact";
            // 
            // ServiceTypeTextBox
            // 
            ServiceTypeTextBox.BackColor = Color.LightGray;
            ServiceTypeTextBox.Font = new Font("Poppins", 10.2F);
            ServiceTypeTextBox.ForeColor = SystemColors.ActiveCaptionText;
            ServiceTypeTextBox.Location = new Point(17, 207);
            ServiceTypeTextBox.Name = "ServiceTypeTextBox";
            ServiceTypeTextBox.Size = new Size(375, 33);
            ServiceTypeTextBox.TabIndex = 3;
            ServiceTypeTextBox.Enter += ServiceTypeTextBox_Enter;
            ServiceTypeTextBox.Leave += ServiceTypeTextBox_Leave;
            // 
            // ServiceType
            // 
            ServiceType.BackColor = Color.Transparent;
            ServiceType.Font = new Font("Poppins", 10.2F);
            ServiceType.ForeColor = SystemColors.ButtonHighlight;
            ServiceType.Location = new Point(17, 179);
            ServiceType.Name = "ServiceType";
            ServiceType.Size = new Size(150, 22);
            ServiceType.TabIndex = 32;
            ServiceType.Text = "Service Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(12, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(422, 518);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sponsor Registration";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LightGray;
            comboBox2.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(17, 280);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 31);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poppins", 10.2F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(17, 247);
            label6.Name = "label6";
            label6.Size = new Size(151, 30);
            label6.TabIndex = 39;
            label6.Text = "To Entity Name";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightGray;
            comboBox1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "User", "Committee", "Vendor" });
            comboBox1.Location = new Point(17, 213);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Poppins", 10.2F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(17, 180);
            label5.Name = "label5";
            label5.Size = new Size(133, 30);
            label5.TabIndex = 37;
            label5.Text = "To Entity Type";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.LightGray;
            numericUpDown1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(17, 350);
            numericUpDown1.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 30);
            numericUpDown1.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 10.2F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(17, 317);
            label4.Name = "label4";
            label4.Size = new Size(114, 30);
            label4.TabIndex = 35;
            label4.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Poppins", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(177, 481);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 0;
            label1.Text = "Logout";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(90, 435);
            button2.Name = "button2";
            button2.Size = new Size(241, 37);
            button2.TabIndex = 6;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Font = new Font("Poppins", 10.2F);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(17, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 33);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 10.2F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 45);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 34;
            label2.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.Font = new Font("Poppins", 10.2F);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(17, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(375, 33);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 10.2F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(17, 115);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 33;
            label3.Text = "Contact";
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
            // Vendor_SponserHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(800, 556);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Vendor_SponserHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendor_SponserHomePage";
            Load += Vendor_SponserHomePage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label Names;
        private TextBox ContactTextBox;
        private Label Contact;
        private TextBox ServiceTypeTextBox;
        private Label ServiceType;
        private Label BackToLogin;
        private Button button1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private GroupBox groupBox2;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
    }
}