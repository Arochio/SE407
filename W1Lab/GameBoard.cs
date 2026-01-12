using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1Lab
{
    public class GameBoard
    {
        public List<GamePiece> board = new List<GamePiece>(9);


        public void ClearBoard()
        {
            //populate with null Pieces
            for (int i = 0; i < board.Capacity; i++)
            {
                GamePiece piece = new GamePiece();
                piece.Type = null;
                board.Add(piece);
            }
        }
        public string MakeMove(GameBoard gameboard, int selection, bool playerOrPC)
        {
            if (playerOrPC)
            {
                //check if user can move
                if (board[selection].Type == null)
                {
                    //set X or O
                    board[selection].Type = playerOrPC;
                }
            }
            else
            {
                Random random = new Random();
                do
                {
                    //generate random number until it lands on empty space
                    selection = random.Next(8) + 1;
                }
                while (board[selection].Type != null);

                //set X or O
                board[selection].Type = playerOrPC;
                int pcCol = (int)Math.Floor((double)selection / 3);
                int pcRow = selection - (pcCol * 3);
                string pcMoveResult = "PC placed in row " + (pcRow + 1) + " and column " + (pcCol + 1);
                Console.WriteLine(pcMoveResult);
            }

            //using the 8 possible win conditions
            int[][] winRows = {
                new []{ 1, 2, 3 },
                new[] { 4, 5, 6 },
                new[] { 7, 8, 9 },
                new[] { 1, 4, 7 },
                new[] { 2, 5, 8 },
                new[] { 3, 6, 9 },
                new[] { 1, 5, 9 },
                new[] { 3, 5, 7 }
            };
            foreach (int[] row in winRows)
            {
                //check that all three are the same and not null
                if (gameboard.board[row[0] - 1].Type != null && gameboard.board[row[0] - 1].Type == gameboard.board[row[1] - 1].Type && gameboard.board[row[1] - 1].Type == gameboard.board[row[2] - 1].Type)
                {
                    //separate bool into X/O
                    string type;
                    if (gameboard.board[row[0] - 1].Type == true)
                    {
                        type = "X (You)";
                    }
                    else
                    {
                        type = "O (PC)";
                    }
                        return type + "Wins!";
                }
            }
            //return empty string if no win condition met
            return null;
        }
    }
}
