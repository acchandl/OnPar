using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnPar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 2
                        string playAgain1;

                        {
                            Console.WriteLine("Give me one number: ");
                            int x = int.Parse(Console.ReadLine());


                            Console.WriteLine("Give me another number: ");
                            int y = int.Parse(Console.ReadLine());


                            Console.WriteLine("What operation would you like to use on the two numbers? Type + for addition, \n type * for multiplication, type / for division:");
                            string z = Console.ReadLine().ToUpper();


                            while (z == "-")
                            {
                                Console.WriteLine(x - y);
                                z = Console.ReadLine();
                            }

                            while (z == "+")
                            {
                                Console.WriteLine(x + y);
                                z = Console.ReadLine();
                            }
                while (z == "*")
                {
                    Console.WriteLine(x * y);
                    z = Console.ReadLine();
                }
                while (z == "/")
                {
                    Console.WriteLine(x / y);
                    z = Console.ReadLine();
                }
                Console.ReadKey();

                            Console.WriteLine("Would you like to do another calculation? (YES/NO)");
                            playAgain1 = Console.ReadLine().ToUpper();
                            if (playAgain1 == "YES")
                            {
                                Console.WriteLine(playAgain1);
                            }
                            else
                            {

                            }


                        }
                



            



            //Problem 1
                        string addAgain;

                        do
                        {
                            Console.WriteLine("Give me a number: ");
                            int a = int.Parse(Console.ReadLine());

                            Console.WriteLine("Sum:{0} " + a);




                            Console.WriteLine("Do you want to add another number? (YES/NO)");
                            addAgain = Console.ReadLine();
                        }
                        while (addAgain.ToUpper() == "YES");


                



















        }
    }
}
