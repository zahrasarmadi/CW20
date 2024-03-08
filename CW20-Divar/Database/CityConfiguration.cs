using CW20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW20.Database;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasData(
           new City { Id = 1, Name = "اراک" },
           new City { Id = 2, Name = "اردبیل" },
           new City { Id = 3, Name = "تبریز" },
           new City { Id = 4, Name = "اصفهان" },
           new City { Id = 5, Name = "اهواز" },
           new City { Id = 6, Name = "ایلام" },
           new City { Id = 7, Name = "بجنورد" },
           new City { Id = 8, Name = "بندرعباس" },
           new City { Id = 9, Name = "بوشهر" },
           new City { Id = 10, Name = "بیرجند" },
           new City { Id = 11, Name = "ارومیه" },
           new City { Id = 12, Name = "تهران" },
           new City { Id = 13, Name = "خرم آباد" },
           new City { Id = 14, Name = "رشت" },
           new City { Id = 15, Name = "زاهدان" },
           new City { Id = 16, Name = "زنجان" },
           new City { Id = 17, Name = "ساری" },
           new City { Id = 18, Name = "سمنان" },
           new City { Id = 19, Name = "سنندج" },
           new City { Id = 20, Name = "شهرکرد" },
           new City { Id = 21, Name = "شیراز" },
           new City { Id = 22, Name = "قزوین" },
           new City { Id = 23, Name = "قم" },
           new City { Id = 24, Name = "کرج" },
           new City { Id = 25, Name = "کرمان" },
           new City { Id = 26, Name = "کرمانشاه" },
           new City { Id = 27, Name = "گرگان" },
           new City { Id = 28, Name = "مشهد" },
           new City { Id = 29, Name = "همدان" },
           new City { Id = 30, Name = "یاسوج" },
           new City { Id = 31, Name = "یزد" }
            );
    }
}