using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace FPTApplication.Models
{
    public class Book
    {
        public Book()
        {
            ImagePath = "~/Publish/Images/OIP.jfif";
        }

        [Key]
        public Guid BookID { get; set; }

        [Required]
        public string BookName { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public decimal BookPrice { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}