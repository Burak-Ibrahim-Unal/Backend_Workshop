// See https://aka.ms/new-console-template for more information
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

static List<JObject> ReadFromJson(string jsonFile)
{
    dynamic jsonResult = JsonConvert.DeserializeObject(File.ReadAllText(jsonFile));
    List<JObject> list = new List<JObject>();
    List<Stock> stockList = new List<Stock>();
    Stock tempStock = new Stock();

    //foreach (KeyValuePair<string, JToken> sub_obj in (JObject)jsonResult[0])
    //{
    //    tempStock.Id = sub_obj.Value.ToString();
    //    //tempStock.Location
    //    //Console.WriteLine(sub_obj.Value);
    //    Console.WriteLine(tempStock.Id);
    //}

    Stock stock = new Stock();
    Car car = new Car();
    Location location = new Location();
    Vehicle vehicle = new Vehicle();
    List<Vehicle> vehicles = new List<Vehicle>();
    List<Stock> stocks = new List<Stock>();

    for (int i = 0; i < jsonResult.Count; i++)
    {
        //list.Add(ReadFromJson(jsonResult[i]));
        JObject jobject = jsonResult[i] as JObject;
        list.Add(jobject);

        stock.Id = list[i]["_id"].ToString();
        stock.Name = list[i]["name"].ToString();
        Console.WriteLine(list[i]["location"]["lat"]);
        location.lat = list[i]["location"]["lat"].ToString();
        location.lon = list[i]["location"]["long"].ToString();
        stock.Location = location;
        car.Location = list[i]["cars"]["location"].ToString();

        for (int j = 0; j < list[i]["cars"]["vehicles"].ToArray().Length; j++)
        {
            vehicle.Id = list[i]["cars"]["vehicles"][j]["_id"].ToString();
            vehicle.Make = list[i]["cars"]["vehicles"][j]["make"].ToString();
            vehicle.Model = list[i]["cars"]["vehicles"][j]["model"].ToString();
            vehicle.Year_Model = list[i]["cars"]["vehicles"][j]["year_model"].ToString();
            vehicle.Price = (decimal)list[i]["cars"]["vehicles"][j]["price"];
            vehicle.Licensed = (bool)list[i]["cars"]["vehicles"][j]["licensed"];
            vehicle.Date_Added = ((DateTime)list[i]["cars"]["vehicles"][j]["date_added"]);
            vehicles.Add(vehicle);
            vehicle = new Vehicle();
        }
        car.Vehicles = vehicles;
        stock.Car = car;
        stocks.Add(stock);
        //stock.Location.lat = list[0]["location"]["lat"].ToString();
        //stock.Location.lon = list[0]["location"]["long"].ToString();

        //Stock stock = (Stock)jobject.ToObject(typeof(Stock));       
        //Stock stock = jobject.ToObject(Stock);
        //stock.Id = jobject.ChildrenTokens["_id"];
        //stockList.Add(stock);

    }
    //Stock stock = new Stock();
    //for (int i = 0; i < list.Count; i++)
    //{
    //    stock.Id = list[0]["name"].ToString();
    //}
    //Console.WriteLine(list[0]);
    //Console.WriteLine(list[0]["name"]);
    //Console.WriteLine(list[0]["location"]["lat"]);
    //Console.WriteLine(list[0]["cars"]);
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
    public Car Car { get; set; }
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
    public bool Licensed { get; set; }
    public DateTime Date_Added { get; set; }

}
