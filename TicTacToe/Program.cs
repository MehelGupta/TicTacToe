using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string player1Name, player2Name;
            do
            {
                //INTRO
                Console.WriteLine("Welcome To UNE©!");
                Console.WriteLine("Press any key to begin... ");
                input = Console.ReadLine();
                if (checkExit(input))
                    break;
                //Gets player Names
                Console.WriteLine("Player 1 enter your name!: ");
                player1Name = Console.ReadLine();
                Console.WriteLine("Player 2 enter your name!: ");
                player2Name = Console.ReadLine();

            }
            while (checkExit(input) == false);
        }
        //EXIT METHOD
        public static bool checkExit(string input)
        {
            if (string.Equals(input.ToLower(), "quit"))
                return true;
            return false;
        }
    }



}
