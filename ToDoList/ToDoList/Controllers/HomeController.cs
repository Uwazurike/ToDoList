using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ToDoList;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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
        [Authorize]
        public ActionResult TasksDueToday()
        {
          Taska2Entities db = new Taska2Entities();
        var history = from r in db.Chores
                          join m in db.Categories
                          on r.Category.CategoryName equals m.CategoryName
                          where r.DueDate == DateTime.Today
                          select new ToDoList.Models.TaskViewModel
                          {
                              TaskID = r.TaskID,
                              TaskTitle = r.TaskTitle,
                              TaskDescription = r.TaskDescription,
                              CategoryName = m.CategoryName,
                              DateCreated = r.DateCreated,
                              DueDate = r.DueDate,
                              DateCompleted = r.DateCompleted
                          };
            return View(history);
        }
        [Authorize]
        public ActionResult CompletedTasksForToday()
        {
            Taska2Entities db = new Taska2Entities();
            var history = from r in db.Chores
                          join m in db.Categories
                          on r.Category.CategoryName equals m.CategoryName
                          where r.DueDate == DateTime.Today && r.DateCompleted != null
                          select new ToDoList.Models.TaskViewModel
                          {
                              TaskID = r.TaskID,
                              TaskTitle = r.TaskTitle,
                              TaskDescription = r.TaskDescription,
                              CategoryName = m.CategoryName,
                              DateCreated = r.DateCreated,
                              DueDate = r.DueDate,
                              DateCompleted = r.DateCompleted
                          };
            return View(history);
        }
        [Authorize]
        public ActionResult IncompleteTasksForToday()
        {
            Taska2Entities db = new Taska2Entities();
            var history = from r in db.Chores
                          join m in db.Categories
                          on r.Category.CategoryName equals m.CategoryName
                          where r.DueDate == DateTime.Today && r.DateCompleted == null
                          select new ToDoList.Models.TaskViewModel
                          {
                              TaskID = r.TaskID,
                              TaskTitle = r.TaskTitle,
                              TaskDescription = r.TaskDescription,
                              CategoryName = m.CategoryName,
                              DateCreated = r.DateCreated,
                              DueDate = r.DueDate,
                              DateCompleted = r.DateCompleted
                          };
            return View(history);
        }
        [Authorize]
        public ActionResult AllTasksForTomorrow()
        {
            Taska2Entities db = new Taska2Entities();
            var tomorrow = DateTime.Today.AddDays(1);
            var history = from r in db.Chores
                          join m in db.Categories
                          on r.Category.CategoryName equals m.CategoryName
                          where r.DueDate == tomorrow
                          select new ToDoList.Models.TaskViewModel
                          {
                              TaskID = r.TaskID,
                              TaskTitle = r.TaskTitle,
                              TaskDescription = r.TaskDescription,
                              CategoryName = m.CategoryName,
                              DateCreated = r.DateCreated,
                              DueDate = r.DueDate,
                              DateCompleted = r.DateCompleted
                          };
            return View(history);
        }
        [Authorize]
        public ActionResult CompletedTasksForTomorrow()
        {
            Taska2Entities db = new Taska2Entities();
            var tomorrow = DateTime.Today.AddDays(1);
            var history = from r in db.Chores
                          join m in db.Categories
                          on r.Category.CategoryName equals m.CategoryName
                          where r.DueDate == tomorrow && r.DateCompleted != null
                          select new ToDoList.Models.TaskViewModel
                          {
                              TaskID = r.TaskID,
                              TaskTitle = r.TaskTitle,
                              TaskDescription = r.TaskDescription,
                              CategoryName = m.CategoryName,
                              DateCreated = r.DateCreated,
                              DueDate = r.DueDate,
                              DateCompleted = r.DateCompleted
                          };
            return View(history);
        }
        [Authorize]
        public ActionResult IncompleteTasksForTomorrow()
        {
            Taska2Entities db = new Taska2Entities();
            var tomorrow = DateTime.Today.AddDays(1);
            var history = from r in db.Chores
                          join m in db.Categories
                          on r.Category.CategoryName equals m.CategoryName
                          where r.DueDate == tomorrow && r.DateCompleted == null
                          select new ToDoList.Models.TaskViewModel
                          {
                              TaskID = r.TaskID,
                              TaskTitle = r.TaskTitle,
                              TaskDescription = r.TaskDescription,
                              CategoryName = m.CategoryName,
                              DateCreated = r.DateCreated,
                              DueDate = r.DueDate,
                              DateCompleted = r.DateCompleted
                          };
            return View(history);
        }
    }
}