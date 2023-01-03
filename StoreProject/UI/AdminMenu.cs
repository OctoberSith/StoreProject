namespace StoreProject
{
    public class AdminMenu : IStoreMenu 
    {
        public void MenuDisplay()
        {
            Console.WriteLine("Coming Soon");
        }
        public string UserSelection()
        {
            Console.ReadLine();
            return "Exit";
        }
       
    }
}