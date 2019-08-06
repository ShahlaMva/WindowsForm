using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _29_07_19_test.Model
{
    class PassportClass
    {
        public int Id { get; set; }
        public string PassportId { get; set; }

        public override string ToString()
        {
            return PassportId;
        }
    }
}
