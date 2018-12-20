namespace NewsBlogCoreMongo.Core.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    
    public class Image
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FileId { get; set; }

        public string OriginalFileName { get; set; }

        public string Extension { get; set; }
    }
}