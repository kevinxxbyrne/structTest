using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structTest
{
   public class Person
    {
        public Person()
        {
            FirstName = "Nelson";
            Age = 21;
        }
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}
