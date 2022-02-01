using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaBookProject.Entity
{
    public class BookEntity
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        public AuthorEntity Author { get; set; }
        [Required]
        public string ISBN { get; set; }
        public int Year { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public List<GenreEntity> Genres { get; set; }
        [Required]
        public List<ListEntity> Lists { get; set; }

    }
}
