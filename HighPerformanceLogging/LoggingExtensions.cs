using Microsoft.Extensions.Logging;

namespace HighPerformanceLogging;

public static class LoggingExtensions
{
    private static readonly Action<ILogger, string, Exception?> hello =
        LoggerMessage.Define<string>(
            LogLevel.Information,
            new EventId(1, "Hello"),
            "Hello, world from {Class}!"
        );

    public static void Hello(this ILogger logger, string @class)
    {
        hello(logger, @class, null);
    }
}
