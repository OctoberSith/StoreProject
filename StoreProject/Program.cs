using StoreProject;

/// <summary>
/// Program Logic
/// </summary>
bool isRunning = true;
IStoreMenu menu = new StoreMenu();


while (isRunning)
{
    menu.MenuDisplay();
    string UserInput = menu.UserSelection();
    switch(UserInput)
    {
        case "Exit":
            isRunning = false;
            break;
        case "Customer":
            menu = new CustomerMenu();
            break;
        case "Admin":
            menu = new AdminMenu();
            break;
        default:
            break;
    }
}
