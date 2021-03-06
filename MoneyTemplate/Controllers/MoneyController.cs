﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MoneyTemplate.Models.ViewModels;
using MoneyTemplate.Repository;
using MoneyTemplate.Service;
using X.PagedList;

namespace MoneyTemplate.Controllers
{
    public class MoneyController : Controller
    {
        private readonly AccountbookService _accountbookService;
        private readonly UnitOfWork _unitOfWork;

        // 分頁後每頁顯示的筆數
        private const int defaultPageSize = 20;

        public MoneyController()
        {
            _unitOfWork = new UnitOfWork();
            _accountbookService = new AccountbookService(_unitOfWork);
        }

        // GET: Money
        public ActionResult Index()
        {
            return RedirectToAction("List");
            //return View();
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
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TYPE,DATE,AMOUMT,REMARK")]
                                 SpendingTrackerViewModel accountbook)
        {
            if (ModelState.IsValid)
            {
                accountbook.ID = Guid.NewGuid();
                _accountbookService.Add(accountbook);
   
                _unitOfWork.Commit();
                return RedirectToAction("List");
            }

            return View(accountbook);
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

                return RedirectToAction("List");
            }

            return View(accountbook);
        }


        // POST: Money/Delete/5
        //[HttpPost]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var accountbook = _accountbookService.GetSingle(id.Value);
            if (accountbook == null)
            {
                return HttpNotFound();
            }

            return View(accountbook);
        }

        // GET: Money
        public ActionResult List(int page = 1)
        {
            int currentPageIndex = page < 1 ? 1 : page;
            TempData["CurrentPage"] = currentPageIndex;

            return View(_accountbookService.Lookup().OrderBy(x => x.ID).ToPagedList(currentPageIndex, defaultPageSize) );
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _accountbookService.Delete(id);
            _unitOfWork.Commit();

            return RedirectToAction("List");
        }

    }
}
