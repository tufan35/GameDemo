using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class SalesManager
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " kullanıcı " + game.Name + " adlı oyunu satın aldı.");
        }
    }
}
