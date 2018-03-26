using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDependencyInjection.Models;

namespace WebApiDependencyInjection.DataAccessLayer
{
    public interface ISchoolDataAccessLayer
    {
        School GetSchoolInformation();
    }
}
