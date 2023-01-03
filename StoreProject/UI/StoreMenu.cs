namespace StoreProject
{
    public class StoreMenu : IStoreMenu
    {
        public void MenuDisplay()
        {
            Console.Clear();
            Console.WriteLine("        ======================================");
            Console.WriteLine("        =            Welcome To              =");
            Console.WriteLine("        =         Logistical Orders          =");
            Console.WriteLine("        ======================================");
            Console.WriteLine("        =     Please Make a Selection        =");
            Console.WriteLine("        =      [0] Exit The Store            =");
            Console.WriteLine("        =      [1] Customer Menu             =");
            Console.WriteLine("        =      [2] Administration Menu       =");       
            Console.WriteLine("        ======================================");
        }

        public string UserSelection()
        {
            string UserInput = Console.ReadLine();
            while(string.IsNullOrEmpty(UserInput)){
                Console.WriteLine("Enter a Selection");
                UserInput = Console.ReadLine();
            }

            switch (UserInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "Customer";
                case "2":
                    return "Admin";   
                default:
                    return "Exit";
            }
        }
    }

}