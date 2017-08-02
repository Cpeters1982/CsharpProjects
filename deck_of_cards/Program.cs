using System;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card jon = new Card("jon", "black", 1);
            System.Console.WriteLine(jon.val);
            Deck bob = new Deck().reset();
            System.Console.WriteLine(bob.cards.Count);
            Player bill = new Player("John Snow");
            bill.draw(bob,5);
            System.Console.WriteLine(bill.hand.Count);
            bill.discard(4);
            System.Console.WriteLine(bill.hand.Count);
        }
    }
}
