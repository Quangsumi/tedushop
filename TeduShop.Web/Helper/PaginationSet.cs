using System.Collections.Generic;
using System.Linq;

namespace TeduShop.Web.Helper
{
    public class PaginationSet<T>
    {
        public int Page { get; set; }

        public int Count 
        {
            get
            {
                return (Items == null) ? 0 : Items.Count();
            }
        }

        public int TotalPages{ get; set; }

        public int TotalCount { get; set; }

        public IEnumerable<T> Items { get; set; }
    }
}