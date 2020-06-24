using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindTheWayOut_Game
{
    class Player
    {
        public string Name { get; set; }
        public int Health { get; set; } = 30;

        public List<Items> Inventory = new List<Items>();
    }
}
