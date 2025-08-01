namespace ToDo.Model.Enum;

public static class EnumExtension
{
    public static List<string> GetAllNames<T>() where T : System.Enum { 
        return System.Enum.GetNames(typeof(T)).ToList();
    }

    static string GetAllNamesAsString<T>(string separator = ", ") {
        return string.Join(separator, System.Enum.GetNames(typeof(T)));
    }
    
}