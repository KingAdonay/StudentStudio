namespace StudentStudio
{
    partial class StudentAddForm
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
            this.StudentNameLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentAddFormOkButton = new System.Windows.Forms.Button();
            this.StudentAddFormCancelButton = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelGroup = new System.Windows.Forms.Label();
            this.ComboBoxGroup = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.StudentNameLayoutPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentNameLayoutPanel
            // 
            this.StudentNameLayoutPanel.AutoSize = true;
            this.StudentNameLayoutPanel.Controls.Add(this.StudentNameLabel);
            this.StudentNameLayoutPanel.Controls.Add(this.StudentNameTextBox);
            this.StudentNameLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.StudentNameLayoutPanel.Name = "StudentNameLayoutPanel";
            this.StudentNameLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.StudentNameLayoutPanel.Size = new System.Drawing.Size(572, 42);
            this.StudentNameLayoutPanel.TabIndex = 0;
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(3, 11);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(32, 13);
            this.StudentNameLabel.TabIndex = 1;
            this.StudentNameLabel.Text = "Имя:";
            this.StudentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentNameTextBox.Location = new System.Drawing.Point(41, 8);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(239, 20);
            this.StudentNameTextBox.TabIndex = 2;
            // 
            // StudentAddFormOkButton
            // 
            this.StudentAddFormOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.StudentAddFormOkButton.Location = new System.Drawing.Point(3, 3);
            this.StudentAddFormOkButton.Name = "StudentAddFormOkButton";
            this.StudentAddFormOkButton.Size = new System.Drawing.Size(75, 23);
            this.StudentAddFormOkButton.TabIndex = 1;
            this.StudentAddFormOkButton.Text = "OK";
            this.StudentAddFormOkButton.UseVisualStyleBackColor = true;
            this.StudentAddFormOkButton.Click += new System.EventHandler(this.StudentAddFormOkButton_Click);
            // 
            // StudentAddFormCancelButton
            // 
            this.StudentAddFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StudentAddFormCancelButton.Location = new System.Drawing.Point(84, 3);
            this.StudentAddFormCancelButton.Name = "StudentAddFormCancelButton";
            this.StudentAddFormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.StudentAddFormCancelButton.TabIndex = 2;
            this.StudentAddFormCancelButton.Text = "Отмена";
            this.StudentAddFormCancelButton.UseVisualStyleBackColor = true;
            this.StudentAddFormCancelButton.Click += new System.EventHandler(this.StudentAddFormCancelButton_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.AutoSize = true;
            this.ButtonsPanel.Controls.Add(this.StudentAddFormOkButton);
            this.ButtonsPanel.Controls.Add(this.StudentAddFormCancelButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 138);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(280, 29);
            this.ButtonsPanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.LabelGroup);
            this.flowLayoutPanel1.Controls.Add(this.ComboBoxGroup);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(283, 32);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // LabelGroup
            // 
            this.LabelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGroup.AutoSize = true;
            this.LabelGroup.Location = new System.Drawing.Point(3, 12);
            this.LabelGroup.Name = "LabelGroup";
            this.LabelGroup.Size = new System.Drawing.Size(42, 13);
            this.LabelGroup.TabIndex = 1;
            this.LabelGroup.Text = "Группа";
            this.LabelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBoxGroup
            // 
            this.ComboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGroup.FormattingEnabled = true;
            this.ComboBoxGroup.Location = new System.Drawing.Point(51, 8);
            this.ComboBoxGroup.Name = "ComboBoxGroup";
            this.ComboBoxGroup.Size = new System.Drawing.Size(167, 21);
            this.ComboBoxGroup.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.RadioButtonMale);
            this.flowLayoutPanel2.Controls.Add(this.RadioButtonFemale);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 60);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(283, 31);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пол:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Checked = true;
            this.RadioButtonMale.Location = new System.Drawing.Point(39, 8);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(47, 17);
            this.RadioButtonMale.TabIndex = 2;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Муж";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Location = new System.Drawing.Point(92, 8);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(48, 17);
            this.RadioButtonFemale.TabIndex = 3;
            this.RadioButtonFemale.Text = "Жен";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // StudentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 202);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.StudentNameLayoutPanel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StudentAddForm";
            this.Text = "Добавить студента";
            this.Load += new System.EventHandler(this.StudentAddForm_Load);
            this.StudentNameLayoutPanel.ResumeLayout(false);
            this.StudentNameLayoutPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel StudentNameLayoutPanel;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.Button StudentAddFormOkButton;
        private System.Windows.Forms.Button StudentAddFormCancelButton;
        private System.Windows.Forms.FlowLayoutPanel ButtonsPanel;


        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LabelGroup;
        private System.Windows.Forms.ComboBox ComboBoxGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.RadioButton RadioButtonFemale;

    }
}