using HtmlDataParser.Interfaces;
using Newtonsoft.Json;
using RestSharp;

namespace HtmlDataParser.Services
{
    public class RequestService : IRequestService
    {
        const string Url = "https://www.lesegais.ru/open-area/graphql";

        public string SendRequest(string Query)
        {
            RestClient client;
            try
            {
                // Создаем клиент и указываем адрес сервера
                client = new RestClient(Url);
            }
            catch (Exception)
            {
                throw;
            }

            // Создаем запрос и указываем метод POST
            var request = new RestRequest(Method.POST);

            // Добавляем заголовок Content-Type с указанием типа контента
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "/");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Connection", "keep-alive");


            // Создаем объект с параметрами запроса
            var query = new
            {
                query = Query
            };

            // Добавляем тело запроса с параметрами в формате JSON
            request.AddParameter("application/json", JsonConvert.SerializeObject(query), ParameterType.RequestBody);

            // Выполняем запрос и получаем ответ
            var response = client.Execute(request);

            return response.Content;
        }
    }
}
