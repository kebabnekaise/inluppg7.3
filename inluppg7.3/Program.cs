using System;

namespace inluppg7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary["sverige"] = 450;
            dictionary["norge"] = 385;
            dictionary["danmark"] = 43;
            dictionary["finland"] = 338;

            Console.WriteLine("Vilket nordiskt land vill du veta landarean på?");

            string input = Console.ReadLine().ToLower();
            Console.WriteLine(dictionary[input] + " m^2");
        }
    }
}