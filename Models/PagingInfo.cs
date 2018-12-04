using System;

namespace NewsBlogCoreMongo.Models
{
    public class PagingInfo
    {
        public long TotalItems { get; set; }
        
        public int ItemsPerPage { get; set; }
        
        public int CurrentPage { get; set; }
        
        public int TotalPages { get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); } }
        
        public bool HasPreviousPage
        {
            get
            {
                return (CurrentPage > 1);
            }
        }
 
        public bool HasNextPage
        {
            get
            {
                return (CurrentPage < TotalPages);
            }
        }
    }

    }
