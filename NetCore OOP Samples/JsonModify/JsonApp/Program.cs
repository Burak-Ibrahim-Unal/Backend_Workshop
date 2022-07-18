// See https://aka.ms/new-console-template for more information
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

static List<JObject> ReadFromJson(string jsonFile)
{
    dynamic jsonResult = JsonConvert.DeserializeObject(File.ReadAllText(jsonFile));
    List<JObject> list = new List<JObject>();
    for (int i = 0; i < jsonResult.Count; i++)
    {
        //list.Add(ReadFromJson(jsonResult[i]));
        list.Add(jsonResult[i]);
    }
    Console.WriteLine(list[0]);
    return list;
    //Console.WriteLine(Directory.GetCurrentDirectory());

}

string path = @"D:\Burak\Github\Backend_Workshop\NetCore OOP Samples\JsonModify\JsonApp\bin\Debug\net6.0\warehouses.json";
var result = ReadFromJson(path);



public class Stock
{
    public string Name { get; set; }
    public string Id { get; set; }
    public Location Location { get; set; }
    public List<Car> Cars { get; set; }
}


public class Location
{
    public string lat { get; set; }
    public string lon { get; set; }
}

public class Car
{
    public string Location { get; set; }
    public List<Vehicle> Vehicles { get; set; }
}

public class Vehicle
{
    public string Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Year_Model { get; set; }
    public decimal Price { get; set; }
    public bool Licenced { get; set; }
    public DateTime Date_Added { get; set; }

}
