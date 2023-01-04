namespace Models;

public class Inventory
{
    private int _prodID;
    public int ProdID
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