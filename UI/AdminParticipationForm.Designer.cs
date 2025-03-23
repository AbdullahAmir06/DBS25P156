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
            dataGridView1 = new DataGridView();
            RegistrationNumber = new DataGridViewTextBoxColumn();
            EventId = new DataGridViewTextBoxColumn();
            ParticipantId = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewComboBoxColumn();
            FeeAmount = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            BackToHome.Location = new Point(450, 514);
            BackToHome.Name = "BackToHome";
            BackToHome.Size = new Size(132, 30);
            BackToHome.TabIndex = 28;
            BackToHome.Text = "Back to Home";
            BackToHome.Click += BackToHome_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RegistrationNumber, EventId, ParticipantId, Payment, FeeAmount });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(63, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            dataGridView1.Size = new Size(819, 310);
            dataGridView1.TabIndex = 29;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // RegistrationNumber
            // 
            RegistrationNumber.DataPropertyName = "registration_id";
            RegistrationNumber.HeaderText = "Registration ID";
            RegistrationNumber.MinimumWidth = 6;
            RegistrationNumber.Name = "RegistrationNumber";
            RegistrationNumber.ReadOnly = true;
            RegistrationNumber.Width = 210;
            // 
            // EventId
            // 
            EventId.DataPropertyName = "event_id";
            EventId.HeaderText = "Event Id";
            EventId.MinimumWidth = 6;
            EventId.Name = "EventId";
            EventId.ReadOnly = true;
            EventId.Width = 135;
            // 
            // ParticipantId
            // 
            ParticipantId.DataPropertyName = "participant_id";
            ParticipantId.HeaderText = "Participant Id";
            ParticipantId.MinimumWidth = 6;
            ParticipantId.Name = "ParticipantId";
            ParticipantId.ReadOnly = true;
            ParticipantId.Width = 195;
            // 
            // Payment
            // 
            Payment.DataPropertyName = "value";
            Payment.HeaderText = "Payment";
            Payment.Items.AddRange(new object[] { "Pending", "Canceled" });
            Payment.MinimumWidth = 6;
            Payment.Name = "Payment";
            Payment.Width = 125;
            // 
            // FeeAmount
            // 
            FeeAmount.DataPropertyName = "fee_amount";
            FeeAmount.HeaderText = "Fee";
            FeeAmount.MinimumWidth = 6;
            FeeAmount.Name = "FeeAmount";
            FeeAmount.ReadOnly = true;
            FeeAmount.Width = 125;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(395, 473);
            button1.Name = "button1";
            button1.Size = new Size(237, 38);
            button1.TabIndex = 30;
            button1.Text = "Update Registrations";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminParticipationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(964, 570);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(BackToHome);
            Controls.Add(label12);
            Name = "AdminParticipationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminParticipationForm";
            Load += AdminParticipationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label BackToHome;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RegistrationNumber;
        private DataGridViewTextBoxColumn EventId;
        private DataGridViewTextBoxColumn ParticipantId;
        private DataGridViewComboBoxColumn Payment;
        private DataGridViewTextBoxColumn FeeAmount;
        private Button button1;
    }
}