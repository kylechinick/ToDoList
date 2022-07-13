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
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string userResponse = Console.ReadLine();

      if (userResponse == "Add" || userResponse == "add")
      {
        Console.WriteLine("What would you like to add?");
        string itemToAdd = Console.ReadLine();
        Item newItem = new Item(itemToAdd);
        List<Item> newList = new List<Item> { newItem };
        Console.WriteLine(newItem.Description + " has been added to your ToDo list!");

        Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
        userResponse = Console.ReadLine();
          if (userResponse == "View" || userResponse == "view")
          {
            foreach (Item task in newList)
          {
            Console.WriteLine(task.Description);
          }
          }
          else {
            Console.WriteLine("Are you finished with this program (Yes/No)");
            string finished = Console.ReadLine();
            if (finished == "yes" || finished == "Yes")
            {Console.WriteLine("See you later");
            }
            else {
              Main();
            }
          }
      }
        else {
          Console.WriteLine("You just started the app, you have no list, wompwomp");

          // List<Item> newList = new List<Item> {};
          // Console.WriteLine(newList[0]);
          // foreach (Item task in newList)
          // {
          //   Console.WriteLine("line 27 reached");
          //   Console.WriteLine(task.Description);
          // }
          
        }
          //Main();
    }
  }
}