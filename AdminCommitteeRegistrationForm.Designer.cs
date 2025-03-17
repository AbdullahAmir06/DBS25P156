namespace DBS25P156
{
    partial class AdminCommitteeRegistrationForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            Names = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Role = new DataGridViewComboBoxColumn();
            Duty = new DataGridViewTextBoxColumn();
            Deadline = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            GoBack = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GoBack);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(38, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 465);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Committee";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(26, 121);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(179, 40);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show Member";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Select, Names, Category, Role, Duty, Deadline });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.Location = new Point(17, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = "0";
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(10, 25, 47);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(852, 205);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Select
            // 
            Select.HeaderText = "Select";
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.Width = 125;
            // 
            // Names
            // 
            Names.HeaderText = "Name";
            Names.MinimumWidth = 6;
            Names.Name = "Names";
            Names.ReadOnly = true;
            Names.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 125;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.Items.AddRange(new object[] { "Faculty Advisor", "Student Lead", "Volunteer" });
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.Width = 125;
            // 
            // Duty
            // 
            Duty.HeaderText = "Duty";
            Duty.MinimumWidth = 6;
            Duty.Name = "Duty";
            Duty.Width = 125;
            // 
            // Deadline
            // 
            dataGridViewCellStyle9.Format = "f";
            dataGridViewCellStyle9.NullValue = null;
            Deadline.DefaultCellStyle = dataGridViewCellStyle9;
            Deadline.HeaderText = "Deadline";
            Deadline.MinimumWidth = 6;
            Deadline.Name = "Deadline";
            Deadline.Width = 175;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(17, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 33);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 38);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 0;
            label1.Text = "Committee Name";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(323, 385);
            button1.Name = "button1";
            button1.Size = new Size(238, 38);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            // 
            // GoBack
            // 
            GoBack.AutoSize = true;
            GoBack.BackColor = Color.Transparent;
            GoBack.Cursor = Cursors.Hand;
            GoBack.FlatStyle = FlatStyle.Flat;
            GoBack.Font = new Font("Poppins", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            GoBack.ForeColor = SystemColors.ButtonHighlight;
            GoBack.Location = new Point(405, 426);
            GoBack.Name = "GoBack";
            GoBack.Size = new Size(82, 30);
            GoBack.TabIndex = 6;
            GoBack.Text = "Go Back";
            GoBack.Click += GoBack_Click;
            // 
            // AdminCommitteeRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(986, 547);
            Controls.Add(groupBox1);
            Name = "AdminCommitteeRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCommitteeRegistrationForm";
            Load += AdminCommitteeRegistrationForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewComboBoxColumn Role;
        private DataGridViewTextBoxColumn Duty;
        private DataGridViewTextBoxColumn Deadline;
        private CheckBox checkBox1;
        private Button button1;
        private Label GoBack;
    }
}