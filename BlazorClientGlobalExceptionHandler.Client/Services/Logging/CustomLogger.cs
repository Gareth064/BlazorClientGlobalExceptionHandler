
using BlazorClientGlobalExceptionHandler.Client.Services.ErrorHandling;

namespace BlazorClientGlobalExceptionHandler.Client.Services.Logging;

public class CustomLogger : ILogger
{
    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        Console.WriteLine($"[{logLevel}] {formatter(state, exception)}");

        if (exception is not null)
            ErrorNotificaitonService.AddException(exception);
    }
}

public class CustomLoggerProvider : ILoggerProvider
{
    public ILogger CreateLogger(string categoryName)
    {
        return new CustomLogger();
    }
    public void Dispose()
    {
    }
}
