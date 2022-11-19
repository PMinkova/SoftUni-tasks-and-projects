namespace Cards
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            var cards = new List<Card>();

            var input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                var currentCardArguments = input[i].Split(" ");

                var face = currentCardArguments[0];
                var suit = currentCardArguments[1];

                try
                {
                    var currentCard = CreateCard(face, suit);
                    cards.Add(currentCard);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            foreach (var card in cards)
            {
                Console.Write(card + " ");
            }
        }

        public static Card CreateCard(string face, string suit)
        {
            var validFaces = new List<string>
                { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            var validSuits = new Dictionary<string, string>();

            validSuits["S"] = "\u2660";
            validSuits["H"] = "\u2665";
            validSuits["D"] = "\u2666";
            validSuits["C"] = "\u2663";

            if (!validFaces.Contains(face) || !validSuits.ContainsKey(suit))
            {
                throw new ArgumentException("Invalid card!");
            }

            var card = new Card(face, validSuits[suit]);

            return card;
        }
    }

    public class Card
    {

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public string Face { get; set; }

        public string Suit { get; set; }

        public override string ToString()
        {
            return $"[{this.Face}{this.Suit}]";
        }
    }
}
