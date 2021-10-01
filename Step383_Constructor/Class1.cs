using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step383_Constructor
{
    public class Class1
    {
        public Class1(string name) : this(name, DateTime.Now)
        {
        }
        public Class1(string name, DateTime datetime)
        {
            myName = name;
            dateTime = datetime;            
        }
        public string myName { get; set; }
        public DateTime dateTime { get; set; }
    }
}
