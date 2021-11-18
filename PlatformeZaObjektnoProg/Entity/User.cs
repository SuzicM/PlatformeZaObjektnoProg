using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformeZaObjektnoProg.Entity
{
    public class User
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set {_lastName = value; }
        }

        private string _jmbg;

        public string Jmbg
        {
            get { return _jmbg; }
            set { _jmbg = value; }
        }

        private ESex _sex;

        public ESex Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private Adress _adress;

        public Adress Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set {_email = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private EUserRole _userRole;
        
        public EUserRole UserRole
        {
            get { return _userRole; }
            set { _userRole = value; }
        }

        private bool _notDeleted;

        public bool NotDeleted
        {
            get { return _notDeleted; }
            set { _notDeleted = value; }
        }



        public User() 
        {

        }
        public override string ToString()
        {
            return "User: " + Name + ". " + "Role: " + UserRole + "\n" + "Adress: " +  "\n" ;
        }
       
        public string UsersToFile()
        {
            return Name + "|" + LastName + "|" + Email + "|" + Jmbg + "|" + Password + "|" + Sex + "|" + UserRole + "|" + NotDeleted;
        }
    }
}
