namespace StoreProject
{
    public class CustomerMenu : IStoreMenu 
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