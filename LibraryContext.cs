using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace libraryProject.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryContext") { }

        public DbSet<Library> Libraries { get; set; }
    }

}