using System;
using System.Collections.Generic;
using System.Text;

namespace FindTheWayOut_Game
{
    class Fight
    {
        Monsters _monsters = new Monsters();
        Random rnd = new Random();
        public void Stage1FightEvent(Player player)
        {
            int MonsterCount = _monsters.Tier1Monsters().Count;
            int MonsterIndex = rnd.Next(0, MonsterCount);
            var Monster = _monsters.Tier1Monsters()[MonsterIndex];

            player.Health -= Monster.Attack;
            Start.DisplayPlayerStats(player);
        }
        //gameover metod
    }
}
