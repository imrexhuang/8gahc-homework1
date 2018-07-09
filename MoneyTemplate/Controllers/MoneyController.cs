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
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 1), AMOUMT = 100, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 1), AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 1), AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 2), AMOUMT = 1299, REMARK = "尿布"},
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 2), AMOUMT = 1899, REMARK = "記憶體" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 2), AMOUMT = 70, REMARK = "飲料" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 2), AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 2), AMOUMT = 550, REMARK = "油錢" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 2), AMOUMT = 100, REMARK = "零食" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 2), AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.收入, DATE = new DateTime(2018, 1, 3), AMOUMT = 6000, REMARK = "租金" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 3), AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 3), AMOUMT = 200, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 4), AMOUMT = 123, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 4), AMOUMT = 241, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.收入, DATE = new DateTime(2018, 1, 5), AMOUMT = 45000, REMARK = "薪資" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 5), AMOUMT = 135, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 5), AMOUMT = 197, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 6), AMOUMT = 124, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 6), AMOUMT = 70, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 7), AMOUMT = 131, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 7), AMOUMT = 178, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 8), AMOUMT = 165, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 8), AMOUMT = 239, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 9), AMOUMT = 153, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 9), AMOUMT = 275, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 10), AMOUMT = 96, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 10), AMOUMT = 238, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 10), AMOUMT = 25142, REMARK = "房貸" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 11), AMOUMT = 113, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 11), AMOUMT = 217, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 12), AMOUMT = 132, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 12), AMOUMT = 173, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 13), AMOUMT = 135, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 13), AMOUMT = 182, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 14), AMOUMT = 125, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 14), AMOUMT = 180, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 14), AMOUMT = 253, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 15), AMOUMT = 70, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 15), AMOUMT = 163, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 15), AMOUMT = 257, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 16), AMOUMT = 101, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 16), AMOUMT = 153, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 16), AMOUMT = 202, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 17), AMOUMT = 95, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 17), AMOUMT = 130, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 17), AMOUMT = 210, REMARK = "晚餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 18), AMOUMT = 80, REMARK = "早餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 18), AMOUMT = 150, REMARK = "中餐" },
                new SpendingTrackerViewModel{ TYPE = TypeEnum.支出, DATE = new DateTime(2018, 1, 18), AMOUMT = 162, REMARK = "晚餐" },
            };

            return View(fakeDataList.ToList());
        }

    }
}
