using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DragoonApp.Authorization.Roles;
using DragoonApp.Authorization.Users;
using DragoonApp.MultiTenancy;
using Abp.Localization;

namespace DragoonApp.EntityFrameworkCore
{
    public class DragoonAppDbContext : AbpZeroDbContext<Tenant, Role, User, DragoonAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DragoonAppDbContext(DbContextOptions<DragoonAppDbContext> options)
            : base(options)
        {
        }

        // add these lines to override max length of property
        // we should set max length smaller than the PostgreSQL allowed size (10485760)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
