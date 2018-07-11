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
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 1), Amoumt = 100, Remark = "早餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 1), Amoumt = 150, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 1), Amoumt = 200, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 2), Amoumt = 1299, Remark = "尿布"},
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 2), Amoumt = 1899, Remark = "記憶體" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 2), Amoumt = 70, Remark = "飲料" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 2), Amoumt = 150, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 2), Amoumt = 550, Remark = "油錢" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 2), Amoumt = 100, Remark = "零食" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 2), Amoumt = 200, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.收入, Date = new DateTime(2018, 1, 3), Amoumt = 6000, Remark = "租金" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 3), Amoumt = 150, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 3), Amoumt = 200, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 4), Amoumt = 123, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 4), Amoumt = 241, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.收入, Date = new DateTime(2018, 1, 5), Amoumt = 45000, Remark = "薪資" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 5), Amoumt = 135, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 5), Amoumt = 197, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 6), Amoumt = 124, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 6), Amoumt = 70, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 7), Amoumt = 131, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 7), Amoumt = 178, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 8), Amoumt = 165, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 8), Amoumt = 239, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 9), Amoumt = 153, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 9), Amoumt = 275, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 10), Amoumt = 96, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 10), Amoumt = 238, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 10), Amoumt = 25142, Remark = "房貸" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 11), Amoumt = 113, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 11), Amoumt = 217, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 12), Amoumt = 132, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 12), Amoumt = 173, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 13), Amoumt = 135, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 13), Amoumt = 182, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 14), Amoumt = 125, Remark = "早餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 14), Amoumt = 180, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 14), Amoumt = 253, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 15), Amoumt = 70, Remark = "早餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 15), Amoumt = 163, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 15), Amoumt = 257, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 16), Amoumt = 101, Remark = "早餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 16), Amoumt = 153, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 16), Amoumt = 202, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 17), Amoumt = 95, Remark = "早餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 17), Amoumt = 130, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 17), Amoumt = 210, Remark = "晚餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 18), Amoumt = 80, Remark = "早餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 18), Amoumt = 150, Remark = "中餐" },
                new SpendingTrackerViewModel{ Type = TypeEnum.支出, Date = new DateTime(2018, 1, 18), Amoumt = 162, Remark = "晚餐" },
            };

            return View(fakeDataList);
        }

    }
}
