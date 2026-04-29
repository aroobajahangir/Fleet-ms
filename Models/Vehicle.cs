using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Midproject.Models
{
    public class Vehicle
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Model { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public string FuelType { get; set; }
        public string Status { get; set; }
    }
}