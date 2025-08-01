using ToDo.Model.SubModel;

namespace ToDo.Model.EntryTypes;

public class FolderEntry : Entry
{
    public FolderEntry(string name, string? description, string path, List<Tag> tags) 
        : base(name, description, path, tags)
    {
    }
    
    public FolderEntry()
    {}
}