using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Microsoft.Extensions.Configuration;
using System.Reflection.Emit;

namespace Dal
{
    public class TimesheetSystemDbContext : DbContext
    {
        
        public TimesheetSystemDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectStage> ProjectStages { get; set; }
        public DbSet<Software> Software { get; set; }
        public DbSet<SoftwareModule> SoftwareModules { get; set; }
        public DbSet<ProjectTask> Tasks { get; set; }

    }
}
