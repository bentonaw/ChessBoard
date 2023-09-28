using System.Data.Common;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Welcome to the customizable chessboard!");
            Console.WriteLine("In this program you will be able to set the size of the board and choose what to display as the black and white squares.");
            Console.WriteLine("Please start with the size of the grid:");
            int gridInt = int.Parse(Console.ReadLine());
            Console.Write("Select a character to display as the black squares. Type \"square\" for ◼︎: ");
            string blacksqString = Console.ReadLine();

            if (blacksqString == "square")
            {
                blacksqString = "◼︎";
            }

            Console.Write("Select a character to display as the white squares. Type \"square\" for ◻︎: ");
            string whitesqString = Console.ReadLine();
            if (whitesqString == "square")
            {
                whitesqString = "◻︎";
            }

            for (int rowInt = 0; rowInt < gridInt; rowInt++)
            {
                for (int columnInt = 0; columnInt < gridInt; columnInt++)
                {
                    if ((rowInt + columnInt) % 2 == 0)
                    {
                        Console.Write($"{blacksqString} ");
                    }
                    else
                    {
                        Console.Write($"{whitesqString} ");
                    }
                }
                Console.WriteLine();
            }
            //insert extended code here
            Console.WriteLine("Now that we have a board, we can place a piece on it. Choose the number of the piece you would like?:");
            Console.WriteLine("1. Pawn");
            Console.WriteLine("2. Knight");
            Console.WriteLine("3. Bishop");
            Console.WriteLine("4. Rook");
            Console.WriteLine("5. Queen");
            Console.WriteLine("6. King");
            string pieceString = (Console.ReadLine());

            Console.Write("Which color? (Black/White): ");
            string colorString = Console.ReadLine();

            string chosenPieceString = "piece";
            if (colorString == "Black")
            {
                switch (pieceString)
                {
                    case "1":
                        chosenPieceString = "♟︎";
                        break;
                    case "2":
                        chosenPieceString = "♞";
                        break;
                    case "3":
                        chosenPieceString = "♝";
                        break;
                    case "4":
                        chosenPieceString = "♜";
                        break;
                    case "5":
                        chosenPieceString = "♛";
                        break;
                    case "6":
                        chosenPieceString = "♚";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (chosenPieceString)
                {
                    case "1":
                        chosenPieceString = "♙";
                        break;
                    case "2":
                        chosenPieceString = "♘";
                        break;
                    case "3":
                        chosenPieceString = "♗";
                        break;
                    case "4":
                        chosenPieceString = "♖";
                        break;
                    case "5":
                        chosenPieceString = "♕";
                        break;
                    case "6":
                        chosenPieceString = "♔";
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"You have chosen {chosenPieceString} which we now can place on the board.");
            Console.Write("Where would you like to place it? First Column starts with \"A\" and the first row starts with \"1\". Eg. E7: ");
            string location = Console.ReadLine();
            char letter = location[0];
            int columnY = (char.ToUpper(letter) - 64) -1;
            int rowX = int.Parse(location.Substring(1)) -1;

            for (int rowInt = 0; rowInt < gridInt; rowInt++)
            {
                for (int columnInt = 0; columnInt < gridInt; columnInt++)
                {
                    if ((rowInt == rowX) && (columnInt == columnY))
                    {
                        Console.Write($" {chosenPieceString} ");
                    }
                    else if ((rowInt + columnInt) % 2 == 0 &!(rowInt == rowX && columnInt == columnY))
                    {
                        Console.Write($"{blacksqString} ");
                    }
                    else if (!(rowInt == rowX && columnInt == columnY))
                    {
                        Console.Write($"{whitesqString} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

