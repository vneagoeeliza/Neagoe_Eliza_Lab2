﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Neagoe_Eliza_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
       // [Required, StringLength(150, MinimumLength = 3)]
        [Display(Name ="Book Title")]
        public string Title { get; set; }
      //  [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$",
      //      ErrorMessage ="Numele autorului trebuie sa fie de forma 'Prenume Nume'"), Required, 
//StringLength(50, MinimumLength = 3)]
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
      //  [Range(1, 300)]
        [Column(TypeName ="decimal(6, 2)")]
        public decimal Price { get; set; }
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
