using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static Hashtable TABLE = new Hashtable();
        static void Main(string[] args)
        {
            ekle("E","R");
            ekle("T","Y");
            ekle("U","I");

            listele();
        }

        static void ekle(string key, string value)
        {
            TABLE.Add(key, value);
        }

        static void listele()
        {
            foreach (DictionaryEntry item in TABLE)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
