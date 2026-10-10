using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program44
{
    internal class Program
    {
        static void Main()
        {
            string x = null;
            string y = "value";
            x = y; // x станет "value", потому что был null
            Console.WriteLine($"x после x ??= y: {x}"); // Вывод: value
        }
    }
}

