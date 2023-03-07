namespace HtmlDataParser.Model
{
    public class ContentData
    {
        public Data data { get; set; }
    }
    public class Data
    {
        public SearchReportWoodDeal searchReportWoodDeal { get; set; }
    }
    public class SearchReportWoodDeal
    {
        public List<DataContent> content { get; set; }
    }

}
