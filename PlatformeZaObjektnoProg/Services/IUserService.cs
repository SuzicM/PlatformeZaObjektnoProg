using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformeZaObjektnoProg.Services
{
    public interface IUserService
    {
        void SaveUsers(string fileName);
        void ReadUsers(string fileName);
    }
}
