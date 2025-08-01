namespace ToDo.Model.EntryTypes;

public class ProjectEntry : Entry
{
    /// <summary>
    /// The total time for the project.
    /// </summary>
    public float TimeForProject { get; set; }

    /// <summary>
    /// Returns the time for the project left, including the future CalendarSpans.
    /// </summary>
    public float TimeForProjectLeft
    {
        get
        {
            float timeForProjectLeft = 0;
            for (int i = 0; i < CalendarSpans.Count; i++)
            {
                timeForProjectLeft += (float)CalendarSpans[i].EndDateTime.Subtract(CalendarSpans[i].StartDateTime).TotalHours;
            }
            return timeForProjectLeft;
        }
    }
    
    /// <summary>
    /// Returns only the time for the project used in the past.
    /// </summary>
    public float TimeForProjectUsed
    {
        get
        {
            float timeForProjectUsed = 0;
            for (int i = 0; i < CalendarSpans.Count; i++)
            {
                if (CalendarSpans[i].StartDateTime.Date <= DateTime.Now.Date)
                {
                    if (CalendarSpans[i].EndDateTime.Date <= DateTime.Now.Date)
                    {
                        timeForProjectUsed += (float)CalendarSpans[i].EndDateTime.Subtract(CalendarSpans[i].StartDateTime).TotalHours;
                    }
                    else
                    {
                        timeForProjectUsed += (float)(DateTime.Now.Subtract(CalendarSpans[i].StartDateTime)).TotalHours;
                    }
                }
            }
            return timeForProjectUsed;
        }
    }

    public List<CalendarSpan> CalendarSpans { get; set; }

    public ProjectEntry(string name, string description, string path, List<SubModel.Tag> tags, float timeForProject, List<CalendarSpan> calendarSpans)
    : base(name, description, path, tags)
    {
        TimeForProject = timeForProject;
        CalendarSpans = calendarSpans;
    }

    public ProjectEntry()
    {
        CalendarSpans = new List<CalendarSpan>();
    }
}

public class CalendarSpan
{
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }

    public CalendarSpan(DateTime startDateTime, DateTime endDateTime)
    {
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
    }
        
    public CalendarSpan()
    {}
}