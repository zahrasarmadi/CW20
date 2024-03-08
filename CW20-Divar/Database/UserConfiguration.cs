using CW20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW20.Database;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasMany(u => u.Bookmarks)
           .WithOne(o => o.User)
           .HasForeignKey(u=>u.UserId)
           .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(u => u.Ads)
           .WithOne(o => o.User)
           .HasForeignKey(u => u.UserId)
           .OnDelete(DeleteBehavior.NoAction);

    }
}