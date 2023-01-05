using Models;
using DL;
namespace StoreProject;

public class AddProductMenu : IStoreMenu
{
    private IRepository<Products> _repo;
    public AddProductMenu(IRepository<Products> repo)
    {
        _repo = repo;
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
            case "2":
            default:
                return "Admin";
        }       
    }
}