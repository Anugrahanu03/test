using System.Text.RegularExpressions;
using System.Linq;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            //double d = 999.11;
            //int inttt = (int)d;
            //System.Console.WriteLine(inttt);

            int[] arr = [1,102, 2, 2, 3, 99];
            var arry = arr.Select(x => x.ToString() + "hii");
            foreach (var item in arry)
            {
                Console.WriteLine(item);
            }
            string input = "one two three four";
            var eachstr = input.Split(" ");
            var s = eachstr.Select(x => new string(x.Reverse().ToArray()));
            string output = string.Join(" ", s);
            //Console.WriteLine(output);

            //for(int i =0; i < input.Length; i++)
            //{
            //    Console.WriteLine(input[i]);
            //}

            var t = input.Count(x => x == 't'); // counts number of 't' present
            var sub = input.Substring(4,3);
            Console.WriteLine(sub);
        }
    }
}