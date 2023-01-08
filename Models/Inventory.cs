using MongoDB.Bson.Serialization.Attributes;
namespace Models;

public class Inventory
{
    [BsonId]
    private Guid _invID;
    public Guid InvID
    {
        get { return _prodID; }
        set { _prodID = value; }
    }
    private Guid _prodID;
    public Guid ProdID
    {
        get { return _prodID; }
        set { _prodID = value; }
    }
    
    private int _storeID;
    public int StoreID
    {
        get { return _storeID; }
        set { _storeID = value; }
    }
    
    private int _quantity;
    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }
    
}