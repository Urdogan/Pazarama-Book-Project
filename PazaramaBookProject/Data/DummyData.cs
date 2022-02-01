using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PazaramaBookProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaBookProject.Data
{
    public static class DummyData 
    {

        public static void InsertDummyData(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<BookContext>();
            context.Database.Migrate();

            var genres = new List<GenreEntity>()
            {
                new GenreEntity{GenreName="Adventure", Books= new List<BookEntity>(){new BookEntity(){Title="The Call of the Wild",Author= new AuthorEntity(){Name="Jack",Surname="London"},ImageUrl= "https://images-na.ssl-images-amazon.com/images/I/41JNWeZqnsL._SX336_BO1,204,203,200_.jpg", Year=1903,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/novela-juvenil-para-regalar-barato-8-300x400.png" },
                new GenreEntity{GenreName="Classics", Books= new List<BookEntity>(){new BookEntity(){Title= "Little Women", Author= new AuthorEntity(){Name= "Louisa May", Surname= "Alcott" },ImageUrl= "https://images-eu.ssl-images-amazon.com/images/I/51xJASXQJwL._SY264_BO1,204,203,200_QL40_ML2_.jpg", Year=1868,ISBN= "978-0316489270" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/libros-infantiles-de-segunda-mano-8-300x400.png" },
                new GenreEntity{GenreName="Comic Book", Books= new List<BookEntity>(){new BookEntity(){Title= "Dragon Ball Super", Author= new AuthorEntity(){Name= "Akira", Surname= "Toriyama" },ImageUrl= "https://m.media-amazon.com/images/I/81Cxtoxje9L._AC_UL320_.jpg", Year=2020,ISBN= "978-8822628541" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/comprar-comics-segunda-mano-8-300x400.png" },
                new GenreEntity{GenreName="Mystery", Books= new List<BookEntity>(){new BookEntity(){Title= "Verity", Author= new AuthorEntity(){Name= "Colleen", Surname= "Hoover" },ImageUrl= "https://images-na.ssl-images-amazon.com/images/I/41IXK1j+aFL._SX331_BO1,204,203,200_.jpg", Year=1903,ISBN= "978-1538724736" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/novelas-de-misterio-negra-thriller-8-300x400.png" },
                new GenreEntity{GenreName="Fantasy", Books= new List<BookEntity>(){new BookEntity(){Title= "The Midnight Library", Author= new AuthorEntity(){Name= "Matt", Surname= "Haig" },ImageUrl= "https://images-na.ssl-images-amazon.com/images/I/51Ifl1zXhJL._SY291_BO1,204,203,200_QL40_FMwebp_.jpg", Year=1903,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/libros-de-fantasia-segunda-mano-comprar-8-300x400.png" },
                new GenreEntity{GenreName="Historical Fiction", Books= new List<BookEntity>(){new BookEntity(){Title= "As Meat Loves Salt", Author= new AuthorEntity(){Name= "Maria", Surname= "McCann" },ImageUrl= "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1398025759l/271487.jpg", Year=1903,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/novelas-historica-usado-8-300x400.png" },
                new GenreEntity{GenreName="Horror", Books= new List<BookEntity>(){new BookEntity(){Title= "Reprieve", Author= new AuthorEntity(){Name= "James Han", Surname= "Mattson" },ImageUrl= "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1629210121-51n2OJj1-iL._SL500_.jpg?crop=1xw:1xh;center,top&resize=768:*", Year=2021,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/llibros-de-miedo-u-horror-segunda-mano-8-300x400.png" },
                new GenreEntity{GenreName="Romance", Books= new List<BookEntity>(){new BookEntity(){Title= "The Coldest Touch", Author= new AuthorEntity(){Name= "Isabel", Surname= "Sterling" },ImageUrl= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRzfM0sePhYRaVJ12Ncz1pDmk5MwO2ZklkK8mQSBVipRynbDsMp", Year=2021,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/libros-para-madres-y-padres-8-300x400.png" },
                new GenreEntity{GenreName="Science Fiction", Books= new List<BookEntity>(){new BookEntity(){Title= "The Blazing World", Author= new AuthorEntity(){Name= "Margaret", Surname= "Cavendish" },ImageUrl= "http://kbimages1-a.akamaihd.net/Images/2a6e6689-9a96-4801-87c5-c34c9b54cfc7/255/400/False/image.jpg", Year=1966,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/ensayo-cientifico-8-300x400.png" },
                new GenreEntity{GenreName="Short Stories", Books= new List<BookEntity>(){new BookEntity(){Title= "Battleborn", Author= new AuthorEntity(){Name= "Claire Vaye", Surname= "Watkins" },ImageUrl= "https://s26162.pcdn.co/wp-content/uploads/2019/09/81mSNDsTCpL-677x1024.jpg", Year=1903,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/libros-sobre-filosofia-segunda-mano-8-300x400.png" },
                new GenreEntity{GenreName="Biographies", Books= new List<BookEntity>(){new BookEntity(){Title= "A Beautiful Mind", Author= new AuthorEntity(){Name= "Sylvia", Surname= "Nasar" },ImageUrl= "https://m.media-amazon.com/images/I/511wQDs0J7L.jpg", Year=1903,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/autobiografias-famosas-tienda-online-8-300x400.png" },
                new GenreEntity{GenreName="Cookbooks", Books= new List<BookEntity>(){new BookEntity(){Title= "The Mediterranean Diet", Author= new AuthorEntity(){Name= "Elena", Surname= "Paravantes" },ImageUrl= "https://i.dr.com.tr/cache/500x400-0/originals/0001950574001-1.jpg", Year=1903,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/libros-de-cocina-barato-8-300x400.png" },
                new GenreEntity{GenreName="History", Books= new List<BookEntity>(){new BookEntity(){Title= "Grant", Author= new AuthorEntity(){Name= "Ron", Surname= "Chernow" },ImageUrl= "https://pictures.abebooks.com/isbn/9780143110637-us.jpg", Year=1903,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/cuentos-y-relatos-baratos-8-300x400.png" },
                new GenreEntity{GenreName="Poetry", Books= new List<BookEntity>(){new BookEntity(){Title= "The Wilderness", Author= new AuthorEntity(){Name= "Sandra", Surname= "Lim" },ImageUrl= "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1617290526-41fPYv4IolL.jpg?crop=1xw:0.999xh;center,top&resize=768:*", Year=1903,ISBN="978-1512395822" } },GenreImageUrl="https://libros.eco/wp-content/uploads/2021/04/Mesa-de-trabajo-31-8-300x400.png" }


            };
            var books = new List<BookEntity>()
            {
                new BookEntity(){Title="To Kill a Mockingbird",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[1]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51IXWZzlgSL._SX330_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="Watchmen",ISBN="978-1779501127",Genres= new List<GenreEntity>() {genres[2] },ImageUrl="https://images-na.ssl-images-amazon.com/images/I/410D4H0IqjL._SX318_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Walking Dead Compendium 1",ISBN="978-1607060765",Genres= new List<GenreEntity>() {genres[2]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51S12ntkIbL._SX323_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Boy, the Mole, the Fox and the Horse",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[2]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/418D9yYGB3L._SX369_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Night Fire",ISBN="978-0316485616",Genres= new List<GenreEntity>() {genres[3] },ImageUrl="https://images-na.ssl-images-amazon.com/images/I/41zqZwXZ-WL._SX325_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Adventures of Sherlock Holmes",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[3]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/516dZVA7rQL._SX346_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="And Then There Were None",ISBN="978-0062073488",Genres= new List<GenreEntity>() {genres[3] },ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51MlxNgCsyL._SX308_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Water Dancer",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[4]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51IA60IJysL._SX327_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="Circe",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[4]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51v3pVuTAkL._SX323_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="Ninth House",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[4]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/41cUxNtr5-L._SX326_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Help",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[5]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/41rc1NK5nIL._SX329_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="One Hundred Years of Solitude",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[5]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/5164gibO9ZL._SX327_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="Memoirs of a Geisha",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[5]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51O9HqW8ZAL._SX322_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="Carrie",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[6]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51dRjo8NJeL._SX296_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="Soft Science",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[13]},ImageUrl="https://images-eu.ssl-images-amazon.com/images/I/51M-w5S0J9L._SY264_BO1,204,203,200_QL40_ML2_.jpg" },
                new BookEntity(){Title="The Water Dancer",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[13]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51IA60IJysL._SX327_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Water Dancer",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[4]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51IA60IJysL._SX327_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Water Dancer",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[4]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51IA60IJysL._SX327_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Water Dancer",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[4]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51IA60IJysL._SX327_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Water Dancer",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[4]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51IA60IJysL._SX327_BO1,204,203,200_.jpg" },
                new BookEntity(){Title="The Water Dancer",ISBN="978-0060935467",Genres= new List<GenreEntity>() {genres[4]},ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51IA60IJysL._SX327_BO1,204,203,200_.jpg" },

            };

            var lists = new List<ListEntity>()
            {
                new ListEntity()
                {
                    ListName="Bestseller Books", 
                    Books = new List<BookEntity>(){books[0], books[1], books[3], books[6], books[12]},
                    ListImageURL = "https://static01.nyt.com/images/2018/12/21/books/00BOOKS-NOT-ON-THE-LIST-GRID/00BOOKS-NOT-ON-THE-LIST-GRID-articleLarge-v4.jpg?quality=75&auto=webp&disable=upscale"
                },new ListEntity()
                {
                    ListName="Must-Read Books",
                    Books = new List<BookEntity>(){books[0], books[9], books[19], books[6], books[11]},
                    ListImageURL = "https://www.scholastic.com/content/dam/scholastic/educators/collections/Most-Popular-BL_-COLL_16-9.jpg.corpimagerendition.xxl.1400.788.png"
                },new ListEntity()
                {
                    ListName="Most Popular Books",
                    Books = new List<BookEntity>(){books[0], books[5], books[3], books[6], books[2]},
                    ListImageURL = "https://media.npr.org/assets/img/2021/12/02/maureen-corrigan-reads-1_wide-e615c2a00bea413867488f80493e523a08b9ec88-s1100-c50.jpg"
                },new ListEntity()
                {
                    ListName="Bedside Books",
                    Books = new List<BookEntity>(){books[0], books[1], books[20], books[13], books[12]},
                    ListImageURL = "https://www.scholastic.com/content/dam/scholastic/educators/articles/20210729-guided-reading-booklists-16-9.jpg.corpimagerendition.xxl.1400.788.png"
                },new ListEntity()
                {
                    ListName="Recommended Books",
                    Books = new List<BookEntity>(){books[1], books[5], books[7], books[11], books[19]},
                    ListImageURL = "https://media.npr.org/assets/img/2021/12/02/maureen-corrigan-reads-1_wide-e615c2a00bea413867488f80493e523a08b9ec88-s1100-c50.jpg"
                },new ListEntity()
                {
                    ListName="Most Influential Books",
                    Books = new List<BookEntity>(){books[2], books[6], books[8], books[10], books[19]},
                    ListImageURL = "https://media.npr.org/assets/img/2021/12/02/maureen-corrigan-reads-1_wide-e615c2a00bea413867488f80493e523a08b9ec88-s1100-c50.jpg"
                }
            };

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }

                if (context.Books.Count() == 0)
                {
                    context.Books.AddRange(books);
                }
                if (context.Lists.Count() == 0)
                {
                    context.Lists.AddRange(lists);
                }

                context.SaveChanges();
            }
        }
    }
}
