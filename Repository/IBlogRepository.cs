using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using M101DotNet.WebApp.Models;
using NewsBlogCoreMongo.Models;

namespace MongoBlog.Repository
{
    public interface IBlogRepository
    {
        Task<IEnumerable<Post>> GetPostsAsync();

        Task<IEnumerable<TagProjection>> GetTagsAsync();

        Task InsertPostAsync(Post post);

        Task<Post> GetPostByIdAsync(string id);

        Task<IEnumerable<Post>> GetPostsFilteredAsync(Expression<Func<Post, bool>> filter);

        Task<long> GetNewsCount(Expression<Func<NewsItem, bool>> filter);

        Task<IEnumerable<NewsItem>> GetNewsFiltered(int page, int pageSize, string category);

        Task<IEnumerable<NewsCategory>> GetActualCategories();

        Task<NewsItem> FindNewsItem(string id);
    }
}