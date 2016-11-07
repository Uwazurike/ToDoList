using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoList
{

    [MetadataType(typeof(ChoreMetaData))]
    public partial class Chore
    {
    }

    public class ChoreMetaData
    {
        [DisplayName("Task")]
        public int TaskID { get; set; }

        [DisplayName("Task")]
        [Required(ErrorMessage = "Please enter a Task Title")]
        [MaxLength(150, ErrorMessage = "Task Title can't be more than 150 characters")]
        public string TaskTitle { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "A description is required")]
        [MaxLength(150, ErrorMessage = "Keep Task Descriptions under 150 characters")]
        public string TaskDescription { get; set; }

        [DisplayName("Category")]
        public Nullable<int> TaskCategory { get; set; }

        [DisplayName("Created")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "A Creation date is required")]
        public System.DateTime DateCreated { get; set; }

        [DisplayName("Due")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "A Due date is required")]
        public System.DateTime DueDate { get; set; }

        [DisplayName("Completed")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateCompleted { get; set; }
    }

    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {
    }

    public class CategoryMetaData
    {
        [DisplayName("Category")]
        public int CategoryID { get; set; }

        [DisplayName("Category")]
        [Required(ErrorMessage = "Please enter a Category name")]
        [MaxLength(150, ErrorMessage = "Category name can't be more than 150 characters")]
        public string CategoryName { get; set; }
    }

    [MetadataType(typeof(RecordMetaData))]
    public partial class Record
    {
    }

    public class RecordMetaData
    {
        [DisplayName("User")]
        [Required(ErrorMessage = "Please enter a UserName")]
        [MaxLength(150, ErrorMessage = "UserName can't be more than 150 characters")]
        public string UserName { get; set; }

        [DisplayName("Task")]
        public int TaskID { get; set; }
    }
}