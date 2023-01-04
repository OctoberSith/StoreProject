namespace Models;
public class Customers
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
    private int _dob;
    public int DOB
    {
        get { return _dob; }
        set { _dob = value; }
    }

    private string _email;
    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    private string _address;
    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    private string _city;
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    private string _state;
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    private int _zipcode;
    public int Zipcode
    {
        get { return _zipcode; }
        set { _zipcode = value; }
    }
            
    private int _password;
    public int Password
    {
        get { return _password; }
        set { _password = value; }
    }

    private int _ccnumber;
    public int CCnumber
    {
        get { return _ccnumber; }
        set { _ccnumber = value; }
    }

    private int _ccdate;
    public int CCdate
    {
        get { return _ccdate; }
        set { _ccdate = value; }
    }
    
    private int _ccsec;
    public int CCsec
    {
        get { return _ccsec; }
        set { _ccsec = value; }
    }
    
}
