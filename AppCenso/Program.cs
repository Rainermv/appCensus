using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCensus
{
    class Program
    {
        static void Main(string[] args)
        {
            Census census = new Census();
            census.run();
        }
    }
}
