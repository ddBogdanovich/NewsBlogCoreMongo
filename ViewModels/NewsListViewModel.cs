namespace NewsBlogCoreMongo.ViewModels
{
    using System.Collections.Generic;
    using Core.Models;
    
    public class NewsListViewModel
    {
        public IEnumerable<NewsItem> News { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}