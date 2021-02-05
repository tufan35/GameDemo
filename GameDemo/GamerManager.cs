using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GameDemo
{
    class GamerManager: CustomerManger
    {
         IGamerCheckService _gamercheckService;

        public GamerManager(IGamerCheckService gamercheckService)
        {
            _gamercheckService = gamercheckService;
        }



        public override void Kayit(Gamer gamer)
        {
            if (_gamercheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Kayit Yanlış");
            }
        }

    }
}
