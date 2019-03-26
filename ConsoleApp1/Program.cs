using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashTable;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var pair = new HashTable(10000);
            for (int i = 0; i < 10000; i++)
            {
                pair.PutPair((i * 10000).ToString(), i);
            }
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(pair.GetValueByKey(i));
            }

            Console.ReadKey();
        }
    }
}
