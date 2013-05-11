using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentStudio
{
    [Serializable]
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
