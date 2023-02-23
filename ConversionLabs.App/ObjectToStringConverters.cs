namespace ConversionLabs;

public class ObjectToStringConverters {

    public string? UsingAs(object? obj) {
        return obj as string ?? string.Empty;
    }

    public string? UsingCasting(object? obj) {
        return (string?)obj ?? string.Empty;
    }

    public string? UsingConvertToString(object? obj)
    {
        return Convert.ToString(obj) ?? string.Empty;
    }

    public string? UsingToString(object? obj) {
        if (obj != null) {
            return obj.ToString() ?? string.Empty;
        }
        else
        {
            return string.Empty;
        }
    }

}