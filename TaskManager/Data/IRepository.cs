using TaskManager.Models;

namespace TaskManager.Data;

public interface IRepository
{
    List<TaskDto>? GetAllTasks();
    void SaveTasks(List<TaskDto> tasks);
}