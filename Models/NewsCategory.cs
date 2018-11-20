namespace NewsBlogCoreMongo.Models
{
    using MongoDB.Bson;
    
    public class NewsCategory
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }
    }
}