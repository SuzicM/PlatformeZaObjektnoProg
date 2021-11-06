using PlatformeZaObjektnoProg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformeZaObjektnoProg
{
    class Program
    {
        


        public static void PrintAllUsers()
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }

        public static void AddNewUser()
        {

            Adress adress = new Adress
            {
                Country = "Srbija",
                City = "Novi Sad",
                Street = "Cara Dusana",
                Number = "1b",
            };

            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter JMBG: ");
            string jmbg = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter sex: ");
            Enum.TryParse(Console.ReadLine(), out ESex sex);

            Console.WriteLine("Enter users role: ");
            Enum.TryParse(Console.ReadLine(), out EUserRole userRole);

            User newUser = new User
            {
                Name = name,
                LastName = lastName,
                Jmbg = jmbg,                                        //cuvanje u memoriji ne sluzi ni za sta
                Password = password,
                Email = email,
                Adress = adress,
                Sex = sex,
                UserRole = userRole
            };

            users.Add(newUser);
            Console.WriteLine("Successfully created new user! ");
        }

        public static void EditUsers()
        {
            Console.WriteLine("Unesi JMBG korisnika: ");            //koristiti username
            string jmbg = Console.ReadLine();
            int index = ReturnIndexUserPosition(jmbg);
            if (index > -1)
            {
                //menjamo korisnika
            }else
            {
                Console.WriteLine("Ovaj korisnik ne postoji!");
            }
        }


        public static int ReturnIndexUserPosition(string jmbg)
        {
            for (int i = 0; i < users.Count; i++ )
            {
                if (users[i].Jmbg.Equals(jmbg))
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Initialize();
            string Option = "";
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("********User menu********");
                Console.WriteLine("\n");
                Console.WriteLine("[1] Ispis korisnika");
                Console.WriteLine("[2] Unos novog korisnika");
                Console.WriteLine("[3] Izmena korisnika");
                Console.WriteLine("[4] Brisanje korisnika");
                Console.WriteLine("[5] Kraj");
                Console.WriteLine("\n");
                Console.WriteLine("Izaberi akciju: ");

                Option = Console.ReadLine();
                switch ( Option )
                {
                    case "1":
                        PrintAllUsers();
                        break;
                    case "2":
                        AddNewUser();
                        break;
                    case "3":
                        EditUsers();
                        break;
                    default:
                        Console.WriteLine("Pogresan unos!");
                        break;
                }
               
            } 
            while (!Option.Equals("5"));
            
        }
        
        
    }
}
