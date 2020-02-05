using System;
using System.Collections.Generic;

namespace myConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Type in what operator you would like to use.  +  |  -  |  *  |  /  ");
            string math = Console.ReadLine();
            try
            {
                Console.WriteLine("How many questions would you like?");
                int questions = Convert.ToInt32(Console.ReadLine());
                int score = 0;
                while (score < questions)
                {
                    Random random = new Random();
                    int randOne = random.Next(1, 10);
                    int randTwo = random.Next(1, 10);
                    try
                    {
                        if (math == "+" || math == "-" || math == "*" || math == "/")
                        {
                            if (math == "+")
                            {
                                result = randOne + randTwo;
                                Console.WriteLine("What is " + randOne + " " + math + " " + randTwo + " ?");
                                int ans = Convert.ToInt32(Console.ReadLine());

                                try
                                {
                                    if (ans == result)
                                    {
                                        Console.WriteLine("Correct!");
                                        score++;
                                        Console.WriteLine("Score: " + score + " out of " + questions + "\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect. The answer was " + result);
                                        score--;
                                        Console.WriteLine("Score: " + score + " out of " + questions + "\n");
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Please enter an actual number");
                                }
                            }

                            if (math == "-")
                            {
                                result = randOne - randTwo;
                                Console.WriteLine("What is " + randOne + " " + math + " " + randTwo + " ?");
                                int ans = Convert.ToInt32(Console.ReadLine());

                                try
                                {
                                    if (ans == result)
                                    {
                                        Console.WriteLine("Correct!");
                                        score++;
                                        Console.WriteLine("Score: " + score + " out of " + questions + "\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect. The answer was " + result);
                                        score--;
                                        Console.WriteLine("Score: " + score + " out of " + questions + "\n");
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Please enter an actual number");
                                }
                            }

                            if (math == "*")
                            {
                                result = randOne * randTwo;
                                Console.WriteLine("What is " + randOne + " x " + randTwo + " ?");
                                int ans = Convert.ToInt32(Console.ReadLine());

                                try
                                {
                                    if (ans == result)
                                    {
                                        Console.WriteLine("Correct!");
                                        score++;
                                        Console.WriteLine("Score: " + score + " out of " + questions + "\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect. The answer was " + result);
                                        score--;
                                        Console.WriteLine("Score: " + score + " out of " + questions + "\n");
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Please enter an actual number");
                                }
                            }

                            if (math == "/")
                            {
                                result = randOne / randTwo;
                                Console.WriteLine("What is " + randOne + " " + math + " " + randTwo + " ?");
                                int ans = Convert.ToInt32(Console.ReadLine());

                                try
                                {
                                    if (ans == result)
                                    {
                                        Console.WriteLine("Correct!");
                                        score++;
                                        Console.WriteLine("Score: " + score + " out of " + questions + "\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect. The answer was " + result);
                                        score--;
                                        Console.WriteLine("Score: " + score + " out of " + questions + "\n");
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Please enter an actual number");
                                }
                            }

                            if (score == questions)
                            {
                                Console.WriteLine("You win");
                            }

                            if (score < 0)
                            {
                                score = 1;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please type in a correct operator");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Insert a number");
            }

            Console.ReadLine();
        }
    }
}