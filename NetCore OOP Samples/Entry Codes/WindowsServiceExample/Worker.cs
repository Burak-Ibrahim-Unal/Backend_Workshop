using System.Net.Http;

namespace SmsWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private List<string> Urls = new List<string> { "https://www.google.com", "https://www.facebook.com/" };

        public Worker(ILogger<Worker> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await PollUrls();
                }
                catch (Exception e)
                {
                    _logger.LogError($"Hata oluþtu...Hata bilgisi : {e.Message}");
                    throw;
                }
                finally
                {
                    await Task.Delay(1000, stoppingToken);
                }
            }
        }


        private async Task PollUrls()
        {
            var tasks = new List<Task>();
            foreach (var url in Urls)
            {
                tasks.Add(PollUrl(url));
            }
            await Task.WhenAll(tasks);
        }

        private async Task PollUrl(string url)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode) _logger.LogWarning($"{url} is online");
                else _logger.LogWarning($"{url} is offline");
            }
            catch (Exception e)
            {
                _logger.LogWarning($"{url} is offline...Hata Bilgisi : {e.Message}");
            }
        }


    }
}