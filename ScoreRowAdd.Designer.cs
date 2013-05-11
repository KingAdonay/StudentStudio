namespace StudentStudio
{
    partial class ScoreRowAdd
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.СomboBoxSubject = new System.Windows.Forms.ComboBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxScore = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Предмет";
            // 
            // СomboBoxSubject
            // 
            this.СomboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.СomboBoxSubject.FormattingEnabled = true;
            this.СomboBoxSubject.Location = new System.Drawing.Point(83, 8);
            this.СomboBoxSubject.Name = "СomboBoxSubject";
            this.СomboBoxSubject.Size = new System.Drawing.Size(121, 21);
            this.СomboBoxSubject.TabIndex = 1;
            this.СomboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.СomboBoxSubject_SelectedIndexChanged);
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Location = new System.Drawing.Point(15, 68);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 2;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Оценка";
            // 
            // ComboBoxScore
            // 
            this.ComboBoxScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxScore.FormattingEnabled = true;
            this.ComboBoxScore.Location = new System.Drawing.Point(83, 38);
            this.ComboBoxScore.Name = "ComboBoxScore";
            this.ComboBoxScore.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxScore.TabIndex = 4;
            this.ComboBoxScore.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.ComboBoxScore.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxScore_Validating);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(96, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // ScoreRowAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ComboBoxScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.СomboBoxSubject);
            this.Controls.Add(this.label1);
            this.Name = "ScoreRowAdd";
            this.Text = "Добавить оценку студенту";
            this.Load += new System.EventHandler(this.ScoreRowAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox СomboBoxSubject;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxScore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}