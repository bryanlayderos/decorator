namespace Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;
            Console.Write("Enter a string: ");
            input = Console.ReadLine();

            LoggingBehavior stringBehavior = new LoggingBehavior(new AppendingBehavior(new DefaultStringBehavior()));

            stringBehavior.Log(stringBehavior.Reverse(input));

            Console.ReadLine();
        }
    }
}