namespace StoreProject
{
    public class AdminMenu : IStoreMenu 
    {
        public void MenuDisplay()
        {
            Console.Clear();
            Console.WriteLine("        ======================================");
            Console.WriteLine("        =         Logistical Orders          =");
            Console.WriteLine("        ======================================");
            Console.WriteLine("         Press 1 to View Orders");
            Console.WriteLine("         Press 2 to Update Order Status");
            Console.WriteLine("         Press 3 to Update User Profile");
            Console.WriteLine("         Press 4 to Add Product");
            Console.WriteLine("         Press 5 to Update Product");
            Console.WriteLine("         Press 6 to Delete Product");
            Console.WriteLine("         Press 7 to Add Store");
            Console.WriteLine("         Press 0 to Exit");
            Console.WriteLine("        ======================================");
        }
        public string UserSelection()
        {
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "ViewOrder";
                case "2":
                    return "ChangeOrder";
                case "3":
                    return "UpdateProfile";
                case "4":
                    return "AddProduct";
                case "5":
                    return "UpdateProduct";
                case "6":
                    return "DeleteProduct";
                case "7":
                    return "AddStore";
                default:
                    return "Exit";
            }
        }
    }
}