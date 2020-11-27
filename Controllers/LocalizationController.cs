using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExtreme.AspNet.Mvc;

namespace DevExtremeMvcApp2.Controllers
{
    public class LocalizationController : Controller
    {
        // GET: Localization
        public ActionResult CldrData() {
            return new CldrDataScriptBuilder()
                .SetCldrPath("~/Content/cldr-data")
                .UseLocales(new[] { "ja", "ru" })
                .Build();
        }
    }
}