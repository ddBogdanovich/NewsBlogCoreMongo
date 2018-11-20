using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using M101DotNet.WebApp.Models;
using Microsoft.Extensions.Options;
using MongoBlog.Models;
using MongoDB.Driver;

namespace MongoBlog.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext _context = null;
        
        public BlogRepository(IOptions<Settings> settings)
        {
            _context = new BlogContext(settings);
        }
        
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
        
 
   
    }
}