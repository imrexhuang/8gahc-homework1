using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoneyTemplate.Models.ViewModels;

namespace MoneyTemplate.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            return View();
        }

        // GET: Money/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Money/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
            List < SpendingTrackerViewModel > fakeDataList = new List<SpendingTrackerViewModel>
            {
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-01", AMOUMT = 100, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-01", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-01", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-02", AMOUMT = 1299, REMARK = "尿布"},
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-02", AMOUMT = 1899, REMARK = "記憶體" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-02", AMOUMT = 70, REMARK = "飲料" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-02", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-02", AMOUMT = 550, REMARK = "油錢" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-02", AMOUMT = 100, REMARK = "零食" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-02", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "收入", DATE = "2018-01-03", AMOUMT = 6000, REMARK = "租金" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-03", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-03", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-04", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-04", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "收入", DATE = "2018-01-05", AMOUMT = 45000, REMARK = "薪資" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-05", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-05", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-06", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-06", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-07", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-07", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-08", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-08", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-09", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-09", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-10", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-10", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-10", AMOUMT = 25142, REMARK = "房貸" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-11", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-11", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-12", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-12", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-13", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-13", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-14", AMOUMT = 100, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-14", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-14", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-15", AMOUMT = 100, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-15", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-15", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-16", AMOUMT = 100, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-16", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-16", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-17", AMOUMT = 100, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-17", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-17", AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-18", AMOUMT = 100, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-18", AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = "支出", DATE = "2018-01-18", AMOUMT = 200, REMARK = "晚餐" },
            };

            return View(fakeDataList.ToList());
        }

    }
}
