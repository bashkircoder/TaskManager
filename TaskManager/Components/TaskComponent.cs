using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Components;

public class TaskComponent : ViewComponent
{
    public IViewComponentResult Invoke(List<TaskDto> tasks)
    {
        return View(tasks);
    }
}