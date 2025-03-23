namespace DBS25P156.UI
{
    partial class AdminResultForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label12 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            BackToHome = new Label();
            result_id = new DataGridViewTextBoxColumn();
            event_id = new DataGridViewTextBoxColumn();
            participant_id = new DataGridViewTextBoxColumn();
            team_id = new DataGridViewTextBoxColumn();
            position = new DataGridViewComboBoxColumn();
            score = new DataGridViewTextBoxColumn();
            remarks = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font("Poppins Medium", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(468, 9);
            label12.Name = "label12";
            label12.Size = new Size(313, 80);
            label12.TabIndex = 26;
            label12.Text = "Event Result";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(46, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1098, 355);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Result Management";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { result_id, event_id, participant_id, team_id, position, score, remarks });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Size = new Size(1092, 319);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(492, 513);
            button1.Name = "button1";
            button1.Size = new Size(237, 38);
            button1.TabIndex = 32;
            button1.Text = "Update Result";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BackToHome
            // 
            BackToHome.AutoSize = true;
            BackToHome.BackColor = Color.Transparent;
            BackToHome.Cursor = Cursors.Hand;
            BackToHome.FlatStyle = FlatStyle.Flat;
            BackToHome.Font = new Font("Poppins", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            BackToHome.ForeColor = SystemColors.ButtonHighlight;
            BackToHome.Location = new Point(547, 554);
            BackToHome.Name = "BackToHome";
            BackToHome.Size = new Size(132, 30);
            BackToHome.TabIndex = 31;
            BackToHome.Text = "Back to Home";
            BackToHome.Click += BackToHome_Click;
            // 
            // result_id
            // 
            result_id.DataPropertyName = "result_id";
            result_id.HeaderText = "Result Id";
            result_id.MinimumWidth = 6;
            result_id.Name = "result_id";
            result_id.ReadOnly = true;
            result_id.Width = 140;
            // 
            // event_id
            // 
            event_id.DataPropertyName = "event_id";
            event_id.HeaderText = "Event Id";
            event_id.MinimumWidth = 6;
            event_id.Name = "event_id";
            event_id.ReadOnly = true;
            event_id.Width = 140;
            // 
            // participant_id
            // 
            participant_id.DataPropertyName = "participant_id";
            participant_id.HeaderText = "Participant Id";
            participant_id.MinimumWidth = 6;
            participant_id.Name = "participant_id";
            participant_id.ReadOnly = true;
            participant_id.Width = 195;
            // 
            // team_id
            // 
            team_id.DataPropertyName = "team_id";
            team_id.HeaderText = "Team Id";
            team_id.MinimumWidth = 6;
            team_id.Name = "team_id";
            team_id.ReadOnly = true;
            team_id.Width = 135;
            // 
            // position
            // 
            position.HeaderText = "Position";
            position.Items.AddRange(new object[] { "Winner", "Runner-up", "Finalist", "Participant" });
            position.MinimumWidth = 6;
            position.Name = "position";
            position.Width = 125;
            // 
            // score
            // 
            score.DataPropertyName = "score";
            score.HeaderText = "Score";
            score.MinimumWidth = 6;
            score.Name = "score";
            score.Width = 125;
            // 
            // remarks
            // 
            remarks.DataPropertyName = "remarks";
            remarks.HeaderText = "Remarks";
            remarks.MinimumWidth = 6;
            remarks.Name = "remarks";
            remarks.Width = 175;
            // 
            // AdminResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(1200, 609);
            Controls.Add(button1);
            Controls.Add(BackToHome);
            Controls.Add(groupBox1);
            Controls.Add(label12);
            Name = "AdminResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminResultForm";
            Load += AdminResultForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label BackToHome;
        private DataGridViewTextBoxColumn result_id;
        private DataGridViewTextBoxColumn event_id;
        private DataGridViewTextBoxColumn participant_id;
        private DataGridViewTextBoxColumn team_id;
        private DataGridViewComboBoxColumn position;
        private DataGridViewTextBoxColumn score;
        private DataGridViewTextBoxColumn remarks;
    }
}