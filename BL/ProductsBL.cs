using Models;
using DL;

namespace BL;
public class ProductsBL : IBusinessLayer<Products>
{
    private IRepository<Products> _repo;

    public ProductsBL(IRepository<Products> repo)
    {
        _repo = repo;
    }
    public Products Add(Products p_resource)
    {
        return _repo.Add(p_resource);
    }

    public Products Delete(Products p_resource)
    {
        return _repo.Delete(p_resource);
    }

    public List<Products> GetAll()
    {
        List<Products> listofproducts = _repo.GetAll();
        return listofproducts;
    }

    public Products Update(Products p_resource)
    {
        return _repo.Update(p_resource);
    }
}
