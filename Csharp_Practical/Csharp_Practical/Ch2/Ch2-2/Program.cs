using System;
using System.Collections.Generic;
using System.IO;

namespace SalesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sales = new SalesCounter("sales.csv");
            //아래와 같이 new로 해서하지않는다. 초보가 하는실수.
            //Dictionary<string, int> amountPerStore = new Dictionary<string, int>();
            //amountPerStore = sales.GetPerStoreSales();
            var amountPerStore = sales.GetPerStoreSales();
            //foreach (KeyValuePair<string, int> obj in amountPerStore)
            foreach (var obj in amountPerStore)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}
