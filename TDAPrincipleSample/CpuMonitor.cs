internal class CpuMonitor
{
    private readonly ILogger _logger;

    public CpuMonitor(ILogger logger, long value)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        Value = value;
    }

    public long Value { get; set; }

    /// <summary>
    /// Tell Do Alert, Don't Ask Value
    /// </summary>
    public void Alert()
    {
        if (Value > 80) _logger.Log($"Please yavashtar, resid be {Value}");

        // write other codes ...
    }
}

