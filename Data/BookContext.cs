using bookcrud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookcrud.Data
{
    public class BookContext : DbContext
    {
        //create a constructor that take in the expressDbContext and pass in the base option
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
        
}
