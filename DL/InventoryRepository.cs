using Models;
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
        throw new NotImplementedException();
    }

    public List<Inventory> GetAll()
    {
        throw new NotImplementedException();
    }

    public Inventory Update(Inventory p_resource)
    {
        throw new NotImplementedException();
    }

    public Inventory Delete(Inventory p_resource)
    {
        throw new NotImplementedException();
    }
}
