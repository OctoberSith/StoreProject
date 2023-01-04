namespace Models;

public class Products
{
    private int _prodID;
    public int ProdID
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
    
    private int _prodcat;
    public int ProdCat
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
