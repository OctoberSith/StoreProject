using Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DL;

public class InventoryRepository : IRepository<Inventory>
{
    /// <summary>
    /// Depedency Injection by Class Constructor
    /// </summary>
    private readonly string _connect;
    public InventoryRepository(string p_connect)
    {
        _connect = p_connect;
    }


    public Inventory Add(Inventory p_resource)
    {
        MongoClient dbclient = new MongoClient(_connect);
        var database = dbclient.GetDatabase("StoreProject");
        var collection = database.GetCollection<BsonDocument> ("Inventory");
        var document = new BsonDocument{ 
            {"InventoryID", p_resource.ProdID},
            {"ProductID", p_resource.ProdID},
            {"StoreID", p_resource.StoreID},
            {"Quantity", p_resource.Quantity} 
            };
        collection.InsertOne(document);
        return p_resource;
    }

    public List<Inventory> GetAll()
    {
        MongoClient dbclient = new MongoClient(_connect);
        throw new NotImplementedException();
    }

    public Inventory Update(Inventory p_resource)
    {
        MongoClient dbclient = new MongoClient(_connect);
        throw new NotImplementedException();
    }

    public Inventory Delete(Inventory p_resource)
    {
        MongoClient dbclient = new MongoClient(_connect);
        throw new NotImplementedException();
    }
}
