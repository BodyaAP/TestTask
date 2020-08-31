using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Models
{
    public class Book
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле має бути заповнене")]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Поле має бути заповнене")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле має бути заповнене")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Поле має бути заповнене")]
        public int Page { get; set; }
    }
}