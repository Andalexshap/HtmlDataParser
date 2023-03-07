using HtmlDataParser.Interfaces;
using HtmlDataParser.Model;

namespace HtmlDataParser.Services
{
    public class StartProgram
    {
        private readonly IQueryService _queryService;
        private readonly IRequestService _requestService;
        private readonly IDataService _dataService;
        private int size = 50;
        public StartProgram()
        {

        }
        public StartProgram(IQueryService queryService, IRequestService requestService, IDataService dataService)
        {
            _queryService = queryService;
            _requestService = requestService;
            _dataService = dataService;
        }

        public void Start()
        {
            var totalQuery = _queryService.GetTotalQuery();
            var resultTotal = _requestService.SendRequest(totalQuery);
            var total = _dataService.DeserializeData<ContentTotal>(resultTotal);
            int maxPageNumber = (total.data.searchReportWoodDeal.total / size) + 1;

        }
    }
}
