using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.შექმენით კონსოლური აპლიკაცია რომელიც ხმოვანებს დაითვლის
            // * მომხმარებელს შეაყვანინეთ input
            // * მიღებულ input ში დაითვალეთ ხმოვნები
            // * დაბეჭდეთ სულ რამდენი ხმოვანი იყო
           
 
            Console.Write("Sheiyvanet Stringi: ");
            Console.WriteLine();
            string input = Console.ReadLine();

            
            int x = 0;
            string Xmovnebi = "aeiouAEIOU";


            foreach (char c in input)
            {
                if (Xmovnebi.Contains(c))
                { 
                    x++;
                }
            }
                   Console.WriteLine("Xmovnebis raodenoba = " + x);


            Console.WriteLine();
            //2.შექმენით კონსოლური აპლიკაცია,
            //რომელიც დააგენერირებს და შეინახავს გამრავლების ტაბულას მასივში და
            //შემდეგ მის მნიშვნელობებს დაბეჭდავს.

            Console.Write("Sheiyvanet ricxvi ");
            int number = int.Parse(Console.ReadLine());

            int[] table = new int[10];

            for (int i = 0; i < 10; i++)
            {
                table[i] = (i+1) * number;

            }

            Console.WriteLine("gamravlebis cxrili ricxvi " + number +  "istvis");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number + "X" + (i+1) + "=" + table[i]);
            }
            Console.WriteLine();


            // 3.  მატრიცების შეკრება:
            // * შექმენით ორი 3x3 ზე მატრიცა (ორ განზომილებიანი მასივი)
            // * მოხმარებელს შეავსებინეთ მატრიცაში მნიშვნელობები
            // * შეკრიბეთ მატრიცები

            int[,] martix1 = new int[3, 3];
            int[,] martix2 = new int[3, 3];
            int[,] resultMatrix = new int[3, 3];

           Console.WriteLine("Sheiyvanet pirveli matricis monacemebi :");
           for (int i = 0; i < 3; i++)
           {
               for (int j = 0; j < 3; j++)
               {
                    martix1[i,j] = int.Parse(Console.ReadLine());
               }
           }

           Console.WriteLine("Sheiyvanet meore matricis monacemebi :");
           for (int i = 0; i < 3; i++)
           {
               for (int j = 0; j < 3; j++)
               {
                   martix2[i, j] = int.Parse(Console.ReadLine());
               }
           }

           for (int i = 0; i < 3; i++)
           {
               for (int j = 0; j < 3; j++)
               {
                   resultMatrix[i,j] = martix1[i,j] + martix2[i,j];
               }
           }

           Console.WriteLine("saboloo Shedegi :");
           for (int i = 0; i < 3; i++)
           {
               for (int j = 0; j < 3; j++)
               {
                    Console.WriteLine(resultMatrix[i,j]);
               }
           }




            Console.WriteLine();
            //4. შექმენით კონსოლური კალკულატორი რომელსაც მენიუ ექნება. კალკულატორი მანამდე უნდა მუშაობდეს
            // სანამ მომხმარებელს არ მოუნდება მისი გათიშვა.

          
                bool running = true;

                while (running)
                {
                    Console.WriteLine("Calculator Menu:");
                    Console.WriteLine("1) Addition");
                    Console.WriteLine("2) Subtraction");
                    Console.WriteLine("3) Multiplication");
                    Console.WriteLine("4) Division");
                    Console.WriteLine("5) Exit");
                    Console.Write("Choose an option: ");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 5)
                    {
                        running = false;
                        Console.WriteLine("OFF.");
                        break;
                    }

                    Console.Write("Enter first number: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double result = 0;

                    switch (choice)
                    {
                        case 1:
                            result = num1 + num2;
                            Console.WriteLine("Shedegi : " + result);
                            break;
                        case 2:
                            result = num1 - num2;
                            Console.WriteLine("Shedegi : " + result);
                            break;
                        case 3:
                            result = num1 * num2;
                            Console.WriteLine("Shedegi : " + result);
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine("Shedegi : " + result);
                            }
                            else
                            {
                                Console.WriteLine("Nulze gayopa ar aris shesadzlebeli ");
                            }
                            break;
                        default:
                            Console.WriteLine("EROR");
                            break;
                    }
                }
        }
    }



}




