using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IGamerCheckService
    {
     public bool CheckIfRealPerson(Gamer gamer)
     {
         return true;
     }

    }
}
