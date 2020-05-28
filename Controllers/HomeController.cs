using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EadQuiz02.Models;

namespace EadQuiz02.Controllers
{
    public class HomeController : Controller
    {

        Engineer[] engineers = { new Engineer("elect/1214", "Ali", "Electrical") ,
                                   new Engineer("civil/2945","Ahmad","Civil"),
                                   new Engineer("elect/1215","Aslam","Electrical"),
                                   new Engineer("cs/6198","Ali","CS")};
        DataClasses1DataContext dc = new DataClasses1DataContext();
        DataClasses2DataContext tc = new DataClasses2DataContext();
        DataClasses3DataContext sc = new DataClasses3DataContext();

        grocery g = new grocery(); 
        public ActionResult Index()
        {
            return View(engineers.ToList());
        }
        public ActionResult ViewGrocery()
        {
            var s = dc.groceries.Where(x => x.Id >= 0);
            return View(s.ToList());
        }
        public ActionResult AddGrocery()
        {
            return View();
        }
        public ActionResult Add()
        {
            string name = Request["name"];
            string price = Request["price"];
            int price1 = Int32.Parse(price);

            string brand = Request["brand"];
            grocery g = new grocery();
            g.name = name;
            g.price = price1;
            g.brand = brand;
            dc.groceries.InsertOnSubmit(g);
            dc.SubmitChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditGrocery(int Id)
        {
            var s = dc.groceries.First(x => x.Id == Id);
            return View(s);
        }
        public ActionResult Edit(int Id)
        {
            var a = dc.groceries.First(x => x.Id == Id);
            string name = Request["name"];
            string price = Request["price"];
            int price1 = Int32.Parse(price);
            string brand = Request["brand"];
            a.name = name;
            a.price = price1;
            a.brand = brand;
            dc.SubmitChanges();
            return RedirectToAction("Index");
        }
        ///////////////////////////////////////////////////////
        public ActionResult ViewToys()
        {
            var s = tc.Toys.Where(x => x.Id >= 0);
            return View(s.ToList());
        }
        public ActionResult AddToys()
        {
            return View();
        }
        public ActionResult Add1()
        {
            string name = Request["name"];
            string price = Request["price"];
            int price1 = Int32.Parse(price);

            string brand = Request["brand"];
            Toy g = new Toy();
            g.name = name;
            g.price = price1;
            g.brand = brand;
            tc.Toys.InsertOnSubmit(g);
            tc.SubmitChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditToys(int Id)
        {
            var s = tc.Toys.First(x => x.Id == Id);
            return View(s);
        }
        public ActionResult Edit1(int Id)
        {
            var a = tc.Toys.First(x => x.Id == Id);
            string name = Request["name"];
            string price = Request["price"];
            int price1 = Int32.Parse(price);
            string brand = Request["brand"];
            a.name = name;
            a.price = price1;
            a.brand = brand;
            tc.SubmitChanges();
            return RedirectToAction("Index");
        }
        //////////////////////////////////////////////////////////////
        public ActionResult ViewSports()
        {
            var s = sc.Sports.Where(x => x.Id >= 0);
            return View(s.ToList());
        }
        public ActionResult AddSports()
        {
            return View();
        }
        public ActionResult Add2()
        {
            string name = Request["name"];
            string price = Request["price"];
            int price1 = Int32.Parse(price);

            string brand = Request["brand"];
            Sport g = new Sport();
            g.name = name;
            g.price = price1;
            g.brand = brand;
            sc.Sports.InsertOnSubmit(g);
            sc.SubmitChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditSports(int Id)
        {
            var s = sc.Sports.First(x => x.Id == Id);
            return View(s);
        }
        public ActionResult Edit2(int Id)
        {
            var a = sc.Sports.First(x => x.Id == Id);
            string name = Request["name"];
            string price = Request["price"];
            int price1 = Int32.Parse(price);
            string brand = Request["brand"];
            a.name = name;
            a.price = price1;
            a.brand = brand;
            sc.SubmitChanges();
            return RedirectToAction("Index");
        }
    }
}
