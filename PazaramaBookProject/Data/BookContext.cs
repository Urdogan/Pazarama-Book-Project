using Microsoft.EntityFrameworkCore;
using PazaramaBookProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaBookProject.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options):base(options)
        {

        }

        public DbSet<BookEntity> Books { get; set; }
        public DbSet<GenreEntity> Genres { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<ListEntity> Lists { get; set; }

    }
}
