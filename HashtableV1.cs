using System.Collections;

namespace ConsoleApp7
{
    internal class Program
    {
        static Hashtable TABLE = new Hashtable();

        static void Main(string[] args)
        {

            ekle("KEY","VAL");
            ekle("KEY","VAL");
            ekle("KEY","VAL");

            listele();
        }

        static void ekle(string key, string value)
        {
            TABLE.Add(key, value); // hashtable'a metotdaki key ve value'yi ekler
        }

        static void listele()
        {
            foreach (DictionaryEntry item in TABLE)
            {
                Console.WriteLine(item.Key + ": " + item.Value); //foreach'den dönen veriyi yazdırır
            }
        }
    }
}
