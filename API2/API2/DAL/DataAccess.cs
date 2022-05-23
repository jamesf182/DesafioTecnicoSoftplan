using API2.Models;

namespace API2.DAL
{
    public class DataAccess
    {
        private SettingsModel? settings;

        public DataAccess()
        {
            settings = new SettingsModel();
        }

        public T GetObject<T>(string filtro) where T : new()
        {
            using (HttpClient? client = new HttpClient())
            {
                client.BaseAddress = new Uri(settings.UrlAPI1);

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
}
