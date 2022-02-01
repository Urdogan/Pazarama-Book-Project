using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaBookProject.Entity
{
    public class GenreEntity
    {
        [Key]
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }
        public List<BookEntity> Books { get; set; }
        public string GenreImageUrl { get; set; }

    }
}
