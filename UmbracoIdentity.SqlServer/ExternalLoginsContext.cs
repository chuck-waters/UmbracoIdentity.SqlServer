using System.Data.Entity;
using Umbraco.Core;
using UmbracoIdentity.SqlServer.Models;

namespace UmbracoIdentity.SqlServer
{
    internal class ExternalLoginsContext : DbContext
    {
		public ExternalLoginsContext()
        {
            var context = ApplicationContext.Current;            
            this.Database.Connection.ConnectionString = context.DatabaseContext.ConnectionString; //ConfigurationManager.ConnectionStrings["umbracoDbDSN"].ConnectionString;
            this.Configuration.LazyLoadingEnabled = false;
        }

		public DbSet<ExternalLogin> ExternalLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ExternalLogin>()
                .ToTable("ExternalLogins");

            modelBuilder.Entity<ExternalLogin>()
                .HasKey(e => e.ExternalLoginId);

            modelBuilder.Entity<ExternalLogin>()
                .Property(e => e.UserId)
                .IsRequired();

            modelBuilder.Entity<ExternalLogin>()
                .Property(e => e.LoginProvider)
                .IsRequired()
                .HasMaxLength(4000);
            
            modelBuilder.Entity<ExternalLogin>()
                .Property(e => e.ProviderKey)
                .IsRequired()
                .HasMaxLength(4000);
            
        }
    }
}
