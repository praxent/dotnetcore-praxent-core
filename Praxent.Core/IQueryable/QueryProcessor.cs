using System.Linq;
using Praxent.Core.IQueryable.Model;

namespace Praxent.Core.IQueryable
{
    public class QueryProcessor : IQueryProcessor
    {
        // Order Matters a lot here - 
        // https://stackoverflow.com/a/46357287
        public IQueryable<T> ProcessURLQueryForIQueryable<T>(IQueryable<T> queryable, URLQuery query)
        {
            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    if (query.OrderDescending)
                    {
                        queryable = queryable.OrderByDescending(query.OrderBy);
                    }
                    else
                    {
                        queryable = queryable.OrderBy(query.OrderBy);
                    }
                }
                if (query.PageSize.HasValue)
                {
                    var pageSize = query.PageSize.Value;
                    if (query.PageNumber.HasValue)
                    {
                        var pageNumber = query.PageNumber.Value - 1;
                        var skipAmount = pageSize * pageNumber;
                        queryable = queryable.Skip(skipAmount);
                    }
                    queryable = queryable.Take(pageSize);
                }
            }

            return queryable;
        }
    }
}