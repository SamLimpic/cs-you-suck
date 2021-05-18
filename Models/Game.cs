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
            string wins = Games < 2 ? "win" : "wins";
            string loser;
            string msg;
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
                Wait(3, 600);
                msg = $"HA!  I picked {Paper}!  My {Paper} smothers your stupid {Rock}!";
                Message(msg);
                msg = $"That makes {Games} {wins} to none!  {loser}";
                Message(msg);
                Games++;
                Thread.Sleep(750);
                Console.Clear();
            }
            else if (input.ToLower() == Paper.ToLower())
            {
                Wait(3, 600);
                msg = $@"HA!  I picked {Scissors}!  My {Scissors} eviscerate your feeble {Paper}!";
                Message(msg);
                msg = $"That makes {Games} {wins} to none!  {loser}";
                Message(msg);
                Games++;
                Thread.Sleep(750);
                Console.Clear();
            }
            else if (input.ToLower() == Scissors.ToLower())
            {
                Wait(3, 600);
                msg = $@"HA!  I picked {Rock}!  My {Rock} annhihilates your measely {Scissors}!";
                Message(msg);
                msg = $"That makes {Games} {wins} to none!  {loser}";
                Message(msg);
                Games++;
                Thread.Sleep(750);
                Console.Clear();
            }
            else if (input.ToLower() == Winner.ToLower())
            {
                Console.Clear();
                msg = "I";
                Combo(msg);
                Thread.Sleep(750);
                msg = "I what?";
                Combo(msg);
                Thread.Sleep(750);
                msg = "That's";
                Combo(msg);
                Thread.Sleep(750);
                msg = "That's just";
                Combo(msg);
                Thread.Sleep(750);
                msg = "That's just so mean";
                Combo(msg);
                Thread.Sleep(1500);
                Console.Clear();
                msg = "I don't";
                Combo(msg);
                Thread.Sleep(750);
                msg = "I don't wanna play anymore";
                Combo(msg);
                Thread.Sleep(1500);
                Games++;
                return false;
            }
            else
            {
                msg = "C'mon now!  You only have three options to choose from!";
                Message(msg);
                msg = "It's not that hard is it?";
                Message(msg);
                Thread.Sleep(750);
                Console.Clear();
            }
            return true;
        }

        public void Message(string msg)
        {
            Console.WriteLine("");
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write(msg[i]);
                Thread.Sleep(35);
            }
        }

        public void Wait(int length, int time)
        {
            for (int i = 0; i < length; i++)
            {
                Thread.Sleep(time);
                Console.Write('.');
            }
        }

        public void Combo(string msg)
        {
            Message(msg);
            Wait(3, 300);
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