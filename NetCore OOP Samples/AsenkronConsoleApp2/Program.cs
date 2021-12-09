// See https://aka.ms/new-console-template for more information

Console.WriteLine($"Main thread is:{Thread.CurrentThread.ManagedThreadId}");
List<string> urlList = new List<string>()
{
    "https://www.google.com",
    "https://www.guru3d.com",
    "https://www.apple.com/tr",
    "https://www.w3schools.com"
};



List<Task<PageContent>> PagesList = new List<Task<PageContent>>();
foreach (var url in urlList)
{
    PagesList.Add(getContentAsync(url));

}


var results = await Task.WhenAll(PagesList.ToArray());

foreach (var result in results)
{
    Console.WriteLine($"{result.Site}, size:{result.Len}");
}



async Task<PageContent> getContentAsync(string url)
{
    PageContent pageContent = new PageContent();
    var handler = new HttpClientHandler()
    {
        AllowAutoRedirect = false
    };
    HttpClient client = new HttpClient(handler);
    var data = await client.GetStringAsync(url);

    pageContent.Site = url;
    pageContent.Len = data.Length;
    Console.WriteLine($"getContentAsync method works with Thread:{Thread.CurrentThread.ManagedThreadId}");
    return pageContent;

}


class PageContent
{
    public string Site { get; set; }
    public int Len { get; set; }
}