﻿using System;

namespace FindTheWayOut_Game
{
    class Map
    {
        public string[,] Stage1Map = new string[15, 33]
             {
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#","E","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".","S",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#","#","#" },
                {"#","#",".",".",".",".",".",".",".",".",".",".",".","M",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","A",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","#","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","#","D","#","#",".",".","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","#",".",".","#",".",".","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","#","#","#","#",".","S","#",".",".","#",".","#","#","#","#","#","#","#","#",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","A",".",".","#","#","#","#",".",".","#","#","#","M",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","D",".",".",".",".",".",".","#","#",".","#","#","D","#","#",".",".",".",".",".",".","A",".",".",".",".",".",".","#" },
                {"#",".",".",".","#",".",".",".",".",".",".",".",".",".","#",".",".","K","#",".",".",".",".",".",".","#",".",".",".",".",".",".","#" },
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" }
             };
        public string[,] Stage2Map = new string[15, 33]
             {
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" },
                {"#",".",".",".",".",".",".","#","#","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#","E","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".","S",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#","#","#" },
                {"#","#",".",".",".",".",".",".",".",".",".",".",".","M",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","A",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","#","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","#","D","#","#",".",".","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","#",".",".","#",".",".","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","#","#","#","#",".","S","#",".",".","#",".","#","#","#","#","#","#","#","#",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","A",".",".","#","#","#","#",".",".","#","#","#","M",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","D",".",".",".",".",".",".","#","#",".","#","#","D","#","#",".",".",".",".",".",".","A",".",".",".",".",".",".","#" },
                {"#",".",".",".","#",".",".",".",".",".",".",".",".",".","#",".",".","K","#",".",".",".",".",".",".","#",".",".",".",".",".",".","#" },
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" }
             };
        public string[,] Stage3Map = new string[15, 33]
             {
                {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" },
                {"#",".",".",".",".",".",".","#","#","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#",".","#","E","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".","S",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#",".","#","#","#" },
                {"#","#",".",".",".",".",".",".",".",".",".",".",".","M",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","A",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","#","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","#","D","#","#",".",".","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","#",".",".","#",".",".","#",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","#","#","#","#",".","S","#",".",".","#",".","#","#","#","#","#","#","#","#",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#","A",".",".","#","#","#","#",".",".","#","#","#","M",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","#" },
                {"#",".",".",".","D",".",".",".",".",".",".","#","#",".","#","#","D","#","#",".",".",".",".",".",".","A",".",".",".",".",".",".","#" },
                {"#",".",".",".","#",".",".",".",".",".",".",".",".",".","#",".",".","K","#",".",".",".",".",".",".","#",".",".",".",".",".",".","#" },
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
            }

            Console.ResetColor();
        }
        public void Stage2()
        {
            for (int row = 0; row < 15; row++)
            {
                Console.SetCursorPosition(44, row);

                for (int column = 0; column < 33; column++)
                {
                    var Symbol = Stage2Map[row, column];
                    CheckSymbol(Symbol);
                }
            }

            Console.ResetColor();
        }
        public void Stage3()
        {
            for (int row = 0; row < 15; row++)
            {
                Console.SetCursorPosition(44, row);
                for (int column = 0; column < 33; column++)
                {
                    string Symbol = Stage3Map[row, column];
                    CheckSymbol(Symbol);
                }
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
            else if (Symbol == "M")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            else if (Symbol == "K")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (Symbol == "A")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else if (Symbol == "S")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (Symbol == "D")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            else if (Symbol == "E")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }

            Console.Write(Symbol);
        }
    }
}
