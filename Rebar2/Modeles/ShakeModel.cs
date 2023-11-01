using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class ShakeModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; }  
    public string Name{get; set;} 
    public string Description { get; set;} 
    public double PriceSizeS { get; set;} 
    public double PriceSizeM { get; set;} 
    public double PriceSizeL { get; set;}

}
