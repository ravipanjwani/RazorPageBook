using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesBook.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public string Author { get; set; }
        public string Language { get; set; }
        public decimal Price { get; set; }
    }
}