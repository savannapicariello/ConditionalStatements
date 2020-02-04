using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            Console.WriteLine("Please enter an integer value.");

            try
            {
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                if (grade < 60)
                {
                    Console.WriteLine("You will receive an F");
                    grade = int.Parse(Console.ReadLine());
                }

                else if((grade>=60) && (grade<=61))
                {
                    Console.WriteLine("You will receive a D-");
                    grade = int.Parse(Console.ReadLine());
                }

                else if((grade >= 62) && (grade <= 67))
                {
                    Console.WriteLine("You will receive a D");
                    grade = int.Parse(Console.ReadLine());
                }

                else if((grade >= 68) && (grade <= 69))
                {
                    Console.WriteLine("You will receive a D+");
                    grade = int.Parse(Console.ReadLine());
                }

                else if((grade >= 70) && (grade <= 71))
                {
                    Console.WriteLine("You will receive a C-");
                    grade = int.Parse(Console.ReadLine());
                }

                else if((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("You will receive a C");
                    grade = int.Parse(Console.ReadLine());
                }

                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("You will receive a C+");
                    grade = int.Parse(Console.ReadLine());
                }

                else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("You will receive a B-");
                    grade = int.Parse(Console.ReadLine());
                }

                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("You will receive a B");
                    grade = int.Parse(Console.ReadLine());
                }

                else if ((grade >= 88) && (grade <= 89))
                {
                    Console.WriteLine("You will receive a B+");
                    grade = int.Parse(Console.ReadLine());
                }

                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.WriteLine("You will receive an A-");
                    grade = int.Parse(Console.ReadLine());
                }

                else if ((grade >= 92) && (grade <= 97))
                {
                    Console.WriteLine("You will receive an A");
                    grade = int.Parse(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine("You will receive an A+");
                    grade = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Please use an integer value for the grade you expect...");
                Console.WriteLine("Press any key to exit the program and try again.");
                Console.ReadKey(true);
            }
        }
    }
}
