namespace PMexam
{
    partial class ManageDirectionsForm
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
            cbEducationLevels = new ComboBox();
            dgvDirections = new DataGridView();
            txtNewDirection = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAddLevel = new Button();
            txtNewLevel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDirections).BeginInit();
            SuspendLayout();
            // 
            // cbEducationLevels
            // 
            cbEducationLevels.FormattingEnabled = true;
            cbEducationLevels.Location = new Point(37, 84);
            cbEducationLevels.Name = "cbEducationLevels";
            cbEducationLevels.Size = new Size(274, 23);
            cbEducationLevels.TabIndex = 0;
            // 
            // dgvDirections
            // 
            dgvDirections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDirections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirections.Location = new Point(365, 84);
            dgvDirections.Name = "dgvDirections";
            dgvDirections.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirections.Size = new Size(808, 289);
            dgvDirections.TabIndex = 1;
            // 
            // txtNewDirection
            // 
            txtNewDirection.Location = new Point(365, 426);
            txtNewDirection.Name = "txtNewDirection";
            txtNewDirection.Size = new Size(808, 23);
            txtNewDirection.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(365, 402);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 3;
            label1.Text = "Новое Направление";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(365, 473);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(205, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить направление";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDelete.Location = new Point(667, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(205, 31);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Удалить выбранное";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnUpdate.Location = new Point(968, 473);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(205, 31);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Переименовть";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddLevel
            // 
            btnAddLevel.AutoSize = true;
            btnAddLevel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddLevel.Location = new Point(37, 270);
            btnAddLevel.Name = "btnAddLevel";
            btnAddLevel.Size = new Size(274, 31);
            btnAddLevel.TabIndex = 7;
            btnAddLevel.Text = "Добавить уровень образования";
            btnAddLevel.UseVisualStyleBackColor = true;
            btnAddLevel.Click += btnAddLevel_Click;
            // 
            // txtNewLevel
            // 
            txtNewLevel.Location = new Point(37, 188);
            txtNewLevel.Name = "txtNewLevel";
            txtNewLevel.Size = new Size(274, 23);
            txtNewLevel.TabIndex = 8;
            // 
            // ManageDirectionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(txtNewLevel);
            Controls.Add(btnAddLevel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtNewDirection);
            Controls.Add(dgvDirections);
            Controls.Add(cbEducationLevels);
            Name = "ManageDirectionsForm";
            Text = "ManageDirectionsForm";
            ((System.ComponentModel.ISupportInitialize)dgvDirections).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEducationLevels;
        private DataGridView dgvDirections;
        private TextBox txtNewDirection;
        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddLevel;
        private TextBox txtNewLevel;
    }
}