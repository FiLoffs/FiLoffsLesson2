using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiLoffsTypes
{
    class Class1
    {
        static void Main(string[] args)
        {
            testing tm = new Testing();
            Console.WriteLine("Testing.Who Test");
            tm.WhoTest();
            Console.WriteLine("Testing.Back Test");
            tm.BackTest();
            Console.WriteLine("Testing.OLoad Test");
            tm.OLoadTest();
            Console.WriteLine("Testing.ToString Test");
            tm.ToStringTest();
            Console.WriteLine("Testing.FromString Test");
            tm.FromStringTest();
            Console.WriteLine("Testing.CheckUncheck Test");
            tm.CheckUncheckTest();

        }
    }
}
