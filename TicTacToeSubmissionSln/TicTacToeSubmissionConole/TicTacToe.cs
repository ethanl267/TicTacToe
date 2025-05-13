
using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }


        public void Run()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 20);
            Console.Write("Player 1(X)");

            Console.SetCursorPosition(2, 22);
            Console.Write("player 2(0)");

            bool isPlayer1Turn = true;
            

            while (true)
            {

                if (isPlayer1Turn)
                {
                    Console.SetCursorPosition(2, 24);
                    Console.Write("Player 1 please enter Row:");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 26);
                    Console.Write("Player 1 Please enter Column:");
                    var column = Console.ReadLine();

                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                }
                else
                {
                    Console.SetCursorPosition(2, 24);
                    Console.Write("Player 2 Please enter Row:   ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 26);
                    Console.Write("Player 2 Please enter Column: ");
                    var column = Console.ReadLine();

                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);
                }

                isPlayer1Turn = !isPlayer1Turn;

                Console.SetCursorPosition(2, 23);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(2, 24);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(2, 26);
                Console.Write(new string(' ', Console.WindowWidth));


            }

        }

    }
}