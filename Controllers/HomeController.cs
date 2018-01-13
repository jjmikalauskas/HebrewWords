using Hebrew1.Models;
using Hebrew1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hebrew1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<WordsVM> wordList;

            using (Db db = new Db())
            {
                wordList = db.Words.ToArray().Select(x => new WordsVM(x)).ToList(); 
            }
            return View(wordList);
        }

        // Home/Index/AddWord
        public ActionResult AddWord()
        {

            return View(); 
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}