using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Demo.Models;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowPerson()
        {
            Person p = new Person() { ID=1,Name="张三",Age=21};
            List<Person> listperson = new List<Person>() {
                new Person(){ ID=1,Name="Jordan",Age=12},
                new Person(){ ID=2,Name="James",Age=12},
                new Person(){ ID=3,Name="Kobe",Age=12},
                new Person(){ ID=4,Name="Oner",Age=12},
                new Person(){ ID=5,Name="Kully",Age=12},
            };
            ViewData["PersonList"] = new SelectList(listperson, "ID", "Name");
            return View(p);
        }


























    }
}