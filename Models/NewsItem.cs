

namespace NewsBlogCoreMongo.Models
{
    using System;
    using System.Collections.Generic;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    
    public class NewsItem
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string Headline { get; set; }

        public string Body { get; set; }

        public string Category { get; set; }
        
        public List<Image> Images { get; set; }

        public DateTime CreatedAtUtc { get; set; }

    }
}