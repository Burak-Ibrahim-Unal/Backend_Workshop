// See https://aka.ms/new-console-template for more information

var task = new HttpClient().GetStringAsync("https://www.google.com").ContinueWith(data =>
{
    Console.WriteLine($"Data length: {data.Result.Length}");
});

Console.WriteLine("We have work to do here...");

await task;