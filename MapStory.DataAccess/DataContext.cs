using MapStory.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MapStory.DataAccess
{
    public class DataContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>,
                                                 UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>,
                                                 IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Group> Groups { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<UserRole>(userRole => {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                        .WithMany(r => r.UserRoles)
                        .HasForeignKey(ur => ur.RoleId)
                        .IsRequired();

                userRole.HasOne(ur => ur.User)
                        .WithMany(r => r.UserRoles)
                        .HasForeignKey(ur => ur.UserId)
                        .IsRequired();
            });

            builder.Entity<UserGroup>(userGroup => {
                userGroup.HasKey(ur => new { ur.UserId, ur.GroupId });

                userGroup.HasOne(ur => ur.Group)
                        .WithMany(r => r.UserGroups)
                        .HasForeignKey(ur => ur.GroupId)
                        .IsRequired();

                userGroup.HasOne(ur => ur.User)
                        .WithMany(r => r.UserGroups)
                        .HasForeignKey(ur => ur.UserId)
                        .IsRequired();
            });
        }
    }
}
