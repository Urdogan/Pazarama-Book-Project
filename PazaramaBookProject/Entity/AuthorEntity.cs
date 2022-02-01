using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaBookProject.Entity
{
    public class AuthorEntity
    {
        [Key]
        public int AuthorID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
