using System;
using System.Threading;

namespace cs_you_suck.Models
{
    public class Game
    {
        public string Rock { get; private set; }
        public string Paper { get; private set; }
        public string Scissors { get; private set; }
        public int Games { get; private set; }
        public string Winner { get; set; }

        public bool Input(string input)
        {
            int freq = 50;
            string wins = Games < 2 ? "win" : "wins";
            string loser;
            if (Games < 3)
            {
                loser = "";
            }
            else if (Games < 5)
            {
                loser = "Today really just isn't your day is it?";
            }
            else if (Games < 7)
            {
                loser = "What a loser you must be in real life!";
            }
            else
            {
                loser = "Wow you suck!";
            }

            if (input.ToLower() == Rock.ToLower())
            {
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(150);
                    Console.Write('.');
                    freq += 50;
                }
                Console.WriteLine("");
                Console.WriteLine($"HA!  I picked {Paper}!  My {Paper} smothers your stupid {Rock}!");
                Console.WriteLine($"That makes {Games} {wins} to none!  {loser}");
                Games++;
                Thread.Sleep(750);
            }
            else if (input.ToLower() == Paper.ToLower())
            {
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(150);
                    Console.Write('.');
                    freq += 50;
                }
                Console.WriteLine("");
                Console.WriteLine($@"HA!  I picked {Scissors}!  My {Scissors} eviscerate your feeble {Paper}!");
                Console.WriteLine($"That makes {Games} {wins} to none!  {loser}");
                Games++;
                Thread.Sleep(750);
            }
            else if (input.ToLower() == Scissors.ToLower())
            {
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(150);
                    Console.Write('.');
                    freq += 50;
                }
                Console.WriteLine("");
                Console.WriteLine($@"HA!  I picked {Rock}!  My {Rock} annhihilates your measely {Scissors}!");
                Console.WriteLine($"That makes {Games} {wins} to none!  {loser}");
                Games++;
                Thread.Sleep(750);
            }
            else if (input.ToLower() == Winner.ToLower())
            {
                Console.Clear();
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
                Console.WriteLine("I what?");
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
                Console.WriteLine("");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Console.WriteLine("That's");
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
                Console.WriteLine("That's just");
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
                Console.WriteLine("That's just so mean");
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
                Console.WriteLine("");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(450);
                    Console.Write('.');
                    freq += 150;
                }
                Console.WriteLine("I don't");
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
                Console.WriteLine("I don't wanna play anymore");
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
                Games++;
                return false;
            }
            else
            {
                Console.WriteLine("\nC'mon now!  You only have three options to choose from!");
                Console.WriteLine("\nIt's not that hard is it?");
            }
            return true;
        }
        public Game()
        {
            Rock = "Rock";
            Paper = "Paper";
            Scissors = "Scissors";
            Winner = "You Suck!";
            Games = 1;
        }
    }
}