using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq.Mapping;


namespace HalifaxScienceLibrary_Project.Controllers
{
    public class ShowTablesController : Controller
    {

        private HSLEntities db = new HSLEntities();
        // GET: ShowTables
        public ActionResult Index()
        {
            var datamodel = new AttributeMappingSource().GetModel(typeof(HSLEntities));

            List<String> list = new List<String>();

            foreach (var r in datamodel.GetTables())
            {
                Console.WriteLine(r.TableName);
                list.Add(r.TableName);
            }
            Console.ReadKey(true);

            ViewBag.Tableslist = list;

            return View(ViewBag.Tableslist);
        }
    }
}