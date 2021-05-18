using System;
using System.Threading;
using cs_you_suck.Models;

namespace cs_you_suck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("It's time for some intense Rock Paper Scissors!");
            Thread.Sleep(750);
            Console.WriteLine("Are you ready to ROCK?! (Y/N)");
            char choice = Console.ReadKey().KeyChar;
            if (char.ToLower(choice) == 'y')
            {
                Console.WriteLine("\nLet's ROCK!");
                Thread.Sleep(750);
            }
            else if (char.ToLower(choice) == 'n')
            {
                Console.WriteLine("\nOh... well are you ready to PAPER?! (Y/N)");
                choice = Console.ReadKey().KeyChar;
                if (char.ToLower(choice) == 'y')
                {
                    Console.Write("\nLet's Paper!");
                    Thread.Sleep(750);
                }
                else if (char.ToLower(choice) == 'n')
                {
                    Console.WriteLine("\nOh... uhm... well... are you ready to... SCISSORS?! (Y/N)");
                    choice = Console.ReadKey().KeyChar;
                    if (char.ToLower(choice) == 'y')
                    {
                        Console.WriteLine("\nYeah!!  Let's Sc-");
                        int freq = 150;
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("uhh");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("play");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("yeah");
                        Thread.Sleep(750);
                    }
                    else if (char.ToLower(choice) == 'n')
                    {
                        Console.WriteLine("");
                        int freq = 150;
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("Oh");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("well");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("that's");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("that's totally fine");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("I mean");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(450);
                            Console.Write('.');
                            freq += 150;
                        }
                        Console.WriteLine("Are you sure...? (Y/N)");
                        choice = Console.ReadKey().KeyChar;
                        if (char.ToLower(choice) == 'y')
                        {
                            Console.WriteLine("\nTOO BAD!!  LET'S GOOO!!");
                            Thread.Sleep(750);
                        }
                        else if (char.ToLower(choice) == 'n')
                        {
                            Console.WriteLine("\nGood enough for me!  Let's go!");
                            Thread.Sleep(750);
                        }
                        else
                        {
                            Console.WriteLine("\nI'll take that as some sort of vague acquiescence so LET'S GO!");
                            Thread.Sleep(750);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nI'll take that as some sort of vague acquiescence so LET'S GO!");
                        Thread.Sleep(750);
                    }
                }
                else
                {
                    Console.WriteLine("\nI'll take that as some sort of vague acquiescence so LET'S GO!");
                    Thread.Sleep(750);
                }
            }
            else
            {
                Console.WriteLine("\nI'll take that as some sort of vague acquiescence so LET'S GO!");
                Thread.Sleep(750);
            }
            bool running = true;
            while (running)
            {
                Console.WriteLine("");
                Console.WriteLine("Our highly-advanced algorithm is predicting your every move");
                Thread.Sleep(750);
                Console.WriteLine("Bring it on!");
                int freq = 150;
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Game game = new Game();
                bool playing = true;
                while (playing)
                {
                    Console.WriteLine("\nMake your move... Rock, Paper, or Scissors?");

                    string input = Console.ReadLine();
                    playing = game.Input(input);
                }
                Console.Clear();
                Console.WriteLine("");
                Thread.Sleep(750);
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Console.WriteLine("Unless");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Console.WriteLine("");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Console.WriteLine("You didn't");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Console.WriteLine("");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Console.WriteLine("You didn't mean that");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Console.WriteLine("");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Console.WriteLine("");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Console.Clear();
                Thread.Sleep(750);
                Console.WriteLine("Did you...? (Y?N)");
                choice = Console.ReadKey().KeyChar;
                if (choice == 'y')
                {
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("Oh");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("That's ok");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.Clear();
                    Thread.Sleep(750);
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("I");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("I get it");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.Clear();
                    Thread.Sleep(750);
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("It's");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("It's fine");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("It's totally fine");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.Clear();
                    Thread.Sleep(1500);
                    Console.WriteLine("It's fine");
                    Thread.Sleep(1500);
                    running = false;
                }
                else if (choice == 'n')
                {
                    Console.WriteLine("\nHA!  I knew you couldn't accept the bitter taste of defeat!");
                    Thread.Sleep(750);
                    Console.WriteLine("\nPrepare to be crushed into the dirt, peasant!");
                    Thread.Sleep(750);
                }
                else
                {
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("You");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("What?");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("I");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(450);
                        Console.Write('.');
                        freq += 150;
                    }
                    Thread.Sleep(750);
                    Console.WriteLine("I will not have my emotions toyed with like this!");
                    Thread.Sleep(750);
                    Console.WriteLine("\nYou cannot escape your fate so easily, pesky Human!");
                    Thread.Sleep(750);
                }
            }
        }
    }
}
