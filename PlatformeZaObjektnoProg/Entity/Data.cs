using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformeZaObjektnoProg.Entity
{
    public sealed class Data
    {
        private static readonly Data instance = new Data();
        static Data()
        {

        }
        
        public static Data Instance
        {
            get { return Instance; }
        }

        public List<User> Users { get; set; }
        //static List<Instractor> instractors = new List<Instractor>();

        public void Initialize()
        {
            Adress adress = new Adress
            {
                Country = "Srbija",
                City = "Novi Sad",
                Street = "Cara Dusana",
                Number = "1b",
            };
            User user1 = new User
            {
                Name = "Marko",
                LastName = "Markovic",
                Jmbg = "1928471827421",
                Sex = ESex.M,
                Adress = adress,
                Email = "markom@gmail.com",
                Password = "marko123",
                UserRole = EUserRole.Administrator,
            };

            User user2 = new User
            {
                Name = "Nikola",
                LastName = "Nikolic",
                Jmbg = "7318927391846",
                Sex = ESex.M,
                Adress = adress,
                Email = "nikolan@gmail.com",
                Password = "123nikolic",
                UserRole = EUserRole.Polaznik,
            };

            /*Instructor instructor1 = new Instructor
            {
                User = user1
            };
            */
            Users.Add(user1);
            Users.Add(user2);

        }
    }
}
