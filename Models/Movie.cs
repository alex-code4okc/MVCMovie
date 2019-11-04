using System;
using System.ComponentModel.DataAnnotations; //enables field annotations
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        //EF by default will assocaite Id as the primary key
        //can use the following annotation if primary key name is not automatically picked up by EF
        //[key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
    }
}