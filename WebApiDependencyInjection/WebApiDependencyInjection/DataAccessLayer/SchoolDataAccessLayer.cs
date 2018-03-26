using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDependencyInjection.Models;

namespace WebApiDependencyInjection.DataAccessLayer
{
    public class SchoolDataAccessLayer : ISchoolDataAccessLayer
    {
        public School GetSchoolInformation()
        {
            return new School
            {
                Address = "Kolkata",
                Id = 1,
                Name = "My .Net School",
                PhoneNo = "XXXXXXXXXX"
            };
        }
    }
}