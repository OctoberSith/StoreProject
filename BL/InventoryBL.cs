using Models;
using DL;

namespace BL;
public class InventoryBL : IBusinessLayer<Inventory>
{
    private IRepository<Inventory> _repo;

    public InventoryBL(IRepository<Inventory> repo)
    {
        _repo = repo;
    }
    public Inventory Add(Inventory p_resource)
    {
        return _repo.Add(p_resource);
    }

    public Inventory Delete(Inventory p_resource)
    {
        return _repo.Delete(p_resource);
    }

    public List<Inventory> GetAll()
    {
        List<Inventory> listofInventory = _repo.GetAll();
        return listofInventory;
    }

    public Inventory Update(Inventory p_resource)
    {
        return _repo.Update(p_resource);
    }
}
