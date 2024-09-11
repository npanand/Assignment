using assignmentProject.Models;
using Microsoft.EntityFrameworkCore;

namespace assignmentProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<UserLogin> userlogin { get; set; }
    }
}
