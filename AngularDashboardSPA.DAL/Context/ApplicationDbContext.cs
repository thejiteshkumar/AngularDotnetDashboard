using AngularDashboardSPA.DAL.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AngularDashboardSPA.DAL.Context
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "36009813-b259-4997-b4d3-4f72cbabbc04",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR".ToUpper()
            });

            var hasher = new PasswordHasher<User>();

            builder.Entity<User>().HasData(
                new User
                {
                    Id = "7678a184-58b5-4904-a582-f62c06adfe8f",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@stormblessed.com",
                    NormalizedEmail = "ADMIN@STORMBLESSED.COM",
                    PasswordHash = hasher.HashPassword(null, "1tw*B@t*81$7Z9#%%75#!E27$Lw^fE")
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "36009813-b259-4997-b4d3-4f72cbabbc04",
                    UserId = "7678a184-58b5-4904-a582-f62c06adfe8f"
                }
            );
        }
    }
}