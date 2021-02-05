using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), 
                gamer.FirstName,
                gamer.LastName,
                gamer.BirthYear.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
