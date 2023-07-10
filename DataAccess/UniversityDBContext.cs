using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAcess;

public class UniversityDBContext : DbContext
{
     public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
    {

    }
    
    public DbSet<User>? Users {get; set;}
    public DbSet<Course>? Course {get; set;}
    public DbSet<Category>? Category {get; set;}
    public DbSet<Student>? Student {get; set;}
    public DbSet<Chapter>? Chapters {get; set;}
    
}



