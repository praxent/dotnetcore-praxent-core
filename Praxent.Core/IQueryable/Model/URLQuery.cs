namespace Praxent.Core.IQueryable.Model
{
    public class URLQuery
    {
        public int? PageSize { get; set; }

        public int? PageNumber { get; set; }

        public string OrderBy { get; set; }

        public bool OrderDescending { get; set; }
    }
}