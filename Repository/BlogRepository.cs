using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using M101DotNet.WebApp.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Options;
using MongoBlog.Models;
using MongoDB.Driver;
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

        
        
        public async Task<IEnumerable<NewsItem>> GetNewsFilered(int page, int pageSize, string category)
        {
            Expression<Func<NewsItem, bool>> filter = x => true;
            
            if (!string.IsNullOrWhiteSpace(category))
            {
                filter = x => x.Categories.Contains(category);
            }

            return await _context.News.Find(filter)
                .SortByDescending(x => x.CreatedAtUtc)
                .Skip((page - 1) * pageSize)
                .Limit(pageSize)
                .ToListAsync();
        }
        

        #endregion
        
        
        
    }
}