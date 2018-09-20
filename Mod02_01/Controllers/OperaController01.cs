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
    public class OperaController01 : Controller
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
            if (id == null)
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

        public ActionResult Edit(int? id)
        {
            try
            {
                if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }
                Opera o = context.Operas.Find(id);
                if (o == null) { return HttpNotFound(); }
                return View(o);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public ActionResult Edit(Opera opera)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Entry(opera).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(opera);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region 跳確認頁去刪除
        //public ActionResult Delete(int? id)
        //{
        //    try
        //    {
        //        if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }
        //        Opera o = context.Operas.Find(id);
        //        if (o == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(o);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteComfirm(int? id)
        //{
        //    try
        //    {
        //        Opera o = context.Operas.Find(id);
        //        context.Operas.Remove(o);
        //        context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion
            //用JS讓USER在本機點選確定 就可以不用回後端進確認刪除頁 直接執行刪除
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }
                Opera o = context.Operas.Find(id);
                if (o == null) { return HttpNotFound(); }
                context.Operas.Remove(o);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}