using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Midproject.Models
{
    public class Maintenance
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string VehicleNumber { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public DateTime Date { get; set; }
    }
}