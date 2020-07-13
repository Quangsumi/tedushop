using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
using System.Data.Entity;
using System.Linq;

namespace TeduShop.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            //var query = from p in DbContext.Posts
            //            join pt in DbContext.PostTags
            //            on p.ID equals pt.PostID
            //            where pt.TagID == tag && p.Status
            //            orderby p.CreatedDate descending
            //            select p;

            // https://stackoverflow.com/questions/10505595/linq-many-to-many-relationship-how-to-write-a-correct-where-clause

            var query = DbContext.Posts
                .Include(p => p.Tags)
                .Where(p => p.Status == true && p.Tags.Any(t => t.Id == tag))
                .OrderByDescending(p => p.CreatedDate)
                .AsQueryable();

            totalRow = query.Count();

            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query;
        }
    }
}
