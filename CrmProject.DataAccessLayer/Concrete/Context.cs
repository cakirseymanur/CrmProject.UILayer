using CrmProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmProject.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DbCRM;integrated security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//stackoverflow.com/questions/5559043/entity-framework-code-first-two-foreign-keys-from-same-table
        {
            modelBuilder.Entity<EmployeeTask>()
                        .HasOne(m=>m.AppUser)
                        .WithMany(t => t.EmployeeTask)
                        .HasForeignKey(m => m.AppUserId)
                        .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<EmployeeTask>()
                         .HasOne(m => m.AppAssigneeUser)
                         .WithMany(t => t.AssigneeEmployeeTask)
                         .HasForeignKey(m => m.AssigneeUserId)
                         .OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
        public DbSet<EmployeeTaskDetail> EmployeeTaskDetails { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
