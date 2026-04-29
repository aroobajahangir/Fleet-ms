using MongoDB.Driver;

namespace Midproject.Data
{
    public class MongoDbContext
    {
        private string connection = "mongodb://localhost:27017";
        private string dbName = "FleetMS";

        public IMongoDatabase GetDatabase()
        {
            var client = new MongoClient(connection);
            return client.GetDatabase(dbName);
        }
    }
}