using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using M101DotNet.WebApp.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Options;
using MongoBlog.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
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

        #region NewRepoMethods

        public Task<long> GetNewsCount(Expression<Func<NewsItem, bool>> filter)
        {
            return _context.News.CountDocumentsAsync(filter);
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
            await _context.News.ReplaceOneAsync(filter, item);
        }

        public async Task<Image> GetImage(string id)
        {
            var filter = Builders<NewsItem>.Filter.Eq("Images.FileId", id);
            // var projection = Builders<NewsItem>.Projection.Include("Images.$").Exclude("_id");

            var result = await _context.News.Find(filter).SingleOrDefaultAsync();


            var a = result.Images.FirstOrDefault(x => x.FileId == id);

            return a;
        }


        async Task IBlogRepository.DeleteImage(string id)
        {
            var filter = Builders<NewsItem>.Filter.Eq("Images.FileId", id);
            var NewsItem = await _context.News.Find(filter).SingleOrDefaultAsync();


            var pull = Builders<NewsItem>.Update.PullFilter(x => x.Images, a => a.FileId == id);
            var filter1 = Builders<NewsItem>.Filter.And(Builders<NewsItem>.Filter.Eq(a => a.Id, NewsItem.Id),
                Builders<NewsItem>.Filter.ElemMatch(q => q.Images, t => t.FileId == id));
            await _context.News.UpdateOneAsync(filter1, pull);
        }

        #endregion

        #region Categories

        public async Task<IList<NewsCategory>> GetExistingCategories()
        {
            return await _context.Categories.Find(x => true).SortBy(x => x.Name).ToListAsync();
        }


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
            var filter = Builders<NewsCategory>.Filter.Eq(x => x.Id, newsCategory.Id);
            await _context.Categories.ReplaceOneAsync(filter, newsCategory);
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