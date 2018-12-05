using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using M101DotNet.WebApp.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Options;
using MongoBlog.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using NewsBlogCoreMongo.Models;

namespace MongoBlog.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext _context = null;
        
        public BlogRepository(IOptions<Settings> settings)
        {
            _context = new BlogContext(settings);
        }



        #region OldRepo

        

        
        public async Task<IEnumerable<Post>> GetPostsAsync()
        {
            return await _context.Posts.Find(x => true)
                .SortByDescending(x => x.CreatedAtUtc)
                .Limit(10)
                .ToListAsync();
        }
        
        
        public async Task<IEnumerable<TagProjection>> GetTagsAsync()
        {
            return await _context.Posts.Aggregate()
                .Project(x => new { _id = x.Id, Tags = x.Tags })
                .Unwind(x => x.Tags)
                .Group<TagProjection>("{ _id: '$Tags', Count: { $sum: 1 } }")
                .Limit(10)
                .ToListAsync();
        }
        
        
        public async Task InsertPostAsync(Post post)
        {
            await _context.Posts.InsertOneAsync(post);
        }
        
        
        public async Task<Post> GetPostByIdAsync(string id)
        {
           return await _context.Posts.Find(x => x.Id == id).SingleOrDefaultAsync();
        }
        
        
        public async Task<IEnumerable<Post>> GetPostsFilteredAsync(Expression<Func<Post, bool>> filter)
        {
            return await _context.Posts.Find(filter).SortByDescending(x => x.CreatedAtUtc).ToListAsync();
        }
        
        
        #endregion

        


        #region NewRepoMethods

        public Task<long> GetNewsCount(Expression<Func<NewsItem, bool>> filter)
        {
            return  _context.News.CountDocumentsAsync(filter);
        }
        
        
        
        public async Task<IEnumerable<NewsItem>> GetNews()
        {
            return await _context.News.Find(x => true).ToListAsync();
        }
        
        
        public async Task<IEnumerable<NewsItem>> GetNewsFiltered(int page, int pageSize, string category)
        {
            Expression<Func<NewsItem, bool>> filter = x => true;
            
            if (!string.IsNullOrWhiteSpace(category))
            {
                filter = x => x.Category == category;
            }

            return await _context.News.Find(filter)
                .SortByDescending(x => x.CreatedAtUtc)
                .Skip((page - 1) * pageSize)
                .Limit(pageSize)
                .ToListAsync();
        }


        public async Task<IList<NewsCategory>> GetExistingCategories()
        {
            return await _context.Categories.Find(x => true).SortBy(x => x.Name).ToListAsync();
        }


        public async Task<NewsItem> FindNewsItem(string id)
        {
            return await _context.News.Find(x => x.Id == id).SingleOrDefaultAsync();
        }
        
        
        public async Task InsertNewsItemAsync(NewsItem item)
        {
            await _context.News.InsertOneAsync(item);
        }


        public async Task DeleteNewsItem(string id)
        {
            var result = _context.News.DeleteOneAsync(x => x.Id == id);
        }

        public async Task UpdateNewsItemAsync(NewsItem item)
        {
            var filter = Builders<NewsItem>.Filter.Eq(x => x.Id, item.Id);
            var result = await _context.News.ReplaceOneAsync(filter, item);
        }
        
        
        
        
        #endregion
        
        #region Categories

        public async Task<List<string>> GetActualCategories()
        {
           
            return await _context.News.AsQueryable<NewsItem>().Select(x => x.Category).Distinct().ToListAsync();

        }




        public async Task SaveCategoryItem(NewsCategory newsCategory)
        {
             await _context.Categories.InsertOneAsync(newsCategory);
        }


        public async Task UpdateCategoryItem(NewsCategory newsCategory)
        {
            var filter = new BsonDocument("Id", newsCategory.Id);
            var update = Builders<NewsCategory>.Update.Set("Name", newsCategory.Name);
            
            var result = await _context.Categories.FindOneAndUpdateAsync<BsonDocument>(filter, update);
        }
        
        public async Task DeleteCategoryItem(string id)
        {     
            var result = await _context.Categories.DeleteOneAsync(x => x.Id == id);
        }
        
        
        public async Task<NewsCategory> GetCategory(string id)
        {
            return await _context.Categories.Find(x => x.Id == id).SingleOrDefaultAsync();
        }
        
        
        #endregion
        
        
    }
}