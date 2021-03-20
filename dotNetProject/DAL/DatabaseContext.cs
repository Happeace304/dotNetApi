using dotNetProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Web;

namespace dotNetProject.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DatabaseContext")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext,
             //dotNetProject.Migrations.Configuration>("DatabaseContext"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PermissionGroup> PermissionGroups { get; set; }
        public DbSet<UserPermissionGroup> UserPermissionGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}