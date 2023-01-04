namespace Models;

public class Stores
{
    private int _storeID;
    public int StoreID
    {
        get { return _storeID; }
        set { _storeID = value; }
    }
    
    private string _storeLoc;
    public string StoreLoc
    {
        get { return _storeLoc; }
        set { _storeLoc = value; }
    }
    
}