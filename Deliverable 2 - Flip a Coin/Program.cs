using System;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

namespace Deliverable_2___Flip_a_Coin
{
    class Program
    {
        static void Main(string[] args)
        {

            int correctCount = 0;
            int heads = 0;
            int tails = 0;
            string headsOrTailsGuess;
            int numberOFFlips = 0;
            decimal percentage;
            Random cointoss = new Random();
            
            Console.Write("Guess which will have more: heads or tails ?");
            headsOrTailsGuess = Console.ReadLine();

            Console.Write("How many times shall we flip a coin ? ");
            numberOFFlips = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOFFlips; i++)

            {
                int coinflip = cointoss.Next(1,3);

                if (coinflip == 2)

                {

                    Console.WriteLine("heads");

                    heads++;
                    correctCount = heads;

                }               


                 else if (coinflip ==1)

                {
                                                  
                    
                    Console.WriteLine("tails");

                    tails++;
                    correctCount = tails;
                   
                       
                }

                
            }

            percentage = (((decimal)correctCount / numberOFFlips) * 100) ;

            Console.WriteLine("Your guess, " + headsOrTailsGuess +"," +  " came up " + correctCount + " time(s). ");
            Console.WriteLine("That's " + percentage + " %.");
            Console.ReadLine(); 
           


            
            

            


           
            
            
           
          
         
           


        }
    }
}
