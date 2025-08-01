using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Model.EntryTypes;

public class CalendarEntry : Entry
{
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public CalendarEntry(string name, string description, string path, List<SubModel.Tag> tags, DateOnly startDate, DateOnly endDate, TimeOnly startTime, TimeOnly endTime)
        : base(name, description, path, tags)
    {
        StartDate = startDate;
        EndDate = endDate;
        StartTime = startTime;
        EndTime = endTime;
    }
        
    public CalendarEntry()
    {}
}
