using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentStudio
{
    [Serializable]
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Group Group { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
