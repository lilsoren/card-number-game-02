using System;
using System.Collections.Generic;

namespace Unit02.CardNumGame
{
    public class CardDeck
    {
        ///a deck of cards ranging from 1-13
        public List<int> values = new List<int>();

        ///Constructs a new instance of Card
        public CardDeck()
        {

        }

        public void Draw()
        {
            Random random = new Random();
            values.Add(random.Next(1,13));
        } 
    }
}

