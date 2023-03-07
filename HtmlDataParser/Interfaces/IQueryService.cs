namespace HtmlDataParser.Interfaces
{
    public interface IQueryService
    {
        public string GetQuery(int pageNumber, int size);
        public string GetTotalQuery();

    }
}
