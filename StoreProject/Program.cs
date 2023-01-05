﻿using Microsoft.Extensions.Configuration;
using StoreProject;
using DL;
using Models;


var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();
string _connectionstring = configuration.GetConnectionString("SPR");


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
        case "AddProduct":
            menu = new AddProductMenu(new ProductsRepository(_connectionstring));
            break;
        default:
            break;
    }
}
