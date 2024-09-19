using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        [MaxLength(50)]
        public string Nationality { get; set; }


    }
}
