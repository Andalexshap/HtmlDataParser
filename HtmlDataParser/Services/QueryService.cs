using HtmlDataParser.Interfaces;

namespace HtmlDataParser.Services
{
    public class QueryService : IQueryService
    {
        public string GetQuery(int pageNumber = 0, int size = 50)
        {
            return "query {searchReportWoodDeal(pageable: {number: " + pageNumber + ", size: " + size + "}) {content {sellerName sellerInn buyerName buyerInn woodVolumeBuyer woodVolumeSeller dealDate dealNumber __typename} __typename}}";
        }

        public string GetTotalQuery()
        {
            return "query {searchReportWoodDeal(filter: null, pageable: {number: 0, size: 20}) {total}}";
        }
    }
}
