using ShowColor.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ShowColor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Div> list = new List<Div>();

            Type t = typeof(Color);
            PropertyInfo[] properties = t.GetProperties(BindingFlags.Static | BindingFlags.Public);

            Div div;

            foreach(PropertyInfo p in properties)
            {
                Color c = (Color)t.InvokeMember(p.Name, BindingFlags.GetProperty, null, null, null);
                div = new Div(c);
                list.Add(div);
            }
            return View(list.OrderBy(x=>x.ColorVaule).ToList());
        }
    }
}