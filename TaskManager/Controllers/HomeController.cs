using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
using TaskManager.Models;
using Task = System.Threading.Tasks.Task;
using TaskStatus = TaskManager.Common.TaskStatus;

namespace TaskManager.Controllers;

public class HomeController(IRepository context) : Controller
{

    public IActionResult Index()
    {
        var tasks = context.GetAllTasks();
        
        return View(tasks);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
}