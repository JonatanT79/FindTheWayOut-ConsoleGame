using System;

namespace FindTheWayOut_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Map _map = new Map();
            Movement _movement = new Movement();
            _map.Stage1Map();
            _movement.SetPlayerStartPosition();
            _movement.GetDirection();
        }
    }
}
//kör debugg på movement systemet