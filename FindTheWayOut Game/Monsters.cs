using System;
using System.Collections.Generic;
using System.Text;

namespace FindTheWayOut_Game
{
    class Monsters
    {
        public string Name { get; set; }

        //Monstret ska göra random skada på player - därav behövs inget hp
        public int Attack { get; set; }
        public List<Monsters> Tier1Monsters()
        {
            List<Monsters> MonsterList1 = new List<Monsters>()
            {
                new Monsters() { Name = "Slime", Attack = 2 },
                new Monsters() { Name = "Wolf", Attack = 3 }
            };

            return MonsterList1;
        }
        public List<Monsters> Tier2Monsters()
        {
            List<Monsters> MonsterList2 = new List<Monsters>()
            {
                new Monsters() { Name = "Onyx", Attack = 4 },
                new Monsters() { Name = "Centaur", Attack = 5 }
            };

            return MonsterList2;
        }
        public List<Monsters> Tier3Monsters()
        {
            List<Monsters> MonsterList3 = new List<Monsters>()
            {
                new Monsters() { Name = "Hydra", Attack = 6 },
                new Monsters() { Name = "Dragon", Attack = 7 }
            };

            return MonsterList3;
        }
    }
}
