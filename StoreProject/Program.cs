using StoreProject;
/// <summary>
/// Program Logic
/// </summary>
bool isRunning = true;
IStoreMenu menu = new StoreMenu();
while (isRunning)
{
    menu.MenuDisplay();
    menu.UserSelection();
}
