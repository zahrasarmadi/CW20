using CW20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW20.Database;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        //builder.HasMany(u => u.UserAds)
        //.WithMany(o => o.Users)
        //.UsingEntity(j => j.ToTable("UserFavoriteAds"));
        

       // builder.HasMany(u => u.Ads)
       //.WithOne(o => o.User)
       //.HasForeignKey(u => u.UserId);

    }
}