using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WWWBewertungPortal.Models.Datenbank;
using WWWBewertungPortal.Services;

namespace WWWBewertungPortal.Controllers
{
    public class WWWBewertungPortalController : ApiController
    {
        private WWWBewertungPortalRepository wwwBewertungPortalRepository;

        public WWWBewertungPortalController()
        {
            this.wwwBewertungPortalRepository = new WWWBewertungPortalRepository();
        }

        public HttpResponseMessage Post(Tab_Benutzer benutzer)
        {
            this.wwwBewertungPortalRepository.SaveBenutzer(benutzer);
            var response = Request.CreateResponse<Tab_Benutzer>(System.Net.HttpStatusCode.Created, benutzer);
            return response;
        }
    }
}
