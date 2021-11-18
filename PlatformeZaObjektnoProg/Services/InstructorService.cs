using PlatformeZaObjektnoProg.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformeZaObjektnoProg.Services
{
    public class InstructorService : IUserService, IInstructorService
    {
        public void ReadUsers(string fileName)
        {
            Data.Instance.Instructors = new List<Instructor>();
            using (StreamReader file = new StreamReader(@"../../Resources/" + fileName))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] InstructorFromFile = line.Split('|');

                    //pronalazenje korisnika
                    User user = Data.Instance.Users.Find(u => u.Jmbg.Equals(InstructorFromFile[1]));

                    Instructor instructor = new Instructor
                    {
                        Training = InstructorFromFile[0],
                        User = user
                    };

                    Data.Instance.Instructors.Add(instructor);
                }
            }
        }

       

        public void SaveUsers(string fileName)
        {
            using (StreamWriter file = new StreamWriter(@"../../Resources/" + fileName))
            {
                foreach (Instructor instructor in Data.Instance.Instructors)
                {
                    file.WriteLine(instructor.InstructorToFile());
                }
            }
        }


        public List<User> returnMyCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
