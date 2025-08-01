using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Model.SubModel;

namespace ToDo.Model.EntryTypes;

class NoteEntry : Entry
{
    public NoteEntry(string name, string? description, string path, List<Tag> tags) 
        : base(name, description, path, tags)
    {

    }
        
    public NoteEntry()
    {}
}
