using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to To Do List");
      static void ViewMenu() {
        Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
        // run add()
        // run view()
        // else run ViewMenu()
      }
      ViewMenu();
      string userResponse = Console.ReadLine();
      if (userResponse == "Add" || userResponse == "add")
      {
        Console.WriteLine("What would you like to add?");
        string itemToAdd = Console.ReadLine();
        Item newItem = new Item(itemToAdd);
        List<Item> newList = new List<Item> { newItem };
        Console.WriteLine(newItem.Description + " has been added to your ToDo list!");
        Main();
      }
        // ViewMenu();
      else if (userResponse == "View" || userResponse == "view")
      {
        List<Item> newList = Item.GetAll();
        for(int index = 0; index < newList.Count; index++)
        {
          // Console.WriteLine(task.Description);
          Console.WriteLine(newList[index].Description);
          Main();
        }
      }
      else {
        Console.WriteLine("You just started the app, you have no list, wompwomp");
        ViewMenu();
      }
    }
  }
}