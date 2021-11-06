using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformeZaObjektnoProg.Entity
{
    public class Adress
    {
        private int _password;

        public int Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _street;

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public Adress() 
        {
        
        }
        public override string ToString()
        {
            return "\n" + "   Street: " + Street + "\n" + "   Number: " + Number + "\n" + "   City: " + City + "\n" + "   Country: " + Country;
        }
    }
}
