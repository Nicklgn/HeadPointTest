using System;
using System.Collections.Generic;

namespace HeadPointTest
{
    class Program
    {
        static void Main()
        {
            string[] array = { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };
            Dictionary<string, List<string>> result = TestClass.GetResult(array);
            foreach (List<string> list in result.Values)
            {
                foreach (string str in list)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
