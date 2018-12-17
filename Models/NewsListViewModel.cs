namespace NewsBlogCoreMongo.Models
{
    using System.Collections.Generic;

    public class NewsListViewModel
    {
        public IEnumerable<NewsItem> News { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}