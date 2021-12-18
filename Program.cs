using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            static void problem1(string[] args)
            {
                if (args.Length == 3)
                {
                  
                    float a = float.Parse(args[0]);
                    
                    float b = float.Parse(args[2]);

                    string op = args[1];

                    double result = 0;
                    switch (op)
                    {
                        case "+":
                            {
                                result = a + b;
                                Console.WriteLine("Result is: " + result);
                                break;
                            }
                        case "-":
                            {
                                result = a - b;
                                Console.WriteLine("Result is: " + result);
                                break;
                            }
                        case "*":
                            {
                                result = a * b;
                                Console.WriteLine("Result is: " + result);
                                break;
                            }
                        case "/":
                            {
                                if (a == 0)
                                {
                                    Console.WriteLine(" First number cannot be 0. No result available");
                                }
                                else
                                {
                                    result = a / b;
                                    Console.WriteLine("Result is: " + result);
                                }
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("3 args are needed!");
                }
            }

            problem1(args);


            static void problem2()
            {
                //Calculate the sum of the first 100 numbers higher than 0
                int num = 100, sum = 0;
                for (int i = 1; i <= num; ++i)
                {
                    sum += i;
                }
                Console.WriteLine("Sum = " + sum);
            }
            problem2();

            
            
           static void problem3()
            {
                //Check if a number is palindrome ( e.g. palindrome 1221, 34143)
                int num = 34143;
                int i, r, sum = 0;

                for (i = num; num != 0; num = num / 10)
                {
                    r = num % 10;
                    sum = sum * 10 + r;
                }
                if (i == sum)
                {
                    Console.WriteLine("{0} is a palindrome number.", i);
                }
                else
                {
                    Console.WriteLine("{0} is not a palindrome number.", i);
                }
            }
            problem3();


            
            static void problem4()
            {
                //Display all the prime numbers lower than a given number
                Console.WriteLine("Provide a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num <= 1)
                {
                    Console.WriteLine("Number is not prime");
                }
                while (num > 1)
                {
                    int i;
                    for (i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            Console.WriteLine("Number {0} is not prime", num);
                            break;
                        }
                    }
                    if (i == num)
                    {
                        Console.WriteLine("Number {0} is prime", num);
                    }
                    num--;
                }
            }
            problem4();
      
        }
    }
}
