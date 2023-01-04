namespace StoreProject
{
    public class CustomerMenu : IStoreMenu 
    {
        public void MenuDisplay()
        {
            Console.Clear();
            Console.WriteLine("        ======================================");
            Console.WriteLine("        =         Logistical Orders          =");
            Console.WriteLine("        ======================================");
            Console.WriteLine("         Press 1 to Create Profile");
            Console.WriteLine("         Press 2 to Update Profile");
            Console.WriteLine("         Press 3 to Create an Order");
            Console.WriteLine("         Press 4 to Check Order Status");
            Console.WriteLine("         Press 0 to EXIT");
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
                    return "CreateProfile";
                case "2":
                    return "UpdateProfile";
                case "3":
                    return "CreateOrder";
                case "4":
                    return "TrackOrder";
                default:
                    return "Exit";
            }
        }
       
    }
}