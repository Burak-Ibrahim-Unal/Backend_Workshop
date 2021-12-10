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
foreach (var url in urlList.ToList())
{
    PagesList.Add(getContentAsync(url));

}

Console.WriteLine("before Wait all...");
var results = await Task.WhenAll(PagesList.ToArray());
Console.WriteLine("after Wait all...");


//var results = await Task.WhenAny(PagesList);
//Console.WriteLine($"{results.Result.Site} --- {results.Result.Len}");

/*var results = await Task.WhenAll(PagesList.ToArray());*/ // İf we use wait all instead of waitall,we block thread and thread will wait until code is complete.


//var results = await Task.WhenAll(PagesList.ToArray());
//foreach (var result in results)
//{
//    Console.WriteLine($"{result.Site}, size:{result.Len}");
//}




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