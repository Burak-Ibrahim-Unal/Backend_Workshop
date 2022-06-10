using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Products.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // this settings make all Id's must be unique
        public string Id { get; set; }
        

        [BsonElement("Name")]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        
        
        
    }
}