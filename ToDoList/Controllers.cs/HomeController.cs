using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);

      // code below shows one item
      // Item starterItem = new Item("Add first item to To Do List");
      // return View(starterItem);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");

      //code below shows one item
      // Item myItem = new Item(description);
      // return View("Index", myItem);
    }
  }
}