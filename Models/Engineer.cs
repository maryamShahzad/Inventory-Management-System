using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EadQuiz02.Models
{
    public class Engineer
    {
        public string RegNo { set; get; }
        public string Name { set; get; }
        public string Decipline { set; get; }
        public Engineer (string reg, string name, string dec)
        {
            RegNo = reg;
            Name = name;
            Decipline = dec;
        }
    }
}