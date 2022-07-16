// See https://aka.ms/new-console-template for more information
using Newtonsoft;
using Newtonsoft.Json;


static string ReadFromJson(string jsonFile)
{
    dynamic jsonResult = JsonConvert.DeserializeObject(File.ReadAllText(jsonFile));
    Console.WriteLine(jsonResult);
    return jsonResult.ToString();
    //Console.WriteLine(Directory.GetCurrentDirectory());

}

string path = @"C:\Users\Burak\Desktop\Github\Backend_Workshop\NetCore OOP Samples\JsonModify\JsonApp\warehouses.json";
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
