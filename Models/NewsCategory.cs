using MongoDB.Bson.Serialization.Attributes;

namespace NewsBlogCoreMongo.Models
{
    using MongoDB.Bson;
    
    public class NewsCategory
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}