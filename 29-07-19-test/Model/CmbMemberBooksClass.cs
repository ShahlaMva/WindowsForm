using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _29_07_19_test.Model
{
    class CmbMemberBooksClass
    {

        public int Id { get; set; }
        public string  NameBook { get; set; }

        public override string ToString()
        {
            return NameBook;
        }
    }
}
