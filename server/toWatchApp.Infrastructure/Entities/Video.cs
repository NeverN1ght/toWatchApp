using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace toWatchApp.Infrastructure
{
    public class Video
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Comments { get; set; }
        public TimeSpan StartTimePoint { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}