namespace PMexam
{
    partial class AdminDashboardForm
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
            dgvStatements = new DataGridView();
            btnRefresh = new Button();
            dtpPicker = new DateTimePicker();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStatements).BeginInit();
            SuspendLayout();
            // 
            // dgvStatements
            // 
            dgvStatements.AllowUserToAddRows = false;
            dgvStatements.AllowUserToDeleteRows = false;
            dgvStatements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStatements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStatements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatements.Location = new Point(201, 29);
            dgvStatements.Name = "dgvStatements";
            dgvStatements.ReadOnly = true;
            dgvStatements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatements.Size = new Size(828, 365);
            dgvStatements.TabIndex = 0;
            dgvStatements.CellDoubleClick += dgvStatements_CellDoubleClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRefresh.Location = new Point(1059, 29);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(122, 62);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Обновить данные";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dtpPicker
            // 
            dtpPicker.Location = new Point(33, 29);
            dtpPicker.Name = "dtpPicker";
            dtpPicker.Size = new Size(122, 23);
            dtpPicker.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnFilter.Location = new Point(33, 58);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(122, 33);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Фильтровать";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnFilter);
            Controls.Add(dtpPicker);
            Controls.Add(btnRefresh);
            Controls.Add(dgvStatements);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            ((System.ComponentModel.ISupportInitialize)dgvStatements).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStatements;
        private Button btnRefresh;
        private DateTimePicker dtpPicker;
        private Button btnFilter;
        private Button btnBrowse;
    }
}