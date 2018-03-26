using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDependencyInjection.DataAccessLayer;
using WebApiDependencyInjection.Models;

namespace WebApiDependencyInjection.BusinessLayer
{
    public class SchoolBusinessLayer : ISchoolBusinessLayer
    {
        private ISchoolDataAccessLayer _objSchoolDal;
        public SchoolBusinessLayer(ISchoolDataAccessLayer objSchoolDal)
        {
            _objSchoolDal = objSchoolDal;
        }
        public School GetSchoolInformation()
        {
            return _objSchoolDal.GetSchoolInformation();
        }
    }
}