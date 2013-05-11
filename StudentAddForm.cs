using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentStudio
{
    public partial class StudentAddForm : Form
    {

        MainForm MainForm;

        public StudentAddForm(MainForm MainForm)
        {
            this.MainForm = MainForm;
            InitializeComponent();
        }

        private void StudentAddForm_Load(object sender, EventArgs e)
        {
            ComboBoxGroup.DisplayMember = "Name";
            ComboBoxGroup.ValueMember = "ID";
            ComboBoxGroup.DataSource = MainForm.Groups;
        }

        private void StudentAddFormOkButton_Click(object sender, EventArgs e)
        {
        }

        private void StudentAddFormCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Student Data = new Student();

        internal void SetData(Student S)
        {
            Data = S;
            StudentNameTextBox.Text = Data.Name;
            ComboBoxGroup.SelectedItem = Data.Group;
            if (Gender.Female == S.Gender)
            {
                RadioButtonFemale.Checked = true;
            }
            else
            {
                RadioButtonMale.Checked = true;
            }
        }

        public Student GetStudent()
        {
            Data.Name = StudentNameTextBox.Text;
            Data.Group = (Group)ComboBoxGroup.SelectedItem;
            Data.Gender = (RadioButtonFemale.Checked) ? Gender.Female : Gender.Male;

            return Data;
        }
    }
}
