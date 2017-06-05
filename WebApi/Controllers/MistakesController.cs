using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Services;
using WebApi.Services.Impls;

namespace WebApi.Controllers
{
    public class DefaultController : ApiController
    {

        private IMistakeService MistakeService = new MistakeServiceImpl();
        // GET: api/Default

        [Authorize]
        public Mistake Get()
        {

            return MistakeService.getMistake();
            //return new Mistake();
        }

        // POST: api/Default

        [Authorize]
        public void Post([FromBody] string json)
        {
            MistakeService.saveToFile(json);
        }
    }
}
