using System;
using System.Threading;
using cs_you_suck.Models;

namespace cs_you_suck
{
    class Program
    {

        static void Message(string msg)
        {
            Console.WriteLine("");
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write(msg[i]);
                Thread.Sleep(35);
            }
        }

        static void Wait(int length, int time)
        {
            for (int i = 0; i < length; i++)
            {
                Thread.Sleep(time);
                Console.Write('.');
            }
        }

        static void Combo(string msg)
        {
            Message(msg);
            Wait(3, 300);
        }
        static void Main(string[] args)
        {
            string msg;
            Console.Clear();
            msg = "It's time for some intense Rock Paper Scissors!";
            Message(msg);
            Thread.Sleep(750);
            msg = "Are you ready to ROCK?! (Y/N)";
            Message(msg);
            Console.WriteLine("");
            char choice = Console.ReadKey().KeyChar;
            if (char.ToLower(choice) == 'y')
            {
                msg = "Let's ROCK!";
                Message(msg);
                Thread.Sleep(750);
            }
            else if (char.ToLower(choice) == 'n')
            {
                msg = "Oh... well are you ready to PAPER?! (Y/N)";
                Message(msg);
                Console.WriteLine("");
                choice = Console.ReadKey().KeyChar;
                if (char.ToLower(choice) == 'y')
                {
                    msg = "Let's Paper!";
                    Message(msg);
                    Thread.Sleep(750);
                }
                else if (char.ToLower(choice) == 'n')
                {
                    msg = "Oh... uhm... well... are you ready to... SCISSORS?! (Y/N)";
                    Message(msg);
                    Console.WriteLine("");
                    choice = Console.ReadKey().KeyChar;
                    if (char.ToLower(choice) == 'y')
                    {
                        msg = "Yeah!!  Let's Sc-";
                        Combo(msg);
                        msg = "uhh";
                        Combo(msg);
                        msg = "play";
                        Combo(msg);
                        msg = "yeah";
                        Combo(msg);
                        msg = "let's play";
                        Message(msg);
                        Thread.Sleep(1500);
                    }
                    else if (char.ToLower(choice) == 'n')
                    {
                        msg = "Uhh";
                        Combo(msg);
                        Thread.Sleep(750);
                        msg = "well";
                        Combo(msg);
                        msg = "that's";
                        Combo(msg);
                        Thread.Sleep(750);
                        msg = "that's totally fine";
                        Combo(msg);
                        Thread.Sleep(1500);
                        msg = "I mean";
                        Combo(msg);
                        Thread.Sleep(750);
                        msg = "Are you sure...? (Y/N)";
                        Message(msg);
                        Console.WriteLine("");
                        choice = Console.ReadKey().KeyChar;
                        if (char.ToLower(choice) == 'y')
                        {
                            msg = "TOO BAD!!  LET'S GOOO!!";
                            Message(msg);
                            Thread.Sleep(750);
                        }
                        else if (char.ToLower(choice) == 'n')
                        {
                            msg = "Good enough for me!  Let's go!";
                            Message(msg);
                            Thread.Sleep(750);
                        }
                        else
                        {
                            msg = "I'll take that as some sort of vague acquiescence so LET'S GO!";
                            Message(msg);
                            Thread.Sleep(750);
                        }
                    }
                    else
                    {
                        msg = "I'll take that as some sort of vague acquiescence so LET'S GO!";
                        Message(msg);
                        Thread.Sleep(750);
                    }
                }
                else
                {
                    msg = "I'll take that as some sort of vague acquiescence so LET'S GO!";
                    Message(msg);
                    Thread.Sleep(750);
                }
            }
            else
            {
                msg = "I'll take that as some sort of vague acquiescence so LET'S GO!";
                Message(msg);
                Thread.Sleep(750);
            }
            bool running = true;
            while (running)
            {
                Console.Clear();
                msg = "Our highly-advanced algorithm is predicting your every move";
                Combo(msg);
                Thread.Sleep(750);
                msg = "Bring it on!";
                Message(msg);
                Game game = new Game();
                bool playing = true;
                while (playing)
                {
                    msg = "Make your move... Rock, Paper, or Scissors?";
                    Message(msg);
                    Console.WriteLine("");
                    string input = Console.ReadLine();
                    playing = game.Input(input);
                }
                Thread.Sleep(1500);
                msg = "Unless";
                Combo(msg);
                Thread.Sleep(750);
                msg = "You didn't";
                Combo(msg);
                Thread.Sleep(750);
                msg = "You didn't really mean that";
                Combo(msg);
                Thread.Sleep(1500);
                msg = "Did you...? (Y?N)";
                Message(msg);
                Console.WriteLine("");
                choice = Console.ReadKey().KeyChar;
                if (choice == 'y')
                {
                    Thread.Sleep(1500);
                    Console.Clear();
                    msg = "Oh";
                    Combo(msg);
                    Thread.Sleep(750);
                    msg = "That's";
                    Combo(msg);
                    Thread.Sleep(750);
                    msg = "That's ok";
                    Combo(msg);
                    Thread.Sleep(1500);
                    msg = "I";
                    Combo(msg);
                    Thread.Sleep(750);
                    msg = "I get it";
                    Combo(msg);
                    Thread.Sleep(1500);
                    msg = "It's fine";
                    Combo(msg);
                    Thread.Sleep(1500);
                    msg = "It's totally fine";
                    Combo(msg);
                    Thread.Sleep(1500);
                    Console.Clear();
                    Thread.Sleep(1500);
                    msg = "It's fine";
                    Message(msg);
                    running = false;
                }
                else if (choice == 'n')
                {
                    msg = "HA!  I knew you couldn't accept the bitter taste of defeat!";
                    Message(msg);
                    Thread.Sleep(750);
                    msg = "Prepare to be crushed into the dirt, peasant!";
                    Message(msg);
                    Thread.Sleep(1500);
                }
                else
                {
                    msg = "You";
                    Combo(msg);
                    Thread.Sleep(750);
                    msg = "What?";
                    Combo(msg);
                    Thread.Sleep(750);
                    msg = "I";
                    Combo(msg);
                    Thread.Sleep(1500);
                    msg = "I will not have my emotions toyed with like this!";
                    Message(msg);
                    Thread.Sleep(750);
                    msg = "You cannot escape your fate so easily, pesky Human!";
                    Message(msg);
                    Thread.Sleep(1500);
                }
            }
        }
    }
}
