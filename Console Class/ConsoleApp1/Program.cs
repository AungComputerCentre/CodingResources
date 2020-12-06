
using System;

namespace AAA1
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Your First Number");          
            string a = Console.ReadLine();
            Console.WriteLine("Your second Number");
            string b = Console.ReadLine();
            Console.WriteLine("Enter your Operator");
            string c = Console.ReadLine();
            // Console.WriteLine("Your result is {0} " , Convert.ToInt32( a ) + Convert.ToInt32 ( b ));
            double results;
            double FirstNumber = Convert.ToDouble(a);
            double SecondNumber = Convert.ToDouble(b);

            if (c == "+")
            {
                results = FirstNumber + SecondNumber;
            }
            else if (c == "-")
            {
                results = FirstNumber - SecondNumber;
            }
            else if (c == "x")
            {
                results = FirstNumber * SecondNumber;
            }
            else if (c == "%")
            {
                results = FirstNumber / SecondNumber;
            }
            Console.WriteLine(results);


        }
    }
}