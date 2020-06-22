﻿using System;

namespace FindTheWayOut_Game
{
    class Map
    {
        public static string[,] Stage1Map = new string[15, 33]
             {
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","#","#","#","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","K",".",".","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","D",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" }
             };
        public void Stage1()
        {
            for (int row = 0; row < 15; row++)
            {
                Console.SetCursorPosition(44, row);

                for (int column = 0; column < 33; column++)
                {
                    var Symbol = Stage1Map[row, column];
                    CheckSymbol(Symbol);
                }

                Console.WriteLine("");
            }
            Console.ResetColor();
        }

        public static void CheckSymbol(string Symbol)
        {
            if (Symbol == "#")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (Symbol == ".")
            {
                Console.ResetColor();
            }
            else if (Symbol == "K")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.Write(Symbol);
        }
    }
}
