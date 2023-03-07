using HtmlDataParser.Model;

namespace HtmlDataParser.Interfaces
{
    public interface IDataService
    {
        public List<DataContent> GetEndRecord();
        public void SaveRecord(List<DataContent> data);
        public T DeserializeData<T>(string data) where T : class;
    }
}
