using System.Collections.Generic;

namespace NewsBlogCoreMongo.Models
{
    public class NewsListViewModel
    {
        public IEnumerable<NewsItem> News { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}