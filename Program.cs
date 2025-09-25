using System.IO;

class Program
{
    static void Main()
    {
        
        // Print Basic Info and startup message
        Console.WriteLine("KeystrokeInjectionDetector - startup");
        Console.WriteLine($"Process ID: {Environment.ProcessId}");
        Console.WriteLine($"OS: {Environment.OSVersion}");

        // Create logs directory
        string logsDir = Path.Combine(Directory.GetCurrentDirectory(), "logs");
        Directory.CreateDirectory(logsDir);
        Console.WriteLine($"Logs Directory: {logsDir}");

        // Create fresh file each time 
        string csvPath = Path.Combine(logsDir, $"keystroke_log_{DateTime.Now:yyyyMMdd_HHmmss}.csv");
        using (var sw = new StreamWriter(csvPath, false, System.Text.Encoding.UTF8))
        {
            sw.WriteLine("Timestamp,Vkcode,ScanCode,Flags,WindowsProcess,WindowsTitle,ExtraInfo");
        }

        Console.WriteLine($"Created CSV: {csvPath}");

    }
}
