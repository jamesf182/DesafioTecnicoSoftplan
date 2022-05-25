using API2.Models;

namespace API2.DAL
{
    public class DataAccess
    {
        private readonly SettingsModel _settings = new();

        public T GetObject<T>(string filtro) where T : new()
        {
            using HttpClient? client = new();
            client.BaseAddress = new Uri(_settings.UrlAPI1);

            Task<HttpResponseMessage> responseTask = client.GetAsync(filtro);
            responseTask.Wait();

            HttpResponseMessage? result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                Task<T> readTask = result.Content.ReadFromJsonAsync<T>();
                readTask.Wait();

                return readTask.Result;
            }
            else
            {
                throw new Exception(result.ReasonPhrase);
            }
        }
    }
}
