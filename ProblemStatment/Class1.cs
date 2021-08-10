using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatment
{
    class Class1
    {
        public void PositiveNegative(int num)
        {

            if (num > 0)
                Console.Write("{0} is positive number", num);
            else
                Console.Write("{0} is negative number", num);
        }

        public void Factorial(int number)
        {
            int i, fact = 1;


            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }

        public void Sum(int n)
        {
            int sum = 0, m;

            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);


        }

        public void Fibonnaci(int numb)
        {
            int n1 = 0, n2 = 1, n3, i;
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < numb; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }

        public void Prime(int numb)
        {
            int i, m = 0, flag = 0;

            m = numb / 2;
            for (i = 2; i <= m; i++)
            {
                if (numb % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }

        public void Reverse(int n)
        {
            int reverse = 0, rem;

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }

        public void DB(int n)
        {
            int i;
            int[] a = new int[10];

            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }

        public void Palindrome(int n)
        {
            int r, sum = 0, temp;
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }


    }
}
