using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.DL.EntityModels
{
   public class DbContextCRM : DbContext
   {

        public DbContextCRM():base("name=CRM_DB_Model") { }
        public virtual DbSet<AspNetRoles> AspNetRolese { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaimse { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLoginse { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUserse { get; set; }

        public virtual DbSet<LandingType> LandingTypes { get; set; }
        public virtual DbSet<LandingPageName> LandingPageNames { get; set; }
        public virtual DbSet<LoggingLandingPage> LoggingLandingPages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AspNetRoles>().MapToStoredProcedures();
            modelBuilder.Entity<AspNetUserClaims>().MapToStoredProcedures();
            modelBuilder.Entity<AspNetUserLogins>().MapToStoredProcedures();
            modelBuilder.Entity<AspNetUsers>().MapToStoredProcedures();

            modelBuilder.Entity<LandingType>().MapToStoredProcedures();
            modelBuilder.Entity<LandingPageName>().MapToStoredProcedures();
            modelBuilder.Entity<LoggingLandingPage>().MapToStoredProcedures();

        }

       
    }
}
