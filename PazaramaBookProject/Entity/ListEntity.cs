using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaBookProject.Entity
{
    public class ListEntity
    {
        [Key]
        public int ListID { get; set; }
        public string ListName { get; set; }
        public List<BookEntity> Books { get; set; }
        public string ListImageURL { get; set; }

    }
}
