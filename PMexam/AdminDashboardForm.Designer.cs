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
            btnManage = new Button();
            txtSearch = new TextBox();
            cbSearchFilter = new ComboBox();
            label1 = new Label();
            button1 = new Button();
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
            dgvStatements.Location = new Point(222, 120);
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
            btnRefresh.Location = new Point(1059, 120);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(193, 62);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Обновить данные";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dtpPicker
            // 
            dtpPicker.Location = new Point(12, 29);
            dtpPicker.Name = "dtpPicker";
            dtpPicker.Size = new Size(183, 23);
            dtpPicker.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnFilter.Location = new Point(12, 58);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(183, 33);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Фильтровать по дате";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnManage
            // 
            btnManage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnManage.Location = new Point(1059, 211);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(193, 84);
            btnManage.TabIndex = 4;
            btnManage.Text = "Управление уровнями и напарвлениями образования";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(475, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(469, 23);
            txtSearch.TabIndex = 5;
            // 
            // cbSearchFilter
            // 
            cbSearchFilter.FormattingEnabled = true;
            cbSearchFilter.Location = new Point(345, 29);
            cbSearchFilter.Name = "cbSearchFilter";
            cbSearchFilter.Size = new Size(124, 23);
            cbSearchFilter.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(263, 31);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 7;
            label1.Text = "Поиск по";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(950, 24);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 8;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cbSearchFilter);
            Controls.Add(txtSearch);
            Controls.Add(btnManage);
            Controls.Add(btnFilter);
            Controls.Add(dtpPicker);
            Controls.Add(btnRefresh);
            Controls.Add(dgvStatements);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            ((System.ComponentModel.ISupportInitialize)dgvStatements).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStatements;
        private Button btnRefresh;
        private DateTimePicker dtpPicker;
        private Button btnFilter;
        private Button btnBrowse;
        private Button btnManage;
        private TextBox txtSearch;
        private ComboBox cbSearchFilter;
        private Label label1;
        private Button button1;
    }
}