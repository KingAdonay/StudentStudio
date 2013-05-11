using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentStudio
{
    [Serializable]
    public class ScoreRow
    {
        public Student Student { get; set; }
        public Score Score { get; set; }
        public Subject Subject { get; set; }
    }
}
