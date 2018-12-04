using MongoDB.Bson.Serialization.Attributes;

namespace M101DotNet.WebApp.Models
{
    public class TagProjection
    {
        [BsonElement("_id")]
        public string Name { get; set; }

        public int Count { get; set; }
    }
}