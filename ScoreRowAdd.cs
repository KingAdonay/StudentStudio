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
    public partial class ScoreRowAdd : Form
    {
        public Student Student;

        private ScoreRow Data;

        public ScoreRowAdd(Form owner, Student Student)
        {
            InitializeComponent();
            this.Owner = owner;
            this.Student = Student;
            this.Text = "Добавить оценку " + this.Student.Name;

            СomboBoxSubject.DataSource = ((MainForm)this.Owner).Subjects;
            СomboBoxSubject.SelectedIndex = -1;

            ComboBoxScore.DataSource = new List<Score>()
            {
                Score.Bad,
                Score.Unsatisfactory,
                Score.Satisfactory,
                Score.Good,
                Score.Excellent
            };
            ComboBoxScore.SelectedIndex = -1;

            //ComboBoxScore.Validating += delegate(object sender, System.ComponentModel.CancelEventArgs e)
            //{
            //    ComboBox CB = (ComboBox)sender;
            //    if (CB.SelectedIndex < 0)
            //    {
            //        e.Cancel = true;
            //        MessageBox.Show("Выберите значение");


            //        MainForm MainForm = (MainForm)this.Owner;
            //        MainForm.ErrorProvider.SetError(this, "Choose a value");
            //    }

                
            //};

            //СomboBoxSubject.Validating += delegate(object sender, System.ComponentModel.CancelEventArgs e)
            //{
            //    ComboBox CB = (ComboBox)sender;
            //    if (CB.SelectedIndex < 0)
            //    {
            //        e.Cancel = true;
                    
            //        MessageBox.Show("Выберите значение");
            //    }
            //};

            ComboBoxScore.Validating += new CancelEventHandler(ComboBoxScore_Validating);
        }

        public void SetData(ScoreRow SR)
        {
            this.Data = SR;
        }

        public ScoreRow GetData()
        {
            if (Data == null)
            {
                Data = new ScoreRow();
            }
            Data.Student = Student;

            Data.Subject = СomboBoxSubject.SelectedValue as Subject;
            Data.Score = (Score)ComboBoxScore.SelectedValue;
            
            return Data;
        }

        private void СomboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
        }

        private void ComboBoxScore_Validating(object sender, CancelEventArgs e)
        {
            if (ComboBoxScore.SelectedIndex < 0)
            {
                ErrorProvider.SetError(ComboBoxScore, "Не выбрана оценка");
                e.Cancel = true;
            }
        }

        private void ScoreRowAdd_Load(object sender, EventArgs e)
        {

        }


    }
}
