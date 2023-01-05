using Models;
namespace DL;

public class ProductRepository : IRepository<Products>
{
    /// <summary>
    /// Depedency Injection by Class Constructor
    /// </summary>
    private readonly string _connect;
    public ProductRepository(string p_connect)
    {
        _connect = p_connect;
    }

    public Products Add(Products p_resource)
    {
        throw new NotImplementedException();
    }

    public List<Products> GetAll()
    {
        throw new NotImplementedException();
    }

    public Products Update(Products p_resource)
    {
        throw new NotImplementedException();
    }

    public Products Delete(Products p_resource)
    {
        throw new NotImplementedException();
    }
}
