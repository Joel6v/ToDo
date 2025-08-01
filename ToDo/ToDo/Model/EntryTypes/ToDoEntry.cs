using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Model.Enum;

namespace ToDo.Model.EntryTypes;

public class ToDoEntry : Entry
{
    public float? Duration { get; set; }
    public Difficulty Difficulty { get; set; } = Difficulty.None;
    public Priority Priority { get; set; } = Priority.None;
    public string? Subpriority { get; set; } = null;
    public DateTime? CompletedAt { get; set; }
    public bool IsCompleted
    {
        get { return CompletedAt.HasValue; }
        set
        {
            if (value)
            {
                CompletedAt = DateTime.Now;
            }
            else
            {
                CompletedAt = null;
            }
        }
    }

    public ToDoEntry(string name, string description, string path, List<SubModel.Tag> tags, float duration, Difficulty difficulty, Priority priority)
        : base(name, description, path, tags)
    {
        Duration = duration;
        Difficulty = difficulty;
        Priority = priority;
    }
        
    public ToDoEntry()
    {}
}