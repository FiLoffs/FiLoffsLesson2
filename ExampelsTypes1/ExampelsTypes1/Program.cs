﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampelsTypes1
{
    class Testing
    {
        static void Main(string[] args)
        {
            byte b = 255;
            int x = 11;
            uint ux = 1111;
            float y = 5.5f;
            double dy = 5.55;
            string s = "Hello!";
            string s1 = "25";
            object obj = new Object();
        }
    }

    void WhoIsWho(string name, object any)
    {
        Console.WriteLine("type {0} is {1} , value is {2}",
        name, any.GetType(), any.ToString());
    }

    public void WhoTest()
    {
        WhoIsWho("x", x);
        WhoIsWho("ux", ux);
        WhoIsWho("y", y);
        WhoIsWho("dy", dy);
        WhoIsWho("s", s);
        WhoIsWho("11 + 5.55 + 5.5f", 11 + 5.55 + 5.5f);
        obj = 11 + 5.55 + 5.5f;
        WhoIsWho("obj", obj);
    }

    void WhoIsWho(string v, object x)
    {
        throw new NotImplementedException();
    }
}
