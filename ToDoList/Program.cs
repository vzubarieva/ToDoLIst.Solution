// using System;
// using System.Collections.Generic;
// using ToDoList.Models;

// namespace ToDoList.Models
// {
//   public class Program
//   {
//     static void Main()
//     {
//       static void Main()
//      {
      
//       Console.WriteLine("Welcome to the To Do List");
//       Console.WriteLine("Would you like to add an item to your list or view your list? Add/View");
//       string userAddView = Console.ReadLine();

//       if (userAddView == "Add") 
//       {
//         Console.WriteLine("Enter an item to your to do list");
//         string task = Console.ReadLine(); 
//         Item newItem = new Item(task);
//         Console.WriteLine(task + " was added to your to do list.");
      
//         Main();
//       } 
//           else if (userAddView == "View") 
//         {
//            List<Item> toDoList = Item.GetAll();
//            foreach (Item item in toDoList)
//            {
//            Console.WriteLine(item.Description);
//            }
          
//         }
      
//       }
//     }
//   }
// }
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}