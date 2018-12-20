namespace NewsBlogCoreMongo.Core.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    
    public class NewsCategory
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}