namespace DBS25P156
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(204, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 349);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign In";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Poppins", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(115, 301);
            label2.Name = "label2";
            label2.Size = new Size(207, 26);
            label2.TabIndex = 6;
            label2.Text = "New User! Create Account";
            label2.Click += label2_Click_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Poppins", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(151, 273);
            label5.Name = "label5";
            label5.Size = new Size(135, 26);
            label5.TabIndex = 5;
            label5.Text = "forget password";
            label5.Click += label5_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = Color.LightGray;
            textBox3.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.ActiveCaptionText;
            textBox3.Location = new Point(20, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(372, 33);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Enter += textBox3_Enter_1;
            textBox3.Leave += textBox3_Leave_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 7.8F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(20, 36);
            label4.Name = "label4";
            label4.Size = new Size(201, 25);
            label4.TabIndex = 18;
            label4.Text = "Username / Email";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(84, 224);
            button1.Name = "button1";
            button1.Size = new Size(238, 38);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.LightGray;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Image = (Image)resources.GetObject("checkBox1.Image");
            checkBox1.ImageAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(238, 169);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(1);
            checkBox1.Size = new Size(152, 33);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Show Password          ";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.LightGray;
            textBox2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(20, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(372, 33);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter_1;
            textBox2.Leave += textBox2_Leave_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 7.8F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(20, 98);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(341, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 40);
            label1.TabIndex = 1;
            label1.Text = "Login Form";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(829, 472);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}



//namespace ITEC_Event_Management_System
//{
//    partial class LoginForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
//            groupBox1 = new GroupBox();
//            button1 = new Button();
//            comboBox1 = new ComboBox();
//            checkBox1 = new CheckBox();
//            textBox2 = new TextBox();
//            label3 = new Label();
//            textBox1 = new TextBox();
//            label2 = new Label();
//            label1 = new Label();
//            groupBox1.SuspendLayout();
//            SuspendLayout();
//            // 
//            // groupBox1
//            // 
//            groupBox1.Controls.Add(button1);
//            groupBox1.Controls.Add(comboBox1);
//            groupBox1.Controls.Add(checkBox1);
//            groupBox1.Controls.Add(textBox2);
//            groupBox1.Controls.Add(label3);
//            groupBox1.Controls.Add(textBox1);
//            groupBox1.Controls.Add(label2);
//            groupBox1.FlatStyle = FlatStyle.Flat;
//            groupBox1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            groupBox1.Location = new Point(390, 55);
//            groupBox1.Name = "groupBox1";
//            groupBox1.Size = new Size(387, 343);
//            groupBox1.TabIndex = 0;
//            groupBox1.TabStop = false;
//            groupBox1.Text = "Sign In";
//            groupBox1.Enter += groupBox1_Enter;
//            // 
//            // button1
//            // 
//            button1.BackColor = Color.White;
//            button1.FlatStyle = FlatStyle.Flat;
//            button1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            button1.ForeColor = Color.Black;
//            button1.Location = new Point(90, 218);
//            button1.Name = "button1";
//            button1.Size = new Size(241, 37);
//            button1.TabIndex = 8;
//            button1.Text = "Login";
//            button1.UseVisualStyleBackColor = false;
//            button1.Click += button1_Click;
//            // 
//            // comboBox1
//            // 
//            comboBox1.FlatStyle = FlatStyle.Flat;
//            comboBox1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            comboBox1.FormattingEnabled = true;
//            comboBox1.Items.AddRange(new object[] { "Faculty", "Student", "Sponsor", "Professional", "Guest Speaker", "Judge", "Faculty Advisor", "Student Lead", "Volunteer" });
//            comboBox1.Location = new Point(6, 175);
//            comboBox1.Name = "comboBox1";
//            comboBox1.Size = new Size(193, 31);
//            comboBox1.TabIndex = 7;
//            comboBox1.Text = "User Selection Role";
//            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
//            // 
//            // checkBox1
//            // 
//            checkBox1.Appearance = Appearance.Button;
//            checkBox1.AutoSize = true;
//            checkBox1.Cursor = Cursors.Hand;
//            checkBox1.FlatStyle = FlatStyle.Popup;
//            checkBox1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            checkBox1.Image = (Image)resources.GetObject("checkBox1.Image");
//            checkBox1.ImageAlign = ContentAlignment.MiddleRight;
//            checkBox1.Location = new Point(226, 173);
//            checkBox1.Name = "checkBox1";
//            checkBox1.Padding = new Padding(1);
//            checkBox1.Size = new Size(152, 33);
//            checkBox1.TabIndex = 6;
//            checkBox1.Text = "Show Password          ";
//            checkBox1.TextAlign = ContentAlignment.MiddleRight;
//            checkBox1.UseVisualStyleBackColor = true;
//            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
//            // 
//            // textBox2
//            // 
//            textBox2.Location = new Point(6, 128);
//            textBox2.Name = "textBox2";
//            textBox2.Size = new Size(375, 37);
//            textBox2.TabIndex = 3;
//            textBox2.UseSystemPasswordChar = true;
//            // 
//            // label3
//            // 
//            label3.FlatStyle = FlatStyle.Flat;
//            label3.Font = new Font("Poppins", 7.8F);
//            label3.Location = new Point(6, 106);
//            label3.Name = "label3";
//            label3.Size = new Size(81, 22);
//            label3.TabIndex = 2;
//            label3.Text = "Password";
//            // 
//            // textBox1
//            // 
//            textBox1.Location = new Point(6, 61);
//            textBox1.Name = "textBox1";
//            textBox1.Size = new Size(375, 37);
//            textBox1.TabIndex = 1;
//            // 
//            // label2
//            // 
//            label2.Font = new Font("Poppins", 7.8F);
//            label2.Location = new Point(6, 36);
//            label2.Name = "label2";
//            label2.Size = new Size(144, 24);
//            label2.TabIndex = 0;
//            label2.Text = "Username / Email";
//            label2.Click += label2_Click;
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            label1.Location = new Point(313, 12);
//            label1.Name = "label1";
//            label1.Size = new Size(148, 40);
//            label1.TabIndex = 1;
//            label1.Text = "Login Form";
//            // 
//            // LoginForm
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(803, 410);
//            Controls.Add(label1);
//            Controls.Add(groupBox1);
//            Name = "LoginForm";
//            Text = "Login Form";
//            Load += LoginForm_Load;
//            groupBox1.ResumeLayout(false);
//            groupBox1.PerformLayout();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private GroupBox groupBox1;
//        private Label label1;
//        private TextBox textBox2;
//        private Label label3;
//        private TextBox textBox1;
//        private Label label2;
//        private CheckBox checkBox1;
//        private ComboBox comboBox1;
//        private Button button1;
//    }
//}