﻿using System;

namespace FindTheWayOut_Game
{
    class Movement
    {
        public Coordinate PlayerChar { get; set; }

        public void MoveCharacter()
        {
            ConsoleKeyInfo keyInfo;

            //loopa igenom gå-kommandot så länge villkoret är true
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                if (keyInfo.Key == ConsoleKey.UpArrow || keyInfo.Key == ConsoleKey.W)
                {
                    // anropar metoden och minskar y koordinaten med 1
                    ModifyPosition(0, -1);
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow || keyInfo.Key == ConsoleKey.D)
                {
                    // anropar metoden och ökar x koordinaten med 1
                    ModifyPosition(1, 0);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow || keyInfo.Key == ConsoleKey.S)
                {
                    ModifyPosition(0, 1);
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow || keyInfo.Key == ConsoleKey.A)
                {
                    ModifyPosition(-1, 0);
                }
            }
        }

        public void ModifyPosition(int x, int y)
        {
            Coordinate NewHeroPosition = new Coordinate()
            {
                // om x är 1 och y är 0 --> x = Hero.x(Gubbens startposition x) + 1, gubben gick höger
                x = PlayerChar.x + x,
                y = PlayerChar.y + y
            };
            string GetMapSymbol = Map.Stage1Map[NewHeroPosition.y, NewHeroPosition.x - 44];

            if (CanMove(GetMapSymbol))
            {
                // anropar metoden som tar bort det föregående tecknet efter förflyttning
                RemoveHero();

                Console.SetCursorPosition(NewHeroPosition.x, NewHeroPosition.y);
                Console.ForegroundColor = ConsoleColor.Green;

                // skriv ut tecknet på gubbens nya position
                Console.Write("@");
                Console.ResetColor();
                // Ge den gamla "Hero" den nya positionen
                PlayerChar = NewHeroPosition;
            }
        }
        public void RemoveHero()
        {
            // skriver ut en punkt på gubbens gamla position i kartan
            Console.SetCursorPosition(PlayerChar.x, PlayerChar.y);
            Console.Write(".");
        }

        public bool CanMove(string MapSymbol)
        {
            if (MapSymbol == "#")
            {
                return false;
            }

            return true;
        }

        public void SetPlayerStartPosition()
        {
            // Tilldelar gubbens startposition + initierar PlayerChar
            PlayerChar = new Coordinate() { x = 46, y = 12 };

            // en del av startpositionen, sätt alltid 0,0 för att gubben ska utgå från startpositionen vid koordinaten ovanför ^^
            ModifyPosition(0, 0);
        }
    }
}
