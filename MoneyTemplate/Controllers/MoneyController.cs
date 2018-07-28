using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MoneyTemplate.Models.ViewModels;
using MoneyTemplate.Repository;
using MoneyTemplate.Service;

namespace MoneyTemplate.Controllers
{
    public class MoneyController : Controller
    {
        private readonly AccountbookService _accountbookService;
        private readonly UnitOfWork _unitOfWork;

        public MoneyController()
        {
            _unitOfWork = new UnitOfWork();
            _accountbookService = new AccountbookService(_unitOfWork);
        }

        // GET: Money
        public ActionResult Index()
        {
            return View();
        }

        // GET: Money/Details/5
        public ActionResult Details(Guid id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var accountbook = _accountbookService.GetSingle(id);
            if (accountbook == null)
            {
                return HttpNotFound();
            }

            return View(accountbook);
        }

        // GET: Money/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Money/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Money/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var accountbook = _accountbookService.GetSingle(id);
            if (accountbook == null)
            {
                return HttpNotFound();
            }

            return View(accountbook);
        }

        // POST: Money/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TYPE,DATE,AMOUMT,REMARK")]
                                 SpendingTrackerViewModel accountbook)
        {
            if (ModelState.IsValid)
            {
                _accountbookService.Edit(accountbook.ID, accountbook);
                _unitOfWork.Commit();

                return RedirectToAction("Index");
            }

            return View(accountbook);
        }

        // GET: Money/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Money/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Money
        public ActionResult List()
        {
            return View(_accountbookService.Lookup());
        }
    }
}
