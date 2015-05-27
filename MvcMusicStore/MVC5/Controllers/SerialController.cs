using MVC5.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MVC5.Controllers
{
    public class SerialController : ApiController
    {
        private ICalculatorService service;

        public ICalculatorService Service 
        {
            get
            {
                if (null == this.service)
                    this.service = Configuration.DependencyResolver.GetService(typeof(ICalculatorService)) as ICalculatorService;
                return this.service;
            }
        }

        [ResponseType(typeof(int))]
        public IHttpActionResult GetSum(int id)
        {
            var result = this.Service.Sum(10, id);
            return Ok(result);
        }
    }
}
