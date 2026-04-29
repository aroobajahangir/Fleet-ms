using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Midproject.Models
{
    public class Trip
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string Destination { get; set; }
        public string Status { get; set; }
    }
}