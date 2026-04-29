using MongoDB.Driver;
using System.Linq;
using Midproject.Models;
using Midproject.Data;

namespace Midproject.Services
{
    public class UserService
    {
        private IMongoCollection<User> users;

        public UserService()
        {
            var db = new MongoDbContext().GetDatabase();
            users = db.GetCollection<User>("Users");

            if (users.CountDocuments(_ => true) == 0)
            {
                users.InsertOne(new User { Username = "admin", Password = "1234" });
            }
        }

        public bool Login(string username, string password)
        {
            return users.Find(u => u.Username == username && u.Password == password).Any();
        }
    }
}