using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformeZaObjektnoProg.Entity
{
    public class Instructor
    {
        private string _training;
        public string Training
        {
            get { return _training; }
            set { _training = value; }
        }


        private User _user;
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public override string ToString()
        {
            return User.ToString() + "Ja sam instruktor";
        }

        public string InstructorToFile()
        {
            return Training + "|" +User.Jmbg;
        }
    }
}
