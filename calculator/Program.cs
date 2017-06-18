using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string methodName = args[0];
            string input = args.Length > 1 ? args[1]: "0" ;           
            int result = 0;

            //string[] separators = new string[] { "\\n", "," };
            string separator = input.Substring(input.IndexOf(@"\\") + 1, input.LastIndexOf(@"\\"));
            char c = separator[1];
            numbers = Array.ConvertAll(input.Substring(input.LastIndexOf("\\")+1).Split(c), int.Parse).ToList();
            bool containsNegative = numbers.Any(i => i < 0);

            if (!containsNegative)
            {
                if (methodName.ToLower().Equals("add") || methodName.ToLower().Equals("sum"))
                {
                    result = add(numbers);
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Negative numbers not allowed");
            }

            Console.ReadKey();
        }

        static int add(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
