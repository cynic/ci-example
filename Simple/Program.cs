using System;

namespace Simple
{
    public class Program
    {
        public string Reverse(string input) {
            string output = "";
            for (int i = input.Length-1; i >= 0; --i) {
                output += input[i];
            }
            return output;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Reverse("Hello World!"));
        }
    }
}
