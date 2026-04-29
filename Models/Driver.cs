using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Midproject.Models
{
    public class Driver
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public string Contact { get; set; }
    }
}