using System.Text.Json.Serialization;
using TaskManager.Common;
using TaskStatus = TaskManager.Common.TaskStatus;

namespace TaskManager.Models;

public class TaskDto
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }
    
    [JsonPropertyName("description")]
    public required string Description { get; set; }
    
    [JsonPropertyName("status")]
    public required TaskStatus TaskStatus { get; set; }
}