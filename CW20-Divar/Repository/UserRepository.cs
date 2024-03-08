using CW20.Database;
using CW20.Models;

namespace CW20.Repository;

public class UserRepository
{
    AppDbContext context = new AppDbContext();

    public List<User> GetUsersList()
    {
        var users = context.Users.ToList();
        return users;
    }

    public User GetUser(int id)
    {
        var user = context.Users
            .FirstOrDefault(x => x.Id == id);
        return user;
    }

    public void DeleteUser(int id)
    {
        var user = context.Users.First(x => x.Id == id);
        context.Users.Remove(user);
        context.SaveChanges();
    }

    public void UpdateUser(User model)
    {
        var user = context.Users.FirstOrDefault(x => x.Id == model.Id);

        user.Ads = model.Ads;
        user.Bookmarks = model.Bookmarks;
        user.FisrtName = model.FisrtName;
        user.LastName = model.LastName;
        user.Email = model.Email;
        user.Password = model.Password;

        context.SaveChanges();
    }

    public void AddBookmark(Bookmark bookmark,int userId)
    {
       var user= GetUser(userId);
        user.Bookmarks.Add(bookmark);
    }
}
