using System.Text.Json;
using Microsoft.Extensions.ObjectPool;
using TaskManager.Models;

namespace TaskManager.Data;

public class TaskRepository : IRepository
{
    public List<TaskDto>? GetAllTasks()
    {
        var sw = new StreamReader("tasks.json");
        var json = sw.ReadToEnd();

        var tasks = JsonSerializer.Deserialize<List<TaskDto>>(json);

        sw.Close();
        return tasks;
    }

    public void SaveTasks(List<TaskDto> tasks)
    {
        var json = JsonSerializer.Serialize(tasks);
        
        var sw = new StreamWriter("tasks.json");
        
        sw.Write(json);
        
        sw.Close();
    }
}