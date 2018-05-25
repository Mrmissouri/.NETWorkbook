using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HelloWorld.Models
{
    public class HelloWorldContext : DbContext
    {
        public HelloWorldContext(DbContextOptions<HelloWorldContext> options)
            : base(options)
        { }

        public DbSet<Student> students { get; set; }
        public DbSet<Grades> Grades { get; set; }
    }
}
