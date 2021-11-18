using PlatformeZaObjektnoProg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformeZaObjektnoProg.Services
{
    public interface IInstructorService
    {
        List<User> returnMyCustomers();
    }
}
