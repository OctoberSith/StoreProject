using Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DL;

public class ProductsRepository : IRepository<Products>
{
    /// <summary>
    /// Depedency Injection by Class Constructor
    /// </summary>
    private readonly string _connect;
    public ProductsRepository(string p_connect)
    {
        _connect = p_connect;
    }

    public Products Add(Products p_resource)
    {
        MongoClient dbclient = new MongoClient(_connect);
        var database = dbclient.GetDatabase("StoreProject");
        var collection = database.GetCollection<BsonDocument> ("Products");
        var document = new BsonDocument{ 
            {"ProductID", p_resource.ProdID},
            {"Name", p_resource.ProdName}, 
            {"Category", p_resource.ProdCat}, 
            {"Company", p_resource.ProdComp},
            {"Price", p_resource.ProdPrice},
            {"Description", p_resource.ProdDesc},
            {"StoreID", p_resource.ProdStoreID}, 
            };
        collection.InsertOne(document);
        return p_resource;
    }

    public List<Products> GetAll()
    {
        MongoClient dbclient = new MongoClient(_connect);
        throw new NotImplementedException();
    }

    public Products Update(Products p_resource)
    {
        MongoClient dbclient = new MongoClient(_connect);
        throw new NotImplementedException();
    }

    public Products Delete(Products p_resource)
    {
        MongoClient dbclient = new MongoClient(_connect);
        throw new NotImplementedException();
    }
}
