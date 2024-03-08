using CW20.Database;
using CW20.Models;

namespace CW20.Repository;

public class AdRepository
{
    AppDbContext context = new AppDbContext();

    public List<Ad> GetAdsList()
    {
        var ads = context.Ads.ToList();
        return ads;
    }

    public Ad GetAds(int id)
    {
        var ad = context.Ads
            .FirstOrDefault(x => x.Id == id);
        return ad;
    }

    public void DeleteAd(int id)
    {
        var ad = context.Ads.First(x => x.Id == id);
        context.Ads.Remove(ad);
        context.SaveChanges();
    }

    public void UpdateAd(Ad model)
    {
        var ad = context.Ads.FirstOrDefault(x => x.Id == model.Id);

        ad.User = model.User;
        ad.UserId = model.UserId;
        ad.UserBookmarks = model.UserBookmarks;
        ad.Category = model.Category;
        ad.CategoryId = model.CategoryId;
        ad.City = model.City;
        ad.CityId = model.CityId;
        ad.Description = model.Description;
        ad.Title = model.Title;
        ad.Pictures = model.Pictures;


        context.SaveChanges();
    }

    public List<Ad> Filter(string categoryName, string cityName)
    {
        var ads = GetAdsList();
        if (categoryName != null && cityName == null)
            return ads.Where(a => a.Category.Name == categoryName).ToList();

        else if (categoryName == null && cityName != null)
            return ads.Where(a => a.City.Name == cityName).ToList();

        else if (categoryName != null && cityName != null)
            return ads.Where(a => a.Category.Name == categoryName && a.City.Name == cityName).ToList();

        else
            return new List<Ad>();
    }

    public List<Ad> Search(string search)
    {
        var ads = GetAdsList();
        return ads.Where(a => a.Description.Contains(search) || a.Title.Contains(search)).ToList();
    }
}
