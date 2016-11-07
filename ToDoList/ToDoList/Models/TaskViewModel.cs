using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Models
{
    public class TaskViewModel
    {
        [DisplayName("Task")]
        public int TaskID { get; set; }

        [DisplayName("Task")]
        public string TaskTitle { get; set; }

        [DisplayName("Description")]
        public string TaskDescription{ get; set; }

        [DisplayName("Category")]
        public string CategoryName { get; set; }

        [DisplayName("Created")]
        public DateTime DateCreated { get; set; }

        [DisplayName("Due")]
        public DateTime DueDate { get; set; }

        [DisplayName("Completed")]
        public DateTime? DateCompleted { get; set; }
    }   
}