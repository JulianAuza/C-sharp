using System;
using System.Collections.Generic;

namespace cards
{
    public class Deck{
    
        public Card[] deck;
        private int currentCard;
        private const int NumCards=52;

        private Random ranNum;

    

       

        public Deck(){
            string[] faces = {"Ace", "2", "3", "4","5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

            string[] suits = {"Hearts", "Clubs", "Diamonds", "Spades"};
            deck=new Card[NumCards];
            currentCard=0;
            ranNum=new Random();
            for(int count=0; count<deck.Length;count++){
                deck[count] =new Card(faces[count%11],suits[count/13]);
            }

        }

        public Card Deal(){
            ranNum=new Random();
            int card = ranNum.Next(52);
            return deck[card];
        }

        public void Shuffle(){
            currentCard=0;
            for(int first=0;first<deck.Length;first++){
                int second=ranNum.Next(NumCards);
                Card temp = deck[first];
                deck[first] =deck[second];
                deck[second]=temp;
            }
        }
        
       
        
        
        
        
        
    }
}