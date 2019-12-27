using System;
using System.Linq;

namespace P07_KnightGame
{
    class Program
    {//0K0KKK00
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[size, size];

            Initialize(chessBoard);

            int maxAttacks = 0;
            int killerRow = 0;
            int killerCol = 0;

            int knigthKillers = 0;

            while (true)
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        int currentKnightsAttacks = 0;

                        if (chessBoard[row, col] == 'K')
                        {
                            if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                        }

                        if (currentKnightsAttacks > maxAttacks)
                        {
                            maxAttacks = currentKnightsAttacks;
                            killerCol = col;
                            killerRow = row;
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    chessBoard[killerRow, killerCol] = '0';
                    maxAttacks = 0;
                    knigthKillers++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(knigthKillers);
        }

        private static bool IsInside(char[,] chessBoard, int row, int col)
        {
            return 0 <= row && row < chessBoard.GetLength(0) && 0 <= col && col < chessBoard.GetLength(1);
        }

        private static void Initialize(char[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine()
                    .ToCharArray();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = currentRow[col];
                }
            }
        }
    }
}
