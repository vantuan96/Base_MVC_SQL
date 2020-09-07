using Kztek.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Kztek.Model.Models
{
    public class Student
    {
        [Key]
        public string Id { get; set; }

        [StringLength(250)]
        public string  Fullname { get; set; }
        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Phone { get; set; }

        public  bool IsDelete { get; set; }

        public bool Active { get; set; }
        public Nullable<DateTime> Birthday { get; set; }
        public string Gender { get; set; }
        public string ImagePath { get; set; }
        public string UserAvatar { get; set; }
        public static IEnumerable<SelectListItem> GetGenderSelectItems()
        {
            yield return new SelectListItem { Text = "Male", Value = "Male" };
            yield return new SelectListItem { Text = "Female", Value = "Female" };
        }
    }
}
