using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordIterating
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = "abcdef";
            int i;

            for (i = 1; i <= text.Length; i++)
                Console.Write(text[text.Length-i] + ";");

            Console.ReadKey();
        }

        public static string InvertInput()
        {
            return "ok";
        }


    }
}
