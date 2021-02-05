using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() {Id =1, Name = "Pubg",Price = 500};
            Game game2 = new Game() { Id = 2, Name = "Call of Duty", Price = 750 };
            Gamer gamer1 = new Gamer()
            {
                Id = 1, FirstName = "TUFAN", LastName = "ÇEVİK", BirthYear = new DateTime(1993,04,18), NationalityId = "54493378456",
                CreditCardNumber = 132465798, UserName = "evanes12"
            };
            Gamer gamer2 = new Gamer()
            {
                Id = 1,
                FirstName = "Emin",
                LastName = "Çölaşan",
                BirthYear = new DateTime(1991, 11, 05),
                NationalityId = "54493378456",
                CreditCardNumber = 132465798,
                UserName = "Emin12"
            };


            Campaign campaign = new Campaign() {GameId = 3, CampaignName = "Back to Sunny", RateOfDiscount = 15};
            CampanyManager campanyManager = new CampanyManager();
            campanyManager.Add(campaign);
            campanyManager.Delete(campaign);
            campanyManager.Update(campaign);


            CustomerManger customerManger = new GamerManager(new MernisServiceAdapter());
            customerManger.Save(gamer1);
            customerManger.Save(gamer2);
            //customerManger.Delete(gamer1);

            Sales sales1 = new Sales() {Game = game1.Name, Gamer = gamer1.FirstName};
            Sales sales2 = new Sales() { Game = game2.Name, Gamer = gamer2.FirstName };
            SalesManager salesManager = new SalesManager();
            salesManager.Buy(game1,gamer1);
            salesManager.Buy(game2, gamer2);

            Console.ReadLine();
        }
    }
}
