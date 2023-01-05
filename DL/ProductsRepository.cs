using Models;
using MongoDB.Driver;

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
        throw new NotImplementedException();
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
