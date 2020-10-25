using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GL.Library.Repository
{
    public class Book
    {
        public Book(string name, string author, string genre, double rating)
        {
            Name = name;
            Author = author;
            Rating = rating;
            Genre = genre;
        }

        public Book(long id, string name, string author, string genre, double rating)
        {
            ID = id;
            Name = name;
            Author = author;
            Rating = rating;
            Genre = genre;
        }

        public long ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Genre { get; set; }

        public double Rating { get; set; }
    }
}
