using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class DictionaryTest
    {
        public void test() {
            var dict = new Dictionary<string, int>();
            // { "apple", 10 }, { "Apple", 5 }, { " ", 2 }, { ".", 1 }, { "123", 3 }
            dict.Add("apple", 10);
            dict.Add("Apple", 5);
            dict.Add(" ", 2);
            dict.Add(".", 1);
            dict.Add("123", 3);

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}