using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CustomerManger : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Müşteri Kaydı Silindi");
        }

        public void Save(Gamer gamer)
        {
            Console.WriteLine( gamer.FirstName +" Kullanıcı kayıt edildi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "kullanıcı bilgileri güncellendi.");
        }

        public virtual void Kayit(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
