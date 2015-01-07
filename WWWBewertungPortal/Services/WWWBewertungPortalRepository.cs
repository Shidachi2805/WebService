using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WWWBewertungPortal.Models.Datenbank;

namespace WWWBewertungPortal.Services
{
    public class WWWBewertungPortalRepository
    {
        private WWWBewertungsModellContainer ThisContainer;

        public WWWBewertungPortalRepository()
        {
            ThisContainer = new WWWBewertungsModellContainer();
        }
        
        // Save Data in Database
        public bool SaveBenutzer(Tab_Benutzer benutzer)
        {
            try
            {
                ThisContainer.Tab_BenutzerSet.Add(benutzer);
                ThisContainer.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}