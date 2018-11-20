using Microsoft.Extensions.Options;
using MongoBlog.Models;
using MongoDB.Driver;

namespace M101DotNet.WebApp.Models
{
    public class BlogContext
    {
        public const string POSTS_COLLECTION_NAME = "posts";

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

        public IMongoClient Client
        {
            get { return _client; }
        }

        public IMongoCollection<Post> Posts
        {
            get { return _database.GetCollection<Post>(POSTS_COLLECTION_NAME); }
        }
        
 
 
    }
}