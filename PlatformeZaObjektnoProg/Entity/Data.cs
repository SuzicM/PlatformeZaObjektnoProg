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
                SaveUsers(fileName);
            }else if (fileName.Contains("instructors"))
            {
                SaveInstructors(fileName);
            }
        }

        private void SaveUsers(string fileName)
        {
            using (StreamWriter file = new StreamWriter(@"../../Resources/" + fileName))
            {
                foreach (User user in Users)
                {
                    file.WriteLine(user.UsersToFile());
                }
            }
        }

        private void SaveInstructors(string fileName)
        {
            using (StreamWriter file = new StreamWriter(@"../../Resources/" + fileName))
            {
                foreach (Instructor instructor in Instructors)
                {
                    file.WriteLine(instructor.InstructorToFile());
                }
            }
        }

        public void ReadEntities(string fileName)
        {
            if (fileName.Contains("users"))
            {
                ReadUsers(fileName);
            }
            else if (fileName.Contains("instructors"))
            {
                ReadInstructors(fileName);
            }
        }

        private void ReadUsers(string fileName)
        {
            Users = new List<User>();
            using(StreamReader file = new StreamReader(@"../../Resources/" + fileName))
            {
                string line;

                while((line = file.ReadLine()) != null)
                {
                    string[] UserFromFile = line.Split('|');
                    Enum.TryParse(UserFromFile[5], out ESex sex);
                    Enum.TryParse(UserFromFile[6], out EUserRole userRole);

                    User user = new User
                    {
                        Name = UserFromFile[0],
                        LastName = UserFromFile[1],
                        Email = UserFromFile[2],
                        Jmbg = UserFromFile[3],
                        Password = UserFromFile[4],
                        Sex = sex,
                        UserRole = userRole
                    };

                    Users.Add(user);
                }
            }
            
        }

        private void ReadInstructors(string fileName)
        {
            Instructors = new List<Instructor>();
            using (StreamReader file = new StreamReader(@"../../Resources/" + fileName))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] InstructorFromFile = line.Split('|');

                    //pronalazenje korisnika
                    User user = Users.Find(u => u.Jmbg.Equals(InstructorFromFile[1]));

                    Instructor instructor = new Instructor
                    {
                        Training = InstructorFromFile[0],
                        User = user
                    };

                    Instructors.Add(instructor);
                }
            }
        }

    }
}
