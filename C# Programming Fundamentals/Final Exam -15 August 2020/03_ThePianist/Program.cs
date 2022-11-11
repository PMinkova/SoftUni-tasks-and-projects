using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ThePianist
{
    class Piece
    {
        public Piece(string composer, string key)
        {
            this.Composer = composer;
            this.Key = key;
        }

        public string Composer { get; set; }

        public string Key { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
         {
            var piecesInfo = new Dictionary<string, Piece>();
            var orderPieces = new List<string>();

            var piecesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < piecesCount; i++)
            {
                var pieces = Console.ReadLine()
                    .Split("|");

                var pieceName = pieces[0];
                var composer = pieces[1];
                var key = pieces[2];

                var currentPiece = new Piece(composer, key);
                piecesInfo.Add(pieceName, currentPiece);
                orderPieces.Add(pieceName);
            }

            var input = Console.ReadLine();

            while (input != "Stop")
            {
                var commandArgs = input.Split("|");

                var command = commandArgs[0];
                var pieceName = commandArgs[1];

                if (command == "Add")
                {
                    var composer = commandArgs[2];
                    var key = commandArgs[3];

                    AddPiece(piecesInfo, pieceName, composer, key, orderPieces);
                }
                else if (command == "Remove")
                {
                    RemovePiece(piecesInfo, pieceName, orderPieces);
                }
                else if (command == "ChangeKey")
                {
                    string newKey = commandArgs[2];

                    ChangeKey(piecesInfo, pieceName, newKey);
                }

                input = Console.ReadLine();
            }

            foreach (var pieceName in orderPieces)
            {
                var composer = piecesInfo[pieceName].Composer;
                var key = piecesInfo[pieceName].Key;

                Console.WriteLine($"{pieceName} -> Composer: {composer}, Key: {key}");
            }
        }

        private static void ChangeKey(Dictionary<string, Piece> piecesInfo, string pieceName, string newKey)
        {
            if (piecesInfo.ContainsKey(pieceName))
            {
                piecesInfo[pieceName].Key = newKey;
                Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
            }
        }

        static void RemovePiece(Dictionary<string, Piece> piecesInfo, string pieceName, List<string> orderPieces)
        {
            if (piecesInfo.ContainsKey(pieceName))
            {
                orderPieces.Remove(pieceName);
                piecesInfo.Remove(pieceName);
                Console.WriteLine($"Successfully removed {pieceName}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
            }
        }

        static void AddPiece(Dictionary<string, Piece> piecesInfo, string pieceName, string composer, string key, List<string> orderPieces)
        {
            if (piecesInfo.ContainsKey(pieceName))
            {
                Console.WriteLine($"{pieceName} is already in the collection!");
            }
            else
            {
                orderPieces.Add(pieceName);
                piecesInfo.Add(pieceName, new Piece(composer, key));
                Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
            }
        }
    }
}
