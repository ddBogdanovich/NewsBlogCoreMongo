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

        Task<IList<NewsCategory>> GetExistingCategories();

        Task<NewsItem> FindNewsItem(string id);

        Task<IEnumerable<NewsItem>> GetNews();

        Task InsertNewsItemAsync(NewsItem item);

        Task<List<string>> GetActualCategories();

        Task SaveCategoryItem(NewsCategory newsCategory);

        Task<NewsCategory> GetCategory(string id);

        Task UpdateCategoryItem(NewsCategory newsCategory);

        Task DeleteCategoryItem(string id);
    }
}