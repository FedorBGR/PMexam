namespace PMexam
{
    partial class ApplicantDashboardForm
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
            lblFullName = new Label();
            lblStatus = new Label();
            labelStatus1 = new Label();
            lblComment = new Label();
            btnRefresh = new Button();
            btnPrint = new Button();
            lbDirections = new ListBox();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblFullName.Location = new Point(439, 204);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(57, 21);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "label1";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblStatus.Location = new Point(596, 259);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 21);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "label2";
            // 
            // labelStatus1
            // 
            labelStatus1.AutoSize = true;
            labelStatus1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelStatus1.Location = new Point(439, 259);
            labelStatus1.Name = "labelStatus1";
            labelStatus1.Size = new Size(151, 21);
            labelStatus1.TabIndex = 2;
            labelStatus1.Text = "Статус заявления:";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblComment.Location = new Point(439, 310);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(57, 21);
            lblComment.TabIndex = 3;
            lblComment.Text = "label3";
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRefresh.Location = new Point(1112, 49);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 42);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackgroundImageLayout = ImageLayout.Center;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnPrint.Location = new Point(1112, 114);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(90, 42);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Печать";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // lbDirections
            // 
            lbDirections.BackColor = SystemColors.Control;
            lbDirections.BorderStyle = BorderStyle.None;
            lbDirections.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbDirections.FormattingEnabled = true;
            lbDirections.ItemHeight = 21;
            lbDirections.Location = new Point(439, 363);
            lbDirections.Name = "lbDirections";
            lbDirections.Size = new Size(457, 84);
            lbDirections.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEmail.Location = new Point(439, 149);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "label1";
            // 
            // ApplicantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(lblEmail);
            Controls.Add(lbDirections);
            Controls.Add(btnPrint);
            Controls.Add(btnRefresh);
            Controls.Add(lblComment);
            Controls.Add(labelStatus1);
            Controls.Add(lblStatus);
            Controls.Add(lblFullName);
            Name = "ApplicantDashboardForm";
            Text = "ApplicantDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label lblStatus;
        private Label labelStatus1;
        private Label lblComment;
        private Button btnRefresh;
        private Button btnPrint;
        private ListBox lbDirections;
        private Label lblEmail;
    }
}