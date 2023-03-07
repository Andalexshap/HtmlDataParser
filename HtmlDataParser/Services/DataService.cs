using HtmlDataParser.Interfaces;
using HtmlDataParser.Model;
using Newtonsoft.Json;

namespace HtmlDataParser.Services
{
    public class DataService : IDataService
    {
        public List<DataContent> GetEndRecord()
        {
            using (var context = new DataContext())
            {
                // Получение последней записи из таблицы
                var records = context.Content.Take(1).ToList();
                return records;
            }
        }
        public void SaveRecord(List<DataContent> data)
        {
            using (var context = new DataContext())
            {
                // Добавление новых записей
                context.Content.AddRange(data);
                context.SaveChanges();
            }
        }
        public T DeserializeData<T>(string data) where T : class
        {
            var result = JsonConvert.DeserializeObject<T>(data);

            return result;
        }
    }
}
