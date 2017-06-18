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

            string[] separators = new string[] { "\\n", "," };
            numbers = Array.ConvertAll(input.Split(separators,StringSplitOptions.RemoveEmptyEntries), int.Parse).ToList();
            
            if (methodName.ToLower().Equals("add") || methodName.ToLower().Equals("sum"))
            {
                result = add(numbers);
            }
            Console.WriteLine(result);
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
