namespace Plumber.Gstd.Entities;

public class Debug
{
    public enum Threshold
    {
        None = 0,      // No debug information is output
        Error = 1,     // Logs all fatal errors
        Warning = 2,   // Logs all warnings
        Fixme = 3,     // Logs all "fixme" messages
        Info = 4,      // Logs all informational messages
        Debug = 5,     // Logs all debug messages
        Log = 6,       // Logs all log messages
        Trace = 7,     // Logs all trace messages
        MemDump = 9    // Logs all memory dump messages
    };
}