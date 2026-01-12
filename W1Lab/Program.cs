using System;
using System.Security.Cryptography.X509Certificates;
using W1Lab;

namespace W1Lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isPlaying = true;
            GameBoard gameboard = new GameBoard();
            gameboard.ClearBoard();
            while (isPlaying)
            {
                //get user selection
                Console.WriteLine("Which row would you like to place in? (1-3)");
                int RowSelect = int.Parse(Console.ReadLine());
                Console.WriteLine("Which column would you like to place in? (1-3)");
                int colSelect = (int.Parse(Console.ReadLine()) - 1) * 3;
                int selection = (RowSelect + colSelect) - 1;

                //check if selection is valid, place if so
                if (gameboard.board[selection].Type == null)
                {
                    //call method to make move
                    string result = gameboard.MakeMove(gameboard, selection, true);

                    if (result != null)
                    {
                        Console.WriteLine(result);
                        Console.WriteLine("Would you like to play again? (y/n)");
                        string again = Console.ReadLine();
                        if (again == "n")
                        {
                            isPlaying = false;
                        }
                    }
                    else
                    {
                        result = gameboard.MakeMove(gameboard, selection, false);

                        if (result != null)
                        {
                            Console.WriteLine(result);
                            Console.WriteLine("Would you like to play again? (y/n)");
                            string again = Console.ReadLine();
                            if (again == "n")
                            {
                                isPlaying = false;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Selection.");
                }
            }
        }
    }
}
