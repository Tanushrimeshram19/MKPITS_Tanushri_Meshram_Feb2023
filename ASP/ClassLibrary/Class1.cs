using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        public string Addition(int n1, int n2)
        {
            int res = n1 + n2;
            return "addition is" + res.ToString();
        }
    }
}
