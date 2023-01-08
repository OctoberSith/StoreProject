using Models;
using DL;
using BL;
namespace StoreProject;

public class AddProductMenu : IStoreMenu
{
    private IBusinessLayer<Products> _prepo;
     private IBusinessLayer<Inventory> _invrepo;
    public AddProductMenu(IBusinessLayer<Products> prepo,IBusinessLayer<Inventory> invrepo )
    {
        _prepo = prepo;
        _invrepo = invrepo;
    }

    private static Products _newProduct = new Products();
    private static Inventory _newInventory = new Inventory();
    public void MenuDisplay()
    {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("=             Menu : Add Product               =");
            Console.WriteLine("================================================");
            Console.WriteLine("=       Enter New Product Info : Select        =");     
            Console.WriteLine("================================================");
            Console.WriteLine("=[0] - Return to Main Menu");
            Console.WriteLine("=[1] - Add Product");
            Console.WriteLine("=[2] - Save Product");
            Console.WriteLine("================================================");
            Console.WriteLine("=Product Name: " + _newProduct.ProdName);
            Console.WriteLine("=Product Company: " + _newProduct.ProdComp);
            Console.WriteLine("=Product Description: " + _newProduct.ProdDesc);
            Console.WriteLine("=Product Price: " + _newProduct.ProdPrice);
            Console.WriteLine("=Product Category: " + _newProduct.ProdCat);
            Console.WriteLine("=Product StoreID: " + _newProduct.ProdStoreID);
            Console.WriteLine("=Product Quantity: "+ _newInventory.Quantity);
            Console.WriteLine("================================================");
    }

    public string UserSelection()
    {
        string userinput = Console.ReadLine();
        switch (userinput)
        {
            case "0":
                return "Admin";
            case "1":
                Console.Clear();

                //Assign GUID to IDs
                //TODO: FIX????
                //Implement in Repo???
                _newProduct.ProdID = new Guid();
                _newInventory.InvID = new Guid();
                //TODO: FIX????
                //_newInventory.ProdID = _newProduct.ProdID;

                Console.WriteLine("Enter Name");
                _newProduct.ProdName = Console.ReadLine();
                Console.WriteLine("Enter Company");
                _newProduct.ProdComp = Console.ReadLine();
                Console.WriteLine("Enter Description");
                _newProduct.ProdDesc = Console.ReadLine();
                Console.WriteLine("Enter Price");
                _newProduct.ProdPrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Category");
                _newProduct.ProdCat = Console.ReadLine();
                Console.WriteLine("Enter StoreID");
                _newProduct.ProdStoreID = Convert.ToInt32(Console.ReadLine());
                _newInventory.StoreID = _newProduct.ProdStoreID;
                Console.WriteLine("Enter Quantity");
                _newInventory.Quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                return "AddProductMenu";
            case "2":
                Console.Clear();
                Console.WriteLine("Now Saving...");
                _prepo.Add(_newProduct);
                _invrepo.Add(_newInventory);
                Console.WriteLine("Product has been Added. Inventory is Updated Press Enter to Continue");
                Console.ReadLine();
                return "Admin";
            default:
                return "Admin";
        }       
    }
}