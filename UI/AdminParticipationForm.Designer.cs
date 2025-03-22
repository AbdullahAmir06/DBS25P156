namespace DBS25P156.UI
{
    partial class AdminParticipationForm
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
            BackToHome = new Label();
            dataGridView2 = new DataGridView();
            Registration_id = new DataGridViewTextBoxColumn();
            event_id = new DataGridViewTextBoxColumn();
            Participant_id = new DataGridViewTextBoxColumn();
            payment_status_id = new DataGridViewComboBoxColumn();
            fee_amount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font("Poppins Medium", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(150, 9);
            label12.Name = "label12";
            label12.Size = new Size(672, 80);
            label12.TabIndex = 26;
            label12.Text = "Participation Status Update";
            // 
            // BackToHome
            // 
            BackToHome.AutoSize = true;
            BackToHome.BackColor = Color.Transparent;
            BackToHome.Cursor = Cursors.Hand;
            BackToHome.FlatStyle = FlatStyle.Flat;
            BackToHome.Font = new Font("Poppins", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            BackToHome.ForeColor = SystemColors.ButtonHighlight;
            BackToHome.Location = new Point(432, 453);
            BackToHome.Name = "BackToHome";
            BackToHome.Size = new Size(132, 30);
            BackToHome.TabIndex = 28;
            BackToHome.Text = "Back to Home";
            BackToHome.Click += BackToHome_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Registration_id, event_id, Participant_id, payment_status_id, fee_amount });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Location = new Point(51, 153);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(859, 268);
            dataGridView2.TabIndex = 29;
            dataGridView2.CurrentCellDirtyStateChanged += DataGridView1_CurrentCellDirtyStateChanged;
            dataGridView2.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // Registration_id
            // 
            Registration_id.DataPropertyName = "registration_id";
            Registration_id.HeaderText = "Registration Id";
            Registration_id.MinimumWidth = 6;
            Registration_id.Name = "Registration_id";
            Registration_id.Width = 210;
            // 
            // event_id
            // 
            event_id.DataPropertyName = "registration_id";
            event_id.HeaderText = "Event Id";
            event_id.MinimumWidth = 6;
            event_id.Name = "event_id";
            event_id.ReadOnly = true;
            event_id.Width = 140;
            // 
            // Participant_id
            // 
            Participant_id.DataPropertyName = "participant_id";
            Participant_id.HeaderText = "Participant Id";
            Participant_id.MinimumWidth = 6;
            Participant_id.Name = "Participant_id";
            Participant_id.ReadOnly = true;
            Participant_id.Width = 200;
            // 
            // payment_status_id
            // 
            payment_status_id.DataPropertyName = "Value";
            payment_status_id.HeaderText = "Payment";
            //payment_status_id.Items.AddRange(new object[] { "Faculty Advisor", "Student Lead", "Volunteer" });
            payment_status_id.MinimumWidth = 6;
            payment_status_id.Name = "payment_status_id";
            payment_status_id.ReadOnly = true;
            payment_status_id.Width = 155;
            // 
            // fee_amount
            // 
            fee_amount.DataPropertyName = "fee_amount";
            fee_amount.HeaderText = "Fee";
            fee_amount.MinimumWidth = 6;
            fee_amount.Name = "fee_amount";
            fee_amount.ReadOnly = true;
            fee_amount.Width = 125;
            // 
            // AdminParticipationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(964, 570);
            Controls.Add(dataGridView2);
            Controls.Add(BackToHome);
            Controls.Add(label12);
            Name = "AdminParticipationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminParticipationForm";
            Load += AdminParticipationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label BackToHome;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Registration_id;
        private DataGridViewTextBoxColumn event_id;
        private DataGridViewTextBoxColumn Participant_id;
        private DataGridViewComboBoxColumn payment_status_id;
        private DataGridViewTextBoxColumn fee_amount;
    }
}