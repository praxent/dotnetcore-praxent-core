using System.Linq;
using Praxent.Core.IQueryable.Model;

namespace Praxent.Core.IQueryable
{
    public interface IQueryProcessor
    {
        IQueryable<T> ProcessURLQueryForIQueryable<T>(IQueryable<T> queryable, URLQuery query);
    }
}