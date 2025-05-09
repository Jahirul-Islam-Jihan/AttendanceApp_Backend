using attendence_app.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }//ctor
    
    public DbSet<Book> Books { get; set; }
}//cls