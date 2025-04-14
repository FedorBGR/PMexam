namespace PMexam
{
    partial class RegisterForm
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
            cboEducationLevel = new ComboBox();
            lblEducationLevel = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblPassport = new Label();
            lblSnils = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            lblParentName = new Label();
            txtParentName = new TextBox();
            lblGraduatedFrom = new Label();
            txtGraduatedFrom = new TextBox();
            panelEGE = new Panel();
            numScoreEGE3 = new NumericUpDown();
            numScoreEGE2 = new NumericUpDown();
            numScoreEGE1 = new NumericUpDown();
            cboEGE3 = new ComboBox();
            cboEGE2 = new ComboBox();
            cboEGE1 = new ComboBox();
            lblEGE = new Label();
            numAvgScore = new NumericUpDown();
            lblAvgScore = new Label();
            clbDirections = new CheckedListBox();
            lblDirections = new Label();
            btnUploadPdf = new Button();
            btnSubmit = new Button();
            txtPhone = new MaskedTextBox();
            txtPassport = new MaskedTextBox();
            txtSnils = new MaskedTextBox();
            panelEGE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numScoreEGE3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numScoreEGE2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numScoreEGE1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAvgScore).BeginInit();
            SuspendLayout();
            // 
            // cboEducationLevel
            // 
            cboEducationLevel.Font = new Font("Segoe UI", 12F);
            cboEducationLevel.FormattingEnabled = true;
            cboEducationLevel.Location = new Point(318, 149);
            cboEducationLevel.Name = "cboEducationLevel";
            cboEducationLevel.Size = new Size(318, 29);
            cboEducationLevel.TabIndex = 0;
            cboEducationLevel.SelectedIndexChanged += cboEducationLevel_SelectedIndexChanged;
            // 
            // lblEducationLevel
            // 
            lblEducationLevel.AutoSize = true;
            lblEducationLevel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEducationLevel.Location = new Point(127, 147);
            lblEducationLevel.Name = "lblEducationLevel";
            lblEducationLevel.Size = new Size(185, 21);
            lblEducationLevel.TabIndex = 1;
            lblEducationLevel.Text = "Уровень образования";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 12F);
            txtFullName.Location = new Point(318, 184);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(318, 29);
            txtFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblFullName.Location = new Point(203, 186);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(106, 21);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Полное имя";
            // 
            // lblPassport
            // 
            lblPassport.AutoSize = true;
            lblPassport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPassport.Location = new Point(108, 219);
            lblPassport.Name = "lblPassport";
            lblPassport.Size = new Size(204, 21);
            lblPassport.TabIndex = 5;
            lblPassport.Text = "Серия и номер паспорат";
            // 
            // lblSnils
            // 
            lblSnils.AutoSize = true;
            lblSnils.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSnils.Location = new Point(251, 254);
            lblSnils.Name = "lblSnils";
            lblSnils.Size = new Size(58, 21);
            lblSnils.TabIndex = 7;
            lblSnils.Text = "Снилс";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEmail.Location = new Point(223, 291);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(86, 21);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Эл. Почта";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(318, 289);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 29);
            txtEmail.TabIndex = 8;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPhone.Location = new Point(230, 326);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(79, 21);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Телефон";
            // 
            // lblParentName
            // 
            lblParentName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblParentName.Location = new Point(92, 359);
            lblParentName.Name = "lblParentName";
            lblParentName.Size = new Size(220, 51);
            lblParentName.TabIndex = 13;
            lblParentName.Text = "ФИО родителя/законного представителя";
            // 
            // txtParentName
            // 
            txtParentName.BorderStyle = BorderStyle.FixedSingle;
            txtParentName.Font = new Font("Segoe UI", 12F);
            txtParentName.Location = new Point(318, 359);
            txtParentName.Multiline = true;
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(318, 48);
            txtParentName.TabIndex = 12;
            // 
            // lblGraduatedFrom
            // 
            lblGraduatedFrom.AutoSize = true;
            lblGraduatedFrom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblGraduatedFrom.Location = new Point(45, 416);
            lblGraduatedFrom.Name = "lblGraduatedFrom";
            lblGraduatedFrom.Size = new Size(267, 21);
            lblGraduatedFrom.TabIndex = 15;
            lblGraduatedFrom.Text = "Оконченное учебное заведение";
            // 
            // txtGraduatedFrom
            // 
            txtGraduatedFrom.BorderStyle = BorderStyle.FixedSingle;
            txtGraduatedFrom.Font = new Font("Segoe UI", 12F);
            txtGraduatedFrom.Location = new Point(318, 414);
            txtGraduatedFrom.Name = "txtGraduatedFrom";
            txtGraduatedFrom.Size = new Size(318, 29);
            txtGraduatedFrom.TabIndex = 14;
            // 
            // panelEGE
            // 
            panelEGE.Controls.Add(numScoreEGE3);
            panelEGE.Controls.Add(numScoreEGE2);
            panelEGE.Controls.Add(numScoreEGE1);
            panelEGE.Controls.Add(cboEGE3);
            panelEGE.Controls.Add(cboEGE2);
            panelEGE.Controls.Add(cboEGE1);
            panelEGE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelEGE.Location = new Point(668, 295);
            panelEGE.Name = "panelEGE";
            panelEGE.Size = new Size(519, 148);
            panelEGE.TabIndex = 16;
            // 
            // numScoreEGE3
            // 
            numScoreEGE3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numScoreEGE3.Location = new Point(346, 116);
            numScoreEGE3.Name = "numScoreEGE3";
            numScoreEGE3.Size = new Size(97, 29);
            numScoreEGE3.TabIndex = 28;
            // 
            // numScoreEGE2
            // 
            numScoreEGE2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numScoreEGE2.Location = new Point(346, 65);
            numScoreEGE2.Name = "numScoreEGE2";
            numScoreEGE2.Size = new Size(97, 29);
            numScoreEGE2.TabIndex = 27;
            // 
            // numScoreEGE1
            // 
            numScoreEGE1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numScoreEGE1.Location = new Point(346, 6);
            numScoreEGE1.Name = "numScoreEGE1";
            numScoreEGE1.Size = new Size(97, 29);
            numScoreEGE1.TabIndex = 24;
            // 
            // cboEGE3
            // 
            cboEGE3.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEGE3.FormattingEnabled = true;
            cboEGE3.Items.AddRange(new object[] { "Русский язык", "Математика (базовый уровень)", "Математика (профильный уровень)", "Обществознание", "История", "Иностранный язык", "Литература", "География", "Физика", "Химия", "Биология", "Информатика и ИКТ" });
            cboEGE3.Location = new Point(18, 116);
            cboEGE3.Name = "cboEGE3";
            cboEGE3.Size = new Size(308, 29);
            cboEGE3.TabIndex = 26;
            // 
            // cboEGE2
            // 
            cboEGE2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEGE2.FormattingEnabled = true;
            cboEGE2.Items.AddRange(new object[] { "Русский язык", "Математика (базовый уровень)", "Математика (профильный уровень)", "Обществознание", "История", "Иностранный язык", "Литература", "География", "Физика", "Химия", "Биология", "Информатика и ИКТ" });
            cboEGE2.Location = new Point(18, 64);
            cboEGE2.Name = "cboEGE2";
            cboEGE2.Size = new Size(308, 29);
            cboEGE2.TabIndex = 25;
            // 
            // cboEGE1
            // 
            cboEGE1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEGE1.FormattingEnabled = true;
            cboEGE1.Items.AddRange(new object[] { "Русский язык", "Математика (базовый уровень)", "Математика (профильный уровень)", "Обществознание", "История", "Иностранный язык", "Литература", "География", "Физика", "Химия", "Биология", "Информатика и ИКТ" });
            cboEGE1.Location = new Point(18, 6);
            cboEGE1.Name = "cboEGE1";
            cboEGE1.Size = new Size(308, 29);
            cboEGE1.TabIndex = 24;
            // 
            // lblEGE
            // 
            lblEGE.AutoSize = true;
            lblEGE.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEGE.Location = new Point(668, 262);
            lblEGE.Name = "lblEGE";
            lblEGE.Size = new Size(123, 21);
            lblEGE.TabIndex = 17;
            lblEGE.Text = "Предметы ЕГЭ";
            lblEGE.Click += lblEGE_Click;
            // 
            // numAvgScore
            // 
            numAvgScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numAvgScore.Location = new Point(318, 479);
            numAvgScore.Name = "numAvgScore";
            numAvgScore.Size = new Size(97, 29);
            numAvgScore.TabIndex = 18;
            // 
            // lblAvgScore
            // 
            lblAvgScore.AutoSize = true;
            lblAvgScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAvgScore.Location = new Point(186, 481);
            lblAvgScore.Name = "lblAvgScore";
            lblAvgScore.Size = new Size(122, 21);
            lblAvgScore.TabIndex = 19;
            lblAvgScore.Text = "Средний балл";
            // 
            // clbDirections
            // 
            clbDirections.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clbDirections.FormattingEnabled = true;
            clbDirections.Location = new Point(668, 149);
            clbDirections.Name = "clbDirections";
            clbDirections.Size = new Size(519, 100);
            clbDirections.TabIndex = 20;
            // 
            // lblDirections
            // 
            lblDirections.AutoSize = true;
            lblDirections.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblDirections.Location = new Point(668, 120);
            lblDirections.Name = "lblDirections";
            lblDirections.Size = new Size(213, 21);
            lblDirections.TabIndex = 21;
            lblDirections.Text = "Направления подготовки";
            // 
            // btnUploadPdf
            // 
            btnUploadPdf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnUploadPdf.Location = new Point(320, 543);
            btnUploadPdf.Name = "btnUploadPdf";
            btnUploadPdf.Size = new Size(317, 39);
            btnUploadPdf.TabIndex = 22;
            btnUploadPdf.Text = "Загрузить скан документа (PDF)";
            btnUploadPdf.UseVisualStyleBackColor = true;
            btnUploadPdf.Click += btnUploadPdf_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSubmit.Location = new Point(677, 543);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(317, 39);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "Подать Заявку";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPhone.Location = new Point(318, 324);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(319, 29);
            txtPhone.TabIndex = 24;
            // 
            // txtPassport
            // 
            txtPassport.BorderStyle = BorderStyle.FixedSingle;
            txtPassport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassport.Location = new Point(318, 217);
            txtPassport.Mask = "0000 000000";
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(319, 29);
            txtPassport.TabIndex = 25;
            // 
            // txtSnils
            // 
            txtSnils.BorderStyle = BorderStyle.FixedSingle;
            txtSnils.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSnils.Location = new Point(318, 254);
            txtSnils.Mask = "000-000-000 00";
            txtSnils.Name = "txtSnils";
            txtSnils.Size = new Size(319, 29);
            txtSnils.TabIndex = 26;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(txtSnils);
            Controls.Add(txtPassport);
            Controls.Add(txtPhone);
            Controls.Add(btnSubmit);
            Controls.Add(btnUploadPdf);
            Controls.Add(lblDirections);
            Controls.Add(clbDirections);
            Controls.Add(lblAvgScore);
            Controls.Add(numAvgScore);
            Controls.Add(lblEGE);
            Controls.Add(panelEGE);
            Controls.Add(lblGraduatedFrom);
            Controls.Add(txtGraduatedFrom);
            Controls.Add(lblParentName);
            Controls.Add(txtParentName);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSnils);
            Controls.Add(lblPassport);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblEducationLevel);
            Controls.Add(cboEducationLevel);
            Name = "RegisterForm";
            Text = "RegisterForm";
            panelEGE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numScoreEGE3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numScoreEGE2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numScoreEGE1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAvgScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEducationLevel;
        private Label lblEducationLevel;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label lblPassport;
        private Label lblSnils;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private Label lblParentName;
        private TextBox txtParentName;
        private Label lblGraduatedFrom;
        private TextBox txtGraduatedFrom;
        private Panel panelEGE;
        private Label lblEGE;
        private NumericUpDown numAvgScore;
        private Label lblAvgScore;
        private CheckedListBox clbDirections;
        private Label lblDirections;
        private Button btnUploadPdf;
        private Button btnSubmit;
        private ComboBox cboEGE1;
        private NumericUpDown numScoreEGE3;
        private NumericUpDown numScoreEGE2;
        private NumericUpDown numScoreEGE1;
        private ComboBox cboEGE3;
        private ComboBox cboEGE2;
        private MaskedTextBox txtPhone;
        private MaskedTextBox txtPassport;
        private MaskedTextBox txtSnils;
    }
}