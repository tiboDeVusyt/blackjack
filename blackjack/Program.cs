using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            #region cards 
            int dealerCards;
            int dealerCardTot;
            int dealerCard1=0;
            int dealerCard2=0;
            int dealerCard3=0;
            int dealerCard4 = 0;
            int dealerCard5 = 0;
            int playerCards;
            int playerCardTot;
            int playerCard1=0;
            int playerCard2=0;
            int playerCard3=0;
            int playerCard4=0;
            int playerCard5=0;
            #endregion
            decimal score = 500;
            decimal inzet = 0;
            decimal winst;
            bool win = false;
            bool tie = false;
            bool split = false;
            decimal multiplaier = 2;
            string contineu = "n";
            int Action;
            
            

            Console.WriteLine($"\t\t\t\t\tyou have {score} euro.\ndo you want to start playing.y/n");
            contineu = Console.ReadLine();
            Console.Clear();

            while (contineu.ToLower() != "n")
            {
                
                
                Console.SetCursorPosition(50, 1);
                Console.WriteLine("BLACKJACK");                                                 //Name 


                Console.SetCursorPosition(0, 4);
                Console.WriteLine("what is your bet");                                          // inzet request
                inzet = int.Parse(Console.ReadLine());
                

                if (inzet>score)                                                                // alss inzet meer is dan ze hebben  
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine($"\t\t\t\t\tyou have {score} euro.");


                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("you dont have enough money to place this bet");
                    Console.WriteLine($"what is your new bet <{score}");                                          // inzet aanvraag
                    inzet = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.SetCursorPosition(50, 1);
                    Console.WriteLine("BLACKJACK");

                }
                score -= inzet;
                Console.SetCursorPosition(0, 2);
                Console.WriteLine($"\t\t\t\t\tyou have {score} euro.");
                #region setUp                       
                // the ace is 11 
                // but becomes 1 if totaantal >= 21  
                Console.SetCursorPosition(100, 2);
                Console.WriteLine($"your bet: {inzet}");
                Console.SetCursorPosition(50, 8);
                Console.WriteLine("dealer cards");
                Console.SetCursorPosition(50, 12);
                Console.WriteLine("player cards");
                Console.SetCursorPosition(0, 9);
                dealerCard1 = random.Next(2, 14);
                dealerCard2 = random.Next(2, 14);
                playerCard1 = random.Next(2, 14);
                playerCard2 = random.Next(2, 14);
                #endregion
                #region card making J,Q,K
                //making J ,Q,K
                //J=10, Q =10, K=10
                //
                if (playerCard1>11)
                {
                    playerCard1 = 10;
                }
                if (playerCard2 > 11)
                {
                    playerCard2 = 10;
                }
                if (dealerCard1>11)
                {
                    dealerCard1 = 10;
                }
                if (dealerCard2 >11)
                {
                    dealerCard2 = 10;
                }
                #endregion

                Console.SetCursorPosition(35, 9);
                Console.WriteLine($"{dealerCard1}");
                Console.SetCursorPosition(35, 13);
                Console.WriteLine($"{playerCard1}\t{playerCard2}");
                dealerCardTot = dealerCard1 + dealerCard2;
                playerCardTot = playerCard1 + playerCard2;
                
                switch (dealerCardTot)                              // reapeet after every card
                {
                    case 21:
                        win = false;
                        if(playerCardTot == dealerCardTot)
                        tie = true;

                        break;
                        
                }

                if (playerCardTot>22)
                {
                    Console.WriteLine($"your cards are {playerCardTot}");
                    win = false;
                }
                else if (playerCardTot == 21)
                {
                   multiplaier = 2.5m;
                    if (playerCardTot == dealerCardTot)
                    {
                        Console.WriteLine($"your cards are {playerCardTot}");
                        tie = true;
                        Console.SetCursorPosition(35, 9);
                        Console.WriteLine($"{dealerCard1}\t{dealerCard2}\t{dealerCard3}");
                    }
                    else
                    {
                        Console.WriteLine($"your cards are {playerCardTot}");
                        win = true;
                    }   
                }
                #region action
                else if (playerCardTot<21) //de actie
                {
                    Console.WriteLine($"your cards are {playerCardTot}");
                    Console.SetCursorPosition(15, 15);
                    Console.WriteLine("what do you want to do you can\nhit/1\tstand/2\tdouble/3");
                  Action =int.Parse( Console.ReadLine());

                    #region new cards
                    playerCard3 = random.Next(2, 14);
                    playerCard4 = random.Next(2, 14);
                    playerCard5 = random.Next(2, 14);
                    dealerCard3 = random.Next(2, 14);
                    dealerCard4 = random.Next(2, 14);
                    dealerCard5 = random.Next(2, 14);
                    if (playerCard3 > 11)
                    {
                        playerCard3 = 10;
                    }
                    if (playerCard4 > 11)
                    {
                        playerCard4 = 10;
                    }
                    if (playerCard5 > 11)
                    {
                        playerCard5 = 10;
                    }
                    if (dealerCard3 > 11)
                    {
                        dealerCard3 = 10;
                    }
                    if (dealerCard4 > 11)
                    {
                        dealerCard4 = 10;
                    }
                    if (dealerCard5 > 11)
                    {
                        dealerCard5 = 10;
                    }
                    #endregion

                    switch (Action)
                    {
                        case 1:
                            
                            Console.SetCursorPosition(35, 13);
                            Console.WriteLine($"{playerCard1}\t{playerCard2}\t{playerCard3}");
                            Console.SetCursorPosition(35, 9);
                            Console.WriteLine($"{dealerCard1}\t{dealerCard2}");
                            Console.SetCursorPosition(35, 14);
                            dealerCardTot = dealerCard1 + dealerCard2;
                            playerCardTot = playerCard1 + playerCard2 + playerCard3;
                            Console.SetCursorPosition(0, 14);
                            Console.WriteLine($"your cards are {playerCardTot}");
                            if (playerCardTot<=21)
                            {
                                Console.SetCursorPosition(0, 19);
                                Console.WriteLine("do you want to hit or stand  hit=1/stand =2");
                                int hit =int.Parse(Console.ReadLine());
                                if (hit == 1&&playerCardTot <22)
                                {
                                    dealerCardTot = dealerCard1 + dealerCard2 + dealerCard3;
                                    playerCardTot = playerCard1 + playerCard2 + playerCard3 + playerCard4;
                                    Console.SetCursorPosition(35, 13);
                                    Console.WriteLine($"{playerCard1}\t{playerCard2}\t{playerCard3}\t{playerCard4}");
                                    Console.SetCursorPosition(35, 9);
                                    Console.WriteLine($"{dealerCard1}\t{dealerCard2}");
                                    Console.SetCursorPosition(0, 19);
                                    Console.WriteLine("do you want to hit or stand  hit=1/stand =2");
                                    hit = int.Parse(Console.ReadLine());
                                    if (hit == 1&&playerCardTot<22)
                                    {
                                        dealerCardTot = dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
                                        playerCardTot = playerCard1 + playerCard2 + playerCard3 + playerCard4 + playerCard5;
                                        Console.SetCursorPosition(35, 13);
                                        Console.WriteLine($"{playerCard1}\t{playerCard2}\t{playerCard3}\t{playerCard4}\t{playerCard5}");
                                        Console.SetCursorPosition(35, 9);
                                        Console.WriteLine($"{dealerCard1}\t{dealerCard2}\t{dealerCard3}\t{dealerCard4}");
                                        Console.SetCursorPosition(0, 19);
                                        Console.WriteLine("do you want to hit or stand  hit=1/stand =2");
                                        hit = int.Parse(Console.ReadLine());
                                    }
                                    #region stand afterhit3
                                    else
                                    {
                                        if (dealerCardTot > 16)                          
                                        {

                                            if (dealerCardTot > playerCardTot)
                                            {
                                                win = false;
                                            }
                                            else
                                            {
                                                win = true;
                                            }

                                        }
                                        else if (dealerCardTot <= 16)
                                        {
                                            Console.SetCursorPosition(35, 9);
                                            Console.WriteLine($"{dealerCard1}\t{dealerCard2}\t{dealerCard3}");
                                            dealerCardTot = dealerCard1 + dealerCard2 + dealerCard3;
                                            if (dealerCardTot <= 16)
                                            {
                                                Console.SetCursorPosition(35, 9);
                                                Console.WriteLine($"{dealerCard1}\t{dealerCard2}\t{dealerCard3}\t{dealerCard4}");
                                                dealerCardTot = dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
                                                if (dealerCardTot <= 16)
                                                {
                                                    Console.SetCursorPosition(35, 9);
                                                    Console.WriteLine($"{dealerCard1}\t{dealerCard2}\t{dealerCard3}\t{dealerCard4}\t{dealerCard5}");
                                                    dealerCardTot = dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4 + dealerCard5;
                                                }
                                                else
                                                {
                                                    if (dealerCardTot > playerCardTot)
                                                    {
                                                        win = false;
                                                    }
                                                    else
                                                    {
                                                        win = true;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (dealerCardTot > playerCardTot)
                                                {
                                                    win = false;
                                                }
                                                else
                                                {
                                                    win = true;
                                                }
                                            }

                                        }
                                        else
                                        {
                                            if (dealerCardTot > playerCardTot)
                                            {
                                                win = false;
                                            }
                                            else
                                            {
                                                win = true;
                                            }
                                        }



                                    }
                                    #endregion
                                    #region stand after hit2
                                }
                                else
                                {
                                     // stand 
                                }
                            }
                            else
                            {
                                win = false;
                            }
                            break;
                        case 2: // stand
                            
                            Console.SetCursorPosition(35, 9); 
                            Console.WriteLine($"{dealerCard1}\t{dealerCard2}");                          // mutch work still needed actions need a split
                            dealerCardTot = dealerCard1 + dealerCard2;
                            playerCardTot = playerCard1 + playerCard2;
                            if (dealerCardTot>16)                        //stand = calculating from dealers side    
                            {
                                
                                if (dealerCardTot>playerCardTot)
                                {
                                    win = false;
                                }
                                else
                                {
                                    win = true;
                                }

                            }
                            else if (dealerCardTot<=16)
                            {
                                Console.SetCursorPosition(35, 9);
                                Console.WriteLine($"{dealerCard1}\t{dealerCard2}\t{dealerCard3}");
                                dealerCardTot = dealerCard1 + dealerCard2 + dealerCard3;
                                if (dealerCardTot<=16)
                                {
                                    Console.SetCursorPosition(35, 9);
                                    Console.WriteLine($"{dealerCard1}\t{dealerCard2}\t{dealerCard3}\t{dealerCard4}");
                                    dealerCardTot = dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4;
                                    if (dealerCardTot<=16)
                                    {
                                        Console.SetCursorPosition(35, 9);
                                        Console.WriteLine($"{dealerCard1}\t{dealerCard2}\t{dealerCard3}\t{dealerCard4}\t{dealerCard5}");
                                        dealerCardTot = dealerCard1 + dealerCard2 + dealerCard3 + dealerCard4+dealerCard5;
                                    }
                                    else
                                    {
                                        if (dealerCardTot > playerCardTot)
                                        {
                                            win = false;
                                        }
                                        else
                                        {
                                            win = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (dealerCardTot > playerCardTot)
                                    {
                                        win = false;
                                    }
                                    else
                                    {
                                        win = true;
                                    }
                                }

                            }
                            else
                            {
                                if (dealerCardTot > playerCardTot)
                                {
                                    win = false;
                                }
                                else
                                {
                                    win = true;
                                }
                            }



                            break;
                        case 3:

                            
                            if (inzet>score)
                            {
                                Console.SetCursorPosition(0, 2);
                                Console.WriteLine($"\t\t\t\t\tyou have {score} euro.");


                                Console.SetCursorPosition(0, 17);
                                Console.WriteLine("you dont have enough money to place this bet");
                                Console.WriteLine($"what is your new bet <{score}");                                          // inzet aanvraag
                                inzet = int.Parse(Console.ReadLine());
                            }
                            score -= inzet;
                            Console.SetCursorPosition(35, 13);
                            Console.WriteLine($"{playerCard1}\t{playerCard2}\t{playerCard3}");
                            Console.SetCursorPosition(35, 9);
                            Console.WriteLine($"{dealerCard1}\t{dealerCard2}");
                            Console.SetCursorPosition(0, 14);
                            dealerCardTot = dealerCard1 + dealerCard2;
                            playerCardTot = playerCard1 + playerCard2 + playerCard3;
                            Console.WriteLine($"your cards are {playerCardTot}");
                            //if (dealerCardTot > 21) // usefull later if dealer busted
                            //{
                            //    tie = false;
                            //    win = true;
                            //    Console.SetCursorPosition(35, 9);
                            //    Console.WriteLine($"{dealerCard1}\t{dealerCard2}\t{dealerCard3}");
                            //}
                            //else if (dealerCardTot <18)
                            //{

                            //}
                                break;
                    }
                }
                #endregion


                #region dealerbusted

                if (dealerCardTot > 21) // usefull later if dealer busted
                {
                    win = true;
                    Console.SetCursorPosition(35, 9);
                    Console.WriteLine($"{dealerCard1}\t{dealerCard2}\t{dealerCard3}");
                    Console.SetCursorPosition(35, 13);
                    Console.WriteLine($"{playerCard1}\t{playerCard2}\t{playerCard3}");

                }
                #endregion


                #region score and multyplaier
                if (win)
                {
                    winst = inzet * multiplaier;
                    score += winst;
                    
                }
                else if (tie)
                {
                    multiplaier = 1;
                    winst = inzet * multiplaier;
                    score += winst;
                }
                #endregion
                Console.SetCursorPosition(0, 20);
                Console.WriteLine($"you have {score} euro.\ndo you want to contineu playing.y/n");
                contineu = Console.ReadLine();
                
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}
