

namespace NewsBlogCoreMongo.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class Image
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ImageName { get; set; }

        public string Extension { get; set; }

    }
}