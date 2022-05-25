using System;
using System.Collections.Generic;

namespace Unit02.CardNumGame
{

    /// A person who directs the game. 
    /// Controls the sequence of play.
    public class Director
    {
        bool isPlaying = true;
        int score = 0;
        int totalScore = 0;

        /// Constructs a new instance of Director.
        public Director()
        {
           
        }

        ///Starts the game by running the main game loop
        public void StartGame()
        {
            while (isPlaying)
            {
                KeepPlaying();
                if (!isPlaying){
                    Console.WriteLine("Game over. Your final score is " + totalScore);
                    break;
                }
                GetHiLo();
            }
        }

        public void KeepPlaying()
        {
            Console.Write("Draw card? [y/n]: ");
            String drawCard = Console.ReadLine();
            isPlaying = (drawCard == "y");            
        }
    
    
        public void GetHiLo()
        {
            string userGuess;

                CardDeck c1 = new CardDeck();
                c1.Draw();
                c1.Draw();
                Console.WriteLine("The card is " + c1.values[0]);
                Console.Write("Higher or Lower [h/l]: ");
                userGuess = Console.ReadLine();
                
                if (isUserCorrect(c1, userGuess))
                {
                    score = 100;
                }
                else{
                    score = -100;
                }

                totalScore += score;
                Console.WriteLine("Your score is " + totalScore);
            
        }


        public bool isUserCorrect(CardDeck c, string userGuess)
        {
            bool result = false;
            if (string.Compare(userGuess, "h", true) == 0 && c.values[0] < c.values[1])
            {
                result = true;
            }
            else if (string.Compare(userGuess, "l", true) == 0 && c.values[0] > c.values[1])
            {
                result  = true;
            }
            return result;
        }
    }
}