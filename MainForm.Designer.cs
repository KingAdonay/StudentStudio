/* TODO: 
 * 
 * 
 * 
 *
 * 
 */
namespace StudentStudio
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.HeadLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StudentSwitchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ButtonAddGroup = new System.Windows.Forms.Button();
            this.ButtonDeleteStudent = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ButtonEditStudent = new System.Windows.Forms.Button();
            this.ButtonSwitchScores = new System.Windows.Forms.Button();
            this.ButtonScoreAdd = new System.Windows.Forms.Button();
            this.ContentLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DataViewGrid = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeadLayoutPanel.SuspendLayout();
            this.ContentLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadLayoutPanel
            // 
            this.HeadLayoutPanel.AutoSize = true;
            this.HeadLayoutPanel.Controls.Add(this.StudentSwitchButton);
            this.HeadLayoutPanel.Controls.Add(this.AddButton);
            this.HeadLayoutPanel.Controls.Add(this.ButtonAddGroup);
            this.HeadLayoutPanel.Controls.Add(this.ButtonDeleteStudent);
            this.HeadLayoutPanel.Controls.Add(this.SettingsButton);
            this.HeadLayoutPanel.Controls.Add(this.ButtonEditStudent);
            this.HeadLayoutPanel.Controls.Add(this.ButtonSwitchScores);
            this.HeadLayoutPanel.Controls.Add(this.ButtonScoreAdd);
            this.HeadLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadLayoutPanel.Name = "HeadLayoutPanel";
            this.HeadLayoutPanel.Size = new System.Drawing.Size(624, 58);
            this.HeadLayoutPanel.TabIndex = 0;
            this.HeadLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeadLayoutPanel_Paint);
            // 
            // StudentSwitchButton
            // 
            this.StudentSwitchButton.Location = new System.Drawing.Point(3, 3);
            this.StudentSwitchButton.Name = "StudentSwitchButton";
            this.StudentSwitchButton.Size = new System.Drawing.Size(75, 23);
            this.StudentSwitchButton.TabIndex = 2;
            this.StudentSwitchButton.Text = "Студенты";
            this.StudentSwitchButton.UseVisualStyleBackColor = true;
            this.StudentSwitchButton.Click += new System.EventHandler(this.StudentSwitchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(84, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Tag = "Button";
            this.AddButton.Text = "Добавить студента";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ButtonAddGroup
            // 
            this.ButtonAddGroup.Location = new System.Drawing.Point(215, 3);
            this.ButtonAddGroup.Name = "ButtonAddGroup";
            this.ButtonAddGroup.Size = new System.Drawing.Size(125, 23);
            this.ButtonAddGroup.TabIndex = 3;
            this.ButtonAddGroup.Tag = "Button";
            this.ButtonAddGroup.Text = "Добавить группу";
            this.ButtonAddGroup.UseVisualStyleBackColor = true;
            this.ButtonAddGroup.Click += new System.EventHandler(this.ButtonAddGroup_Click);
            // 
            // ButtonDeleteStudent
            // 
            this.ButtonDeleteStudent.Location = new System.Drawing.Point(346, 3);
            this.ButtonDeleteStudent.Name = "ButtonDeleteStudent";
            this.ButtonDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteStudent.TabIndex = 4;
            this.ButtonDeleteStudent.Text = "Удалить";
            this.ButtonDeleteStudent.UseVisualStyleBackColor = true;
            this.ButtonDeleteStudent.Click += new System.EventHandler(this.ButtonDeleteStudent_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Enabled = false;
            this.SettingsButton.Location = new System.Drawing.Point(427, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Tag = "Button";
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // ButtonEditStudent
            // 
            this.ButtonEditStudent.Location = new System.Drawing.Point(3, 32);
            this.ButtonEditStudent.Name = "ButtonEditStudent";
            this.ButtonEditStudent.Size = new System.Drawing.Size(168, 23);
            this.ButtonEditStudent.TabIndex = 6;
            this.ButtonEditStudent.Text = "Редактировать студента";
            this.ButtonEditStudent.UseVisualStyleBackColor = true;
            this.ButtonEditStudent.Click += new System.EventHandler(this.ButtonEditStudent_Click);
            // 
            // ButtonSwitchScores
            // 
            this.ButtonSwitchScores.Location = new System.Drawing.Point(177, 32);
            this.ButtonSwitchScores.Name = "ButtonSwitchScores";
            this.ButtonSwitchScores.Size = new System.Drawing.Size(75, 23);
            this.ButtonSwitchScores.TabIndex = 7;
            this.ButtonSwitchScores.Text = "Оценки";
            this.ButtonSwitchScores.UseVisualStyleBackColor = true;
            this.ButtonSwitchScores.Click += new System.EventHandler(this.ButtonSwitch_Click);
            // 
            // ButtonScoreAdd
            // 
            this.ButtonScoreAdd.Location = new System.Drawing.Point(258, 32);
            this.ButtonScoreAdd.Name = "ButtonScoreAdd";
            this.ButtonScoreAdd.Size = new System.Drawing.Size(110, 23);
            this.ButtonScoreAdd.TabIndex = 8;
            this.ButtonScoreAdd.Text = "Добавить оценку";
            this.ButtonScoreAdd.UseVisualStyleBackColor = true;
            this.ButtonScoreAdd.Click += new System.EventHandler(this.ButtonScoreAdd_Click);
            // 
            // ContentLayoutPanel
            // 
            this.ContentLayoutPanel.AutoSize = true;
            this.ContentLayoutPanel.Controls.Add(this.flowLayoutPanel1);
            this.ContentLayoutPanel.Location = new System.Drawing.Point(3, 93);
            this.ContentLayoutPanel.Name = "ContentLayoutPanel";
            this.ContentLayoutPanel.Size = new System.Drawing.Size(627, 340);
            this.ContentLayoutPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.DataViewGrid);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(621, 334);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // DataViewGrid
            // 
            this.DataViewGrid.AllowUserToAddRows = false;
            this.DataViewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataViewGrid.Location = new System.Drawing.Point(3, 3);
            this.DataViewGrid.Name = "DataViewGrid";
            this.DataViewGrid.Size = new System.Drawing.Size(612, 331);
            this.DataViewGrid.TabIndex = 2;
            this.DataViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsViewGrid_CellContentClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 61);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(618, 26);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыToolStripMenuItem,
            this.группыToolStripMenuItem,
            this.оценкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(201, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтудентаToolStripMenuItem});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            this.добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            this.добавитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьГруппуToolStripMenuItem});
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.группыToolStripMenuItem.Text = "Группы";
            // 
            // добавитьГруппуToolStripMenuItem
            // 
            this.добавитьГруппуToolStripMenuItem.Name = "добавитьГруппуToolStripMenuItem";
            this.добавитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.добавитьГруппуToolStripMenuItem.Text = "Добавить группу";
            this.добавитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.добавитьГруппуToolStripMenuItem_Click);
            // 
            // оценкиToolStripMenuItem
            // 
            this.оценкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddScoreToolStripMenuItem});
            this.оценкиToolStripMenuItem.Name = "оценкиToolStripMenuItem";
            this.оценкиToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.оценкиToolStripMenuItem.Text = "Оценки";
            // 
            // AddScoreToolStripMenuItem
            // 
            this.AddScoreToolStripMenuItem.Name = "AddScoreToolStripMenuItem";
            this.AddScoreToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.AddScoreToolStripMenuItem.Text = "Добавить оценку";
            this.AddScoreToolStripMenuItem.Click += new System.EventHandler(this.добавитьОценкуToolStripMenuItem_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.ContentLayoutPanel);
            this.Controls.Add(this.HeadLayoutPanel);
            this.Name = "MainForm";
            this.Text = "StudentStudio";
            this.HeadLayoutPanel.ResumeLayout(false);
            this.ContentLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewGrid)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.FlowLayoutPanel HeadLayoutPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.FlowLayoutPanel ContentLayoutPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button StudentSwitchButton;
        private System.Windows.Forms.DataGridView DataViewGrid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonAddGroup;
        private System.Windows.Forms.Button ButtonDeleteStudent;
        private System.Windows.Forms.Button ButtonEditStudent;
        private System.Windows.Forms.Button ButtonSwitchScores;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddScoreToolStripMenuItem;
        private System.Windows.Forms.Button ButtonScoreAdd;
        public System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;

	}
}
