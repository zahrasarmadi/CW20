using CW20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW20.Database;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category { Id = 1, Name = "املاک" },
            new Category { Id = 2, Name = "وسایل نقلیه" },
            new Category { Id = 3, Name = "کالای دیجیتال" },
            new Category { Id = 4, Name = "خانه و آشپزخانه" },
            new Category { Id = 5, Name = "خدمات" },
            new Category { Id = 6, Name = "وسایل شخصی" },
            new Category { Id = 7, Name = "سرگرمی و فراغت" },
            new Category { Id = 8, Name = "اجتماعی" },
            new Category { Id = 9, Name = "تجهیزات و صنعتی" },
            new Category { Id = 10, Name = "استخدام و کاریابی" }
            );
    }
}