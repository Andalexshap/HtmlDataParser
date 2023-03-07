namespace HtmlDataParser.Model
{
    public class ContentTotal
    {
        public DataTotal data { get; set; }
    }
    public class DataTotal
    {
        public SearchReportWoodDealTotal searchReportWoodDeal { get; set; }
    }
    public class SearchReportWoodDealTotal
    {
        public int total { get; set; }
    }
}
