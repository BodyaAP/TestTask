using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Models
{
    public class Author
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле має бути заповнене")]
        [Display(Name = "Ім'я")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле має бути заповнене")]
        [Display(Name = "По батькові")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Поле має бути заповнене")]
        [Display(Name = "Прізвище")]
        public string LastName { get; set; }
    }
}