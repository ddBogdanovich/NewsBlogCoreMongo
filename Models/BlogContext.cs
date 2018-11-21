using Microsoft.Extensions.Options;
using MongoBlog.Models;
using MongoDB.Driver;
using NewsBlogCoreMongo.Models;

namespace M101DotNet.WebApp.Models
{
    public class BlogContext
    {
        public const string POSTS_COLLECTION_NAME = "posts";
        public const string NEWS_COLLECTION_NAME = "news";
        public const string CATEGORIES_COLLECTION_NAME = "categories";
        

        // This is ok... Normally, they would be put into
        // an IoC container.
        private static IMongoClient _client;
        private static IMongoDatabase _database;

        public BlogContext(IOptions<Settings> settings)
        {
  
            _client = new MongoClient(settings.Value.ConnectionString);
            if (_client != null)
            {
                _database = _client.GetDatabase(settings.Value.Database);
            }
        }

        public IMongoClient Client => _client;

        public IMongoCollection<Post> Posts => _database.GetCollection<Post>(POSTS_COLLECTION_NAME);

        public IMongoCollection<NewsItem> News => _database.GetCollection<NewsItem>(NEWS_COLLECTION_NAME);

        public IMongoCollection<NewsCategory> Categories => _database.GetCollection<NewsCategory>(CATEGORIES_COLLECTION_NAME);
    }
}