using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ePregledi_API.Models;

namespace ePregledi_API.Controllers
{
    public class DoktorController : ApiController
    {
        private ePreglediEntities context = new ePreglediEntities();
        public DoktorController()
        {

        }

        // /api/doktor
        public List<Doktor> GetDoktors()
        {
            return context.Doktors.Include("Osoba").ToList();
        }
    }
}
