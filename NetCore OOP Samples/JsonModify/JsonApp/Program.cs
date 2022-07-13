// See https://aka.ms/new-console-template for more information
using Newtonsoft;
using Newtonsoft.Json;


static void ReadFromJson(string jsonFile)
{
    dynamic jsonfile = JsonConvert.DeserializeObject(File.ReadAllText(jsonFile));
    Console.WriteLine($"informations:{jsonfile} ");
    //Console.WriteLine(Directory.GetCurrentDirectory());

}

string path = @"C:\Users\Burak\Desktop\Github\Backend_Workshop\NetCore OOP Samples\JsonModify\JsonApp\warehouses.json";
ReadFromJson(path);