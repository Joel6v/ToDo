using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Model.SubModel;

namespace ToDo.Model.EntryTypes;

public abstract class Entry
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Path { get; set; } = string.Empty;
    public List<Tag> Tags { get; set; }
    public DateTime CreatedAt { get; set; }

    public Entry( string name, string? description, string path, List<Tag> tags)
    {
        Name = name;
        Description = description;
        Path = path;
        Tags = tags;
        CreatedAt = DateTime.Now;
    }

    public Entry()
    {
        Name = "Enter Name";
        Tags = new List<Tag>();
    }

    public string GetTagStr(int index)
    {
        if(Tags.Count > index)
            return Tags[index].Name;
        else
            return string.Empty;
    }
}