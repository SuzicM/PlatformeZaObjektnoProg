using PlatformeZaObjektnoProg.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformeZaObjektnoProg.Entity
{
    public sealed class Data
    {
        private static readonly Data instance = new Data();
        private IUserService userService;
        private IUserService instructorService;

        private Data()
        {
            userService = new UserService();
            instructorService = new InstructorService();
        }
        static Data()
        {

        }
        
        public static Data Instance
        {
            get { return instance; }
        }

        public List<User> Users { get; set; }
        public List<Instructor> Instructors { get; set; }

        public void Initialize()
        {
            Users = new List<User>();
            Instructors = new List<Instructor>();

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
                NotDeleted = true
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
                NotDeleted = true
            };


            Instructor instructor1 = new Instructor
            {
                User = user1,
                Training = "trening1"
            };
            
            Users.Add(user1);
            Users.Add(user2);
            Instructors.Add(instructor1);
           
        }

        public void SaveEntities(string fileName)
        {
            if(fileName.Contains("users"))
            {
                userService.SaveUsers(fileName);
            }else if (fileName.Contains("instructors"))
            {
                instructorService.SaveUsers(fileName);
            }
        }


        public void ReadEntities(string fileName)
        {
            if (fileName.Contains("users"))
            {
                userService.ReadUsers(fileName);
            }
            else if (fileName.Contains("instructors"))
            {
                instructorService.ReadUsers(fileName);
            }
        }

    }
}
