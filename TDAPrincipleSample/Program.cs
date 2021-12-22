// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ILogger logger = new Logger();

var cpuMonitors = new List<CpuMonitor>()
{
    new CpuMonitor(logger, 79),
    new CpuMonitor(logger, 80),
    new CpuMonitor(logger, 81),
    new CpuMonitor(logger, 99)
};

foreach (var monitor in cpuMonitors)
{
    //if (monitor.Value > 80) logger.Log($"Please yavashtar, resid be {monitor.Value}"); this code is wrong in TDA Principle, because we Ask Value and don't Tell to do anything

    monitor.Alert(); // TDA (tell don't ask) Principle, the right code is here

    // other codes ...
}

Console.ReadKey();
