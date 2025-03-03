namespace DBS25P156
{
    partial class ForgetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            label1 = new Label();
            groupBox1 = new GroupBox();
            BackToLogin = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(308, 25);
            label1.Name = "label1";
            label1.Size = new Size(148, 40);
            label1.TabIndex = 3;
            label1.Text = "Login Form";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(BackToLogin);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(193, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 280);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recover Your Password";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BackToLogin
            // 
            BackToLogin.AutoSize = true;
            BackToLogin.BackColor = Color.Transparent;
            BackToLogin.Cursor = Cursors.Hand;
            BackToLogin.FlatStyle = FlatStyle.Flat;
            BackToLogin.Font = new Font("Poppins", 9F, FontStyle.Underline);
            BackToLogin.ForeColor = SystemColors.ButtonHighlight;
            BackToLogin.Location = new Point(167, 239);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(111, 26);
            BackToLogin.TabIndex = 20;
            BackToLogin.Text = "Back to Login";
            BackToLogin.Click += BackToLogin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(20, 178);
            button2.Name = "button2";
            button2.Size = new Size(168, 37);
            button2.TabIndex = 19;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.Font = new Font("Poppins", 10.2F);
            textBox3.ForeColor = SystemColors.ActiveCaptionText;
            textBox3.Location = new Point(20, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(375, 33);
            textBox3.TabIndex = 1;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 7.8F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(20, 35);
            label4.Name = "label4";
            label4.Size = new Size(204, 24);
            label4.TabIndex = 18;
            label4.Text = "Username / Email";
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.LightGray;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Image = (Image)resources.GetObject("checkBox1.Image");
            checkBox1.ImageAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(243, 178);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(1);
            checkBox1.Size = new Size(152, 33);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Show Password          ";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.Font = new Font("Poppins", 10.2F);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(20, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(375, 33);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 7.8F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(20, 98);
            label3.Name = "label3";
            label3.Size = new Size(178, 22);
            label3.TabIndex = 14;
            label3.Text = "Enter New Password";
            label3.Click += label3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // ForgetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 408);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "ForgetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forget Password";
            Load += ForgetPasswordForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label4;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Button button2;
        private Label BackToLogin;
    }
}