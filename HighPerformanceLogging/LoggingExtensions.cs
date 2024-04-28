using Microsoft.Extensions.Logging;

namespace HighPerformanceLogging;

public static partial class LoggingExtensions
{
    [LoggerMessage(
        EventId = 1,
        Level = LogLevel.Information,
        Message = "Hello, world from {Class}!"
    )]
    public static partial void Hello(this ILogger logger, string @class);
}
