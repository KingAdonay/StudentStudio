using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Reflection;
using System.Data.Sql;
//using System.Data.SqlServerCe;
//using System.Data.


namespace StudentStudio
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{

        public List<Student> Students = new List<Student>();
        public List<Group> Groups = new List<Group>();
        public List<ScoreRow> ScoreRows = new List<ScoreRow>();
        public List<Subject> Subjects = new List<Subject>()
        {
            new Subject() { Name = "Математика" },
            new Subject() { Name = "Физика" },
            new Subject() { Name = "Русский язык" },
            new Subject() { Name = "Английский язык" },
            new Subject() { Name = "Физическая культура" },
            new Subject() { Name = "Пение" }
        };


        protected IList ViewingSource;

        protected void Save()
        {
            var Type = this.GetType();
            var List = new List<string>() {"Students", "Groups", "ScoreRows"};
            foreach (var P in List) {
                var FieldInfo = Type.GetField(P);
                if (FieldInfo != null)
                {
                    var Value = FieldInfo.GetValue(this);
                    string Name = P.ToLower() + ".dat";
                    FileStream FileStream = new FileStream(Name, FileMode.OpenOrCreate);
                    BinaryFormatter BinaryFormatter = new BinaryFormatter();
                    BinaryFormatter.Serialize(FileStream, Value);
                    FileStream.Close();
                }
            }
        }

        protected void LoadData()
        {
            var List = new List<string>() { "Students", "Groups", "ScoreRows" };
            var Type = this.GetType();
            foreach (var P in List)
            {
                var FieldInfo = Type.GetField(P);
                if (FieldInfo != null)
                {
                    BinaryFormatter BinaryFormatter = new BinaryFormatter();
                    string Name = P.ToLower() + ".dat";
                    if (File.Exists(Name)) 
                    {
	                    FileStream FileStream = new FileStream(Name, FileMode.OpenOrCreate);
	                    var Object = BinaryFormatter.Deserialize(FileStream);
	                    FileStream.Close();

	                    FieldInfo.SetValue(this, Object);
                    }
                }
            }
        }

		public MainForm()
		{
            LoadData();

			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            SetDataSource(Students);

	
			//
			// TODO: Add constructor code after the InitializeComponent() call.
            //BindingSource BindingSource = new BindingSource();
            //BindingSource.DataSource = Students;
            //StudentsViewGrid.DataSource = BindingSource;


            DataViewGrid.DataSourceChanged += delegate(object sender, EventArgs e)
            {
                //MessageBox.Show(sender.ToString());
            };
            
            DataViewGrid.DataMemberChanged += delegate(object sender, EventArgs e)
            {
                //MessageBox.Show(e.ToString());
            };

            DataViewGrid.CellEndEdit += new DataGridViewCellEventHandler((sender, e) =>
            {
                //MessageBox.Show("CellEndEdit" + e.ToString());
            });

            DataViewGrid.CellValueNeeded += delegate(object sender, DataGridViewCellValueEventArgs e)
            {
                //MessageBox.Show("CellValueNeeded " + e.ToString());
            };

            
		}

        private void AddButton_Click(object sender, EventArgs e)
        {
            var StudentAddForm = new StudentAddForm(this);
            var Result = StudentAddForm.ShowDialog();
            if (Result == DialogResult.OK)
            {
                int ID = Students.Count + 1;
                var Student = StudentAddForm.GetStudent();
                Student.ID = ID;
                Students.Add(Student);
                SetDataSource(Students);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HeadLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentSwitchButton_Click(object sender, EventArgs e)
        {
            SetDataSource(Students);
        }

        private void StudentsView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAddGroup_Click(object sender, EventArgs e)
        {
            FormGroup FG = new FormGroup();
            DialogResult DR = FG.ShowDialog();
            if (DR == DialogResult.OK)
            {
                Group G = FG.GetGroup();
                G.ID = Groups.Count + 1;
                Groups.Add(G);
            }

        }

        private void StudentsViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void ButtonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (DataViewGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны строки.");
                return;
            }
            var RowIndex = DataViewGrid.SelectedRows[0].Index;
            var Row = DataViewGrid.SelectedRows[0];
            Students.RemoveAt(RowIndex);
            SetDataSource(Students);
        }

        private void ButtonAddSubject_Click(object sender, EventArgs e)
        {
            FormSubject FormSubject = new FormSubject();
            DialogResult DR = FormSubject.ShowDialog();
            if (DR == DialogResult.OK)
            {
            }
        }

        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {
            if (DataViewGrid.SelectedCells.Count == 0) {
                return;
            }
            var F = new StudentAddForm(this);
            var Index = DataViewGrid.SelectedCells[0].RowIndex;
            var Student = Students[Index];
            F.SetData(Student);
            var DR = F.ShowDialog();
            if (DR == DialogResult.OK)
            {
                var S = F.GetStudent();
                Students[Index] = S;
                //MessageBox.Show(StudentsViewGrid.DataSource.ToString());
                ((List<Student>)DataViewGrid.DataSource)[Index] = S;

                //StudentsViewGrid.E

                SetDataSource(Students);
            }
        }

        private void ButtonSwitch_Click(object sender, EventArgs e)
        {
            SetDataSource(ScoreRows);


            this.DataViewGrid.ContextMenuStrip = ContextMenuStrip1;

            //this.DataViewGrid.CellClick += delegate(object s, DataGridViewCellEventArgs args)
            //{

            //};
        }

        private void SetDataSource(IList Source)
        {
            this.DataViewGrid.DataSource = null;
            this.DataViewGrid.DataSource = Source;

            ViewingSource = Source;

            Save();
        }

        private void добавитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьОценкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ButtonScoreAdd_Click(object sender, EventArgs e)
        {
            if (DataViewGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Не");
                return;
            }
            var Index = DataViewGrid.SelectedCells[0].RowIndex;
            var Student = ((List<Student>)DataViewGrid.DataSource)[Index]; // TODO: FIX ERROR HERE.

            var F = new ScoreRowAdd(this, Student);
            var DR = F.ShowDialog();


            if (DR == DialogResult.OK)
            {
                var SR = F.GetData();
                ScoreRows.Add(SR);
            }

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.DataViewGrid.SelectedRows[0].Index
            //MessageBox.Show(sender.ToString() + " " + e.ToString() + " " + this.DataViewGrid.SelectedCells[0].RowIndex);
            //String.Join(" ", 
            //this.DataViewGrid.SelectedCells
            //ViewingSource


            foreach (DataGridViewRow Row in this.DataViewGrid.SelectedRows)
            {
                var Index = Row.Index;
                var E = ViewingSource[Index];
                ViewingSource.Remove(E);

            }


            Save();

            SetDataSource(ViewingSource);

        }




    }
}