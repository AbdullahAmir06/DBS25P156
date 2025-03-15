namespace DBS25P156
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
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
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
            groupBox1.Location = new Point(203, 34);
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
            // Vendor_SponserHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Vendor_SponserHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendor_SponserHomePage";
            Load += Vendor_SponserHomePage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
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
    }
}