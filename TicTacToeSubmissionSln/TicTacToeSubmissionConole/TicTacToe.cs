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
            
            Console.SetCursorPosition(2, 19);

            Console.Write("Player X");

            Console.SetCursorPosition(2, 20);

            Console.Write("player Y");
            int counter = 21;

            Console.SetCursorPosition(2, counter);


            

            while (true)
            {
                
                Console.Write("Please Enter Row: ");
                var row = Console.ReadLine();

                Console.SetCursorPosition(2, counter+1);

                Console.Write("Please Enter Column: ");
                var column = Console.ReadLine();


                // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                Console.Write("Please Enter Row: ");
                var rowO = Console.ReadLine();

                Console.SetCursorPosition(2, counter + 1);

                Console.Write("Please Enter Column: ");
                var columnO = Console.ReadLine();
                _boardRenderer.AddMove(int.Parse(rowO), int.Parse(columnO), PlayerEnum.O, true);

                counter = counter + 2;
            }
        }

    }
}
