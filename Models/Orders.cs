namespace Models;

public class Orders
{
    private int _ordID;
    public int OrdID
    {
        get { return _ordID; }
        set { _ordID = value; }
    }
    
    private string _ordDate;
    public string OrdDate
    {
        get { return _ordDate; }
        set { _ordDate = value; }
    }

    private double _ordTotal;
    public double OrdTotal
    {
        get { return _ordTotal; }
        set { _ordTotal = value; }
    }
    
}