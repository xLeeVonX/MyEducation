namespace MyEducation.WebAPI.Infrastructure.Data;


public class HOKcontext(DbContextOptions<HOKcontext> options) : DbContext(options)
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}
