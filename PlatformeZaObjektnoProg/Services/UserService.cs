using PlatformeZaObjektnoProg.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformeZaObjektnoProg.Services
{
    public class UserService : IUserService
    {
        public void ReadUsers(string fileName)
        {
            Data.Instance.Users = new List<User>();
            using (StreamReader file = new StreamReader(@"../../Resources/" + fileName))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] UserFromFile = line.Split('|');
                    Enum.TryParse(UserFromFile[5], out ESex sex);
                    Enum.TryParse(UserFromFile[6], out EUserRole userRole);
                    Boolean.TryParse(UserFromFile[7], out Boolean notDeleted);

                    User user = new User
                    {
                        Name = UserFromFile[0],
                        LastName = UserFromFile[1],
                        Email = UserFromFile[2],
                        Jmbg = UserFromFile[3],
                        Password = UserFromFile[4],
                        Sex = sex,
                        UserRole = userRole,
                        NotDeleted = notDeleted
                    };

                    Data.Instance.Users.Add(user);
                }
            }
        }

        public void SaveUsers(string fileName)
        {
            using (StreamWriter file = new StreamWriter(@"../../Resources/" + fileName))
            {
                foreach (User user in Data.Instance.Users)
                {
                    file.WriteLine(user.UsersToFile());
                }
            }
        }
    }
}
