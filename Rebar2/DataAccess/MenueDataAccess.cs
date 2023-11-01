using MongoDB.Driver;
using Rebar.Models;
using System.Runtime.CompilerServices;

public class MenueDataAccess
{
    private const string ConnectionString = "mongodb://127.0.0.1:27017";
    private const string DatabaseName = "reber2db";
    private const string MenueCollection = "menue";
    private IMongoCollection<T> ConnectToMongo<T>(in string collection)
    {
        var client = new MongoClient(ConnectionString);
        var db = client.GetDatabase(DatabaseName);
        return db.GetCollection<T>(collection);
    }
    public async Task<List<ShakeModel>> GetAllShakes()
    {
        var shkesCollection = ConnectToMongo<ShakeModel>(MenueCollection);
        var results = await shkesCollection.FindAsync(_ => true);
        return results.ToList();
    }
    public async Task<Task> CreateMenue(Shake shake)
    {
        var shakesCollection = ConnectToMongo<Shake>(MenueCollection);
        return shakesCollection.InsertOneAsync(shake);
    }
}
