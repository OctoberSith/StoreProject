using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models;

public class Products
{
    [BsonId]
    private Guid _prodID;
    public Guid ProdID
    {
        get { return _prodID; }
        set { _prodID = value; }
    }
    
    private string _prodname;
    public string ProdName
    {
        get { return _prodname; }
        set { _prodname = value; }
    }
    
    private string _prodcomp;
    public string ProdComp
    {
        get { return _prodcomp; }
        set { _prodcomp = value; }
    }
    

    private string _proddesc;
    public string ProdDesc
    {
        get { return _proddesc; }
        set { _proddesc = value; }
    }

    private double _prodprice;
    public double ProdPrice
    {
        get { return _prodprice; }
        set { _prodprice = value; }
    }
    
    private string _prodcat;
    public string ProdCat
    {
        get { return _prodcat; }
        set { _prodcat = value; }
    }

    private int _prodstoreID;
    public int ProdStoreID
    {
        get { return _prodstoreID; }
        set { _prodstoreID = value; }
    }
    
    
}
