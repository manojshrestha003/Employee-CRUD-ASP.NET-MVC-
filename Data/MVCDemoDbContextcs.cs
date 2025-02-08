using LearningMVC.Models.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace LearningMVC.Data
{
    public class MVCDemoDbContextcs : DbContext
    {
        public MVCDemoDbContextcs(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee>  Employees   { get; set; }
    }
}
