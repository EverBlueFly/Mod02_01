using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod02_01.Models; //引入Model
using Mod02_01.DAL;
using System.Net;
using System.Data.Entity;

namespace Mod02_01.Controllers
{
    public class OperaController : Controller
    {
        // GET: Opera
        private OperaContext context = new OperaContext();
        public ActionResult Index(Opera opera)
        {
            //Opera o = new Opera()
            //{
            //    OperaId = opera.OperaId,
            //    Title = opera.Title,
            //    Year = opera.Year,
            //    Composer = opera.Composer
            //};
            //return View( o );
            return View(context.Operas.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opera o = context.Operas.Find(id);
            if(o == null)
            {
                return HttpNotFound();
            }
            return View(o);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opera);
        }
    }
}