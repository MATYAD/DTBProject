using DatabaseProject.Entities;
using Microsoft.EntityFrameworkCore;
using Task = DatabaseProject.Entities.Task;

namespace DatabaseProject.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options){}
    
    public DbSet<Employee> Employees {get; set; }
    
    public DbSet<Project> Projects {get; set; }
    
    public DbSet<Task> Tasks {get; set; }
}