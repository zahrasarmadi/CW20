using CW20.Database;
using CW20.Models;

namespace CW20.Repository;

public class CategoryRepository
{
    AppDbContext context = new AppDbContext();

    public List<Category> GetCategoriesList()
    {
        var categories = context.Categories.ToList();
        return categories;
    }

    public Category GetCategory(int id)
    {
        var category = context.Categories
            .FirstOrDefault(x => x.Id == id);
        return category;
    }

    public void DeleteCategory(int id)
    {
        var category = context.Categories.First(x => x.Id == id);
        context.Categories.Remove(category);
        context.SaveChanges();
    }

    public void UpdateCategory(Category model)
    {
        var category = context.Categories.FirstOrDefault(x => x.Id == model.Id);

        category.Ads = model.Ads;
        category.Name = model.Name;

        context.SaveChanges();
    }
}
