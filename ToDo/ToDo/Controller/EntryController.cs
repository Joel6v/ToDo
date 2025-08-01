using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Model;
using ToDo.Model.EntryTypes;

namespace ToDo.Controller
{
    public class EntryController<T> where T : Entry
    {
        public List<T> EntryList { get; private set; }

        //private Repository Repository { get; set; }

        public EntryController()
        {
            EntryList = new List<T>();
            //Repository = new Repository();
            //EntryList = Repository.GetEntries();
        }

        public bool IsEntryNameUnique(string name, string path)
        {
            for (int i = 0; i < EntryList.Count; i++)
            {
                if (EntryList[i].Name == name && EntryList[i].Path == path)
                {
                    return false;
                }
            }
            
            return true;
        }
        
        public List<T> GetEntries()
        {
            return EntryList;
        }
        
        public T GetEntry(int index)
        {
            if (index >= 0 && index < EntryList.Count)
            {
                return EntryList[index];
            }
            return null;
        }
        
        public int GetEntryCount()
        {
            return EntryList.Count;
        }

        public void AddEntry(T entry)
        {
            ArgumentNullException.ThrowIfNull(entry);

            EntryList.Add(entry);
            //Repository.SaveEntry(entry);
        }

        public void EditEntry(int index, T entry)
        {
            if (index >= 0 && index < EntryList.Count)
            {
                EntryList[index] = entry;
            }
        }

        public void RemoveEntry(int index)
        {
            if (index >= 0 && index < EntryList.Count)
            {
                EntryList.RemoveAt(index);
            }
        }
    }
}
