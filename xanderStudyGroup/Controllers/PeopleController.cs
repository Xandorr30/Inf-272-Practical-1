using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace xanderStudyGroup.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult People()
        {
            List<Models.myClass> people = new List<Models.myClass>();

            people.Add(new Models.myClass { StudentNumber = "u24742644", Name = "Xander", Surname = "Steyn", Email = "u24742644@tuks.co.za" });
            people.Add(new Models.myClass { StudentNumber = "u24562816", Name = "Jean", Surname = "Du Toit", Email = "u24562816@tuks.co.za" });
            people.Add(new Models.myClass { StudentNumber = "u24566284", Name = "Xander", Surname = "Visagie", Email = "u24566284@tuks.co.za" });
            people.Add(new Models.myClass { StudentNumber = "u24365812", Name = "Steyn", Surname = "Coetzee", Email = "u24365812@tuks.co.za" });
            people.Add(new Models.myClass { StudentNumber = "u24785961", Name = "Chris", Surname = "Baily", Email = "u24785961@tuks.co.za" });

            return View(people);
        }
    }
}