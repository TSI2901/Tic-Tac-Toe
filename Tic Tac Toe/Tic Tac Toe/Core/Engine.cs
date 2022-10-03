using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac.Core.Contracts;
using Tic_Tac.Models;
using Tic_Tac.Utilities.Messages;

namespace Tic_Tac.Core
{
    internal class Engine : IEngine
    {
        private Board board;
        private Controler controler;
        public Engine()
        {
            board = new Board();
            controler = new Controler();
        }
        public void Run()
        {
            Console.WriteLine(IntroMessages.HelloMessage);
            Console.WriteLine(IntroMessages.TableMessage);
            Console.WriteLine(board.ShowTheEmptyBoard());
            int counter = 0;
            string winer = " ";
            while (counter <= 8)
            {
                if (counter % 2 == 0)
                {
                    Console.Write("Player one please enter a possition:");
                    int possition = int.Parse(Console.ReadLine());
                    try
                    {
                        controler.Player1Movement(possition,board);
                        if (board.IsTheareAWiner())
                        {
                            winer = "one";
                            break;
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        counter--;
                    }
                }
                else
                {
                    Console.Write("Player two please enter a possition:");
                    int possition = int.Parse(Console.ReadLine());
                    try
                    {
                        controler.Player2Movement(possition,board);
                        if (board.IsTheareAWiner())
                        {
                            winer = "two";
                            break;
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        counter--;
                    }
                }
                counter++;
            }
            if (winer == " ")
            {
                Console.WriteLine("No one wins");
            }
            else
            {
                Console.WriteLine($"Player {winer} is the winner");
            }
        }
    }
}
