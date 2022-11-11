using Microsoft.EntityFrameworkCore;
using Hanc_Darius_Lab2.Models;

namespace Hanc_Darius_Lab2.Data
{
    public class Hanc_Darius_Lab2Context : DbContext
    {
        public Hanc_Darius_Lab2Context (DbContextOptions<Hanc_Darius_Lab2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; } = null!;

        public virtual DbSet<Publisher> Publisher { get; set; } = null!;

        public virtual DbSet<Author> Author { get; set; } = null!;

        public virtual DbSet<Category> Category { get; set; } = null!;

        public DbSet<Hanc_Darius_Lab2.Models.Member> Member { get; set; }

        public DbSet<Hanc_Darius_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
