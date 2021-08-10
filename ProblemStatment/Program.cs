using System;
using ProblemStatment;

namespace ProblemStatment
{
    class Program
    {

        static void Main(string[] args)
        {
            string con ;

            do
            {
                int day;
                Console.WriteLine("Choose any number");
                Console.WriteLine("1. Positive or Negative");
                Console.WriteLine("2. Factorial");
                Console.WriteLine("3. Sum of number");
                Console.WriteLine("4. Fibonnaci");
                Console.WriteLine("5. Prime");
                Console.WriteLine("6. Reverse number");
                Console.WriteLine("7. Decimal to Binary ");
                Console.WriteLine("8. Palindrome");
                day = Convert.ToInt32(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        ProblemStatment.Class1 P1 = new Class1();
                        Console.Write("Enter value of num: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        P1.PositiveNegative(num);
                        break;
                    case 2:
                        int number;
                        ProblemStatment.Class1 P2 = new Class1();
                        Console.Write("Enter any Number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        P2.Factorial(number);
                        break;
                    case 3:
                        ProblemStatment.Class1 P3 = new Class1();
                        Console.Write("Enter any Number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        P3.Sum(number);
                        break;
                    case 4:
                        int numb;
                        ProblemStatment.Class1 P4 = new Class1();
                        Console.Write("Enter any Number: ");
                        numb = Convert.ToInt32(Console.ReadLine());
                        P4.Fibonnaci(numb);
                        break;
                    case 5:
                        ProblemStatment.Class1 P5 = new Class1();
                        Console.Write("Enter any Number: ");
                        numb = Convert.ToInt32(Console.ReadLine());
                        P5.Prime(numb);
                        break;
                    case 6:
                        ProblemStatment.Class1 P6 = new Class1();
                        Console.Write("Enter any Number: ");
                        numb = Convert.ToInt32(Console.ReadLine());
                        P6.Reverse(numb);
                        break;
                    case 7:
                        ProblemStatment.Class1 P7 = new Class1();
                        Console.Write("Enter the number to convert: ");
                        int n = int.Parse(Console.ReadLine());
                        P7.DB(n);
                        break;
                    case 8:
                        ProblemStatment.Class1 P8 = new Class1();
                        Console.Write("Enter the number : ");
                        n = int.Parse(Console.ReadLine());
                        P8.Palindrome(n);
                        break;

                }
            Console.Write("Do you want to continue? (y/n)");
            con = Console.ReadLine();
            }while(con != "n" && con != "N");

        }


    }
}
