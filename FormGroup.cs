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
    public partial class FormGroup : Form
    {
        public FormGroup()
        {
            InitializeComponent();
        }

        public Group GetGroup()
        {
            return new Group()
            {
                Name = textBox1.Text
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {

        }


    }
}
