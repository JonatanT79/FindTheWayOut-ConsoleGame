using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheWayOut_Game
{
    class Movement
    {
        public Coordinate PlayerChar { get; set; }
        Fight _fight = new Fight();
        public void MoveCharacter(Player player)
        {
            ConsoleKeyInfo keyInfo;

            //loopa igenom gå-kommandot så länge villkoret är true
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                if (keyInfo.Key == ConsoleKey.UpArrow || keyInfo.Key == ConsoleKey.W)
                {
                    // anropar metoden och minskar y koordinaten med 1
                    ModifyPosition(0, -1, player);
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow || keyInfo.Key == ConsoleKey.D)
                {
                    // anropar metoden och ökar x koordinaten med 1
                    ModifyPosition(1, 0, player);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow || keyInfo.Key == ConsoleKey.S)
                {
                    ModifyPosition(0, 1, player);
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow || keyInfo.Key == ConsoleKey.A)
                {
                    ModifyPosition(-1, 0, player);
                }
            }
        }

        public void ModifyPosition(int x, int y, Player player)
        {
            Coordinate NewHeroPosition = new Coordinate()
            {
                // om x är 1 och y är 0 --> x = Hero.x(Gubbens startposition x) + 1, gubben gick höger
                x = PlayerChar.x + x,
                y = PlayerChar.y + y
            };

            string MapSymbol = Map.Stage1Map[NewHeroPosition.y, NewHeroPosition.x - 44];
            if (CanMove(MapSymbol, NewHeroPosition.x, NewHeroPosition.y, player))
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

        public bool CanMove(string MapSymbol, int XCoord, int YCoord, Player player)
        {
            var PlayerInventory = player.Inventory;

            if (MapSymbol == "#")
            {
                return false;
            }
            else if (MapSymbol == "A")
            {
                Items _items = new Items() { Name = "Axe" };
                PlayerInventory.Add(_items);
                Map.Stage1Map[YCoord, XCoord - 44] = ".";

                Console.SetCursorPosition(53, 16);
                Console.WriteLine("Collected 1 Axe");
                Start.DisplayPlayerInventory(PlayerInventory);
            }
            else if (MapSymbol == "S")
            {
                Items _items = new Items() { Name = "Sword" };
                PlayerInventory.Add(_items);
                Map.Stage1Map[YCoord, XCoord - 44] = ".";

                Console.SetCursorPosition(53, 15);
                Console.WriteLine("Collected 1 Sword");
                Start.DisplayPlayerInventory(PlayerInventory);
            }
            else if (MapSymbol == "K")
            {
                Items _items = new Items() { Name = "Key" };
                PlayerInventory.Add(_items);
                Map.Stage1Map[YCoord, XCoord - 44] = ".";

                Console.SetCursorPosition(53, 15);
                Console.WriteLine("Collected 1 Key");
                Start.DisplayPlayerInventory(PlayerInventory);
            }
            else if (MapSymbol == "D")
            {
                var AxeSearch = from e in PlayerInventory
                                where e.Name == "Axe"
                                group e by e.Name into Item
                                select new
                                {
                                    Count = Item.Count()
                                };

                var AxeCount = 0;
                if (AxeSearch.Count() != 0)
                {
                    AxeCount = AxeSearch.ToList()[0].Count;
                }

                if (AxeCount > 0)
                {
                    var Axe = PlayerInventory.Where(d => d.Name == "Axe").FirstOrDefault();
                    PlayerInventory.Remove(Axe);
                    Map.Stage1Map[YCoord, XCoord - 44] = ".";
                    Start.DisplayPlayerInventory(PlayerInventory);

                    return true;
                }

                return false;
            }
            else if (MapSymbol == "M")
            {
                var SwordSearch = from e in PlayerInventory
                                  where e.Name == "Sword"
                                  group e by e.Name into Item
                                  select new
                                  {
                                      Count = Item.Count()
                                  };

                int SwordCount = 0;
                if (SwordSearch.Count() != 0)
                {
                    SwordCount = SwordSearch.ToList()[0].Count;
                }

                if (SwordCount > 0)
                {
                    //ifsats -> kolla vilken stage
                    _fight.Stage2FightEvent(player);

                    var Sword = PlayerInventory.Where(e => e.Name == "Sword").FirstOrDefault();
                    PlayerInventory.Remove(Sword);
                    Map.Stage1Map[YCoord, XCoord - 44] = ".";
                    Start.DisplayPlayerInventory(PlayerInventory);

                    return true;
                }

                return false;
            }
            else if (MapSymbol == "E")
            {
                var KeySearch = from e in PlayerInventory
                                where e.Name == "Key"
                                group e by e.Name into Item
                                select new
                                {
                                    Count = Item.Count()
                                };

                int KeyCount = 0;
                if (KeySearch.Count() != 0)
                {
                    KeyCount = KeySearch.ToList()[0].Count;
                }

                if (KeyCount != 0)
                {
                    var Key = PlayerInventory.Where(e => e.Name == "Key").FirstOrDefault();
                    PlayerInventory.Remove(Key);
                    Map.Stage1Map[YCoord, XCoord - 44] = ".";
                    Start.DisplayPlayerInventory(PlayerInventory);

                    //Stage 2
                    Console.Clear();
                    Console.WriteLine("Loading next map...");
                    return true;
                }

                return false;
            }

            return true;
        }

        public void SetPlayerStartPosition(Player player)
        {
            // Tilldelar gubbens startposition + initierar PlayerChar
            PlayerChar = new Coordinate() { x = 46, y = 12 };

            // en del av startpositionen, sätt alltid 0,0 för att gubben ska utgå från startpositionen vid koordinaten ovanför ^^
            ModifyPosition(0, 0, player);
        }
    }
}
