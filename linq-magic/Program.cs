using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_magic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Card Deck:\n");

            var cardDeck = from s in Suits()
                           from r in Ranks()
                           select new { Suit = s, Rank = r };
            //var startingDeck = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));

            foreach (var card in cardDeck)
            {
                Console.WriteLine("-> " + card);
            }

            var top = cardDeck.Take(26);
            var bottom = cardDeck.Skip(26);
            var shuffledDeck = top.InterleaveSequenceWith(bottom);

            var times = 0;
            // We can re-use the shuffle variable from earlier, or you can make a new one
            shuffledDeck = cardDeck;
            do
            {
                shuffledDeck = shuffledDeck.Skip(26).InterleaveSequenceWith(shuffledDeck.Take(26));

                foreach (var card in shuffledDeck)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine();
                times++;

            } while (!cardDeck.SequenceEquals(shuffledDeck));

            Console.WriteLine(times);

            /*Console.WriteLine("\n\nShuffled card Deck:\n");
            foreach (var card in shuffledDeck)
            {
                Console.WriteLine("-> " + card);
            }*/
        }

        static IEnumerable<String> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
