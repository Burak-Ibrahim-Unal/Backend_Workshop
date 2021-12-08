// See https://aka.ms/new-console-template for more information


List<string> urlList = new List<string>()
{
    "https://www.google.com",
    "https://www.guru3d.com",
    "https://www.apple.com/tr",
    "https://www.w3schools.com"
};



async Task<PageContent> getContentAsync(string url)
{
    PageContent pageContent = new PageContent();
    var data = await new HttpClient().GetStringAsync(url);

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