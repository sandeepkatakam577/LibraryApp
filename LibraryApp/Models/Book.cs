using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Book
    {
       
        public  int Id { get; set; }

        [Required(ErrorMessage ="Please Enter the book name")]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Please Enter the Author name")]
        [Display(Name = "Author Name")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please Enter the ISBN No.")]
        [Display(Name = "ISBN No.")]
        public string ISBN { get; set; }

        public string Genre { get; set; }

        [Required(ErrorMessage = "Please Enter the Published Date")]
        [Display(Name = "Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
    }
}
