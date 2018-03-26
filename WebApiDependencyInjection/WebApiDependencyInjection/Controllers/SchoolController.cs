using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDependencyInjection.BusinessLayer;
using WebApiDependencyInjection.Models;

namespace WebApiDependencyInjection.Controllers
{
    public class SchoolController : ApiController
    {
        private ISchoolBusinessLayer _objSchoolBal;
        public SchoolController(ISchoolBusinessLayer objSchoolBal)
        {
            _objSchoolBal = objSchoolBal;
        }
        [HttpGet]
        public School Get()
        {
            return _objSchoolBal.GetSchoolInformation();
        }
    }
}
