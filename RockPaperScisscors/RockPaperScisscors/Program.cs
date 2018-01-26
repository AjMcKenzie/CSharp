using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisscors
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            string choice;
            int choiceNumber;
            int score = 0;
            int rockNum = 1;
            int paperNum = 2;
            int scissorsNum = 3;
                  

                Random randNumber = new Random();
          
            
           while (score < 10)
                {
                    Console.WriteLine("Enter 1 for Rock, 2 for paper, or 3 for scissors...");
                    choice = Console.ReadLine();
                    choiceNumber = Convert.ToInt32(choice);
                    randomNumber = randNumber.Next(1, 3);

                 if (choiceNumber == rockNum && randomNumber == rockNum)  //rock- 1
                {
                    randomNumber = randNumber.Next(1, 3);
                        Console.WriteLine("You tied!");
                        Console.WriteLine("");
                        Console.WriteLine("You have won " + score + " times.");
                        
                        Console.WriteLine("");
                 }
                  else if (choiceNumber == paperNum && randomNumber == rockNum)
                    {
                        randomNumber = randNumber.Next(1, 3);
                        Console.WriteLine("You win!");
                        score = score + 1;
                        Console.WriteLine("");
                        Console.WriteLine("You have won " + score + " times.");
                        
                        Console.WriteLine("");
                    }
                    else if (choiceNumber == scissorsNum && randomNumber == rockNum)
                    {
                        randomNumber = randNumber.Next(1, 3);
                        Console.WriteLine("You lost!");
                        Console.WriteLine("");
                        if (score != 0)
                        {
                            score = score - 1;
                        }
                        Console.WriteLine("You have won " + score + " times.");
                        
                        Console.WriteLine("");
                    }
                 else if (choiceNumber == paperNum && randomNumber == paperNum)  //paper- 2
                 {
                     randomNumber = randNumber.Next(1, 3);
                     Console.WriteLine("You tied!");
                     Console.WriteLine("");
                     Console.WriteLine("You have won " + score + " times.");
                     
                     Console.WriteLine("");
                 }
                 else if (choiceNumber == scissorsNum && randomNumber == paperNum)
                 {
                     randomNumber = randNumber.Next(1, 3);
                     Console.WriteLine("You win!");
                     score = score + 1;
                     Console.WriteLine("");
                     Console.WriteLine("You have won " + score + " times.");
                     
                     Console.WriteLine("");
                 }
                 else if (choiceNumber == rockNum && randomNumber == paperNum)
                 {
                     randomNumber = randNumber.Next(1, 3);
                     Console.WriteLine("You lost!");
                     Console.WriteLine("");
                     if (score != 0)
                     {
                         score = score - 1;
                     }
                     Console.WriteLine("You have won " + score + " times.");
                     
                     Console.WriteLine("");
                 }
                 else if (choiceNumber == scissorsNum && randomNumber == scissorsNum)  //scissors- 3
                 {
                     randomNumber = randNumber.Next(1, 3);
                     Console.WriteLine("You tied!");
                     Console.WriteLine("");
                     Console.WriteLine("You have won " + score + " times.");
                     
                     Console.WriteLine("");
                 }
                 else if (choiceNumber == rockNum && randomNumber == scissorsNum)
                 {
                     randomNumber = randNumber.Next(1, 3);
                     Console.WriteLine("You win!");
                     score = score + 1;
                     Console.WriteLine("");
                     Console.WriteLine("You have won " + score + " times.");
                     
                     Console.WriteLine("");
                 }
                 else if (choiceNumber == paperNum && randomNumber == scissorsNum)
                 {
                     randomNumber = randNumber.Next(1, 3);
                     Console.WriteLine("You lost!");
                     Console.WriteLine("");
                     if (score != 0)
                     {
                         score = score - 1;
                     }
                     Console.WriteLine("You have won " + score + " times.");
                     
                     Console.WriteLine("");
                 }

               }
            }
           
            
            

        }
    }

