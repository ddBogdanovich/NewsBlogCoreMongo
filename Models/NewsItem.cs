namespace NewsBlogCoreMongo.Models
{
    using System;
    using System.Collections.Generic;
    using MongoDB.Bson;
    
    public class NewsItem
    {
        public ObjectId Id { get; set; }
        
        public string Headline { get; set; }

        public string Body { get; set; }

        public string Title { get; set; }

        public List<string> Categories { get; set; }

        public DateTime CreatedAtUtc { get; set; }

    }
}