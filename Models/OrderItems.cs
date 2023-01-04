namespace Models;

public class OrderItems
{
    private int _ordID;
    public int OrdID
    {
        get { return _ordID; }
        set { _ordID = value; }
    }
    
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
    
    private int _custID;
    public int CustID
    {
        get { return _custID; }
        set { _custID = value; }
    }
    
}