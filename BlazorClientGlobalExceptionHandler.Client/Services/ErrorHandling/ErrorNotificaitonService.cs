namespace BlazorClientGlobalExceptionHandler.Client.Services.ErrorHandling;

public static class ErrorNotificaitonService
{
    private static List<Exception>? exceptions = new List<Exception>();

    public static void AddException(Exception exception)
    {
        exceptions!.Add(exception);
        NotifyStateChanged();
    }

    public static List<Exception> GetExceptions()
    {
        var exs = exceptions;

        return exs!;
    }

    public static event Action? OnExceptionListChange;

    private static void NotifyStateChanged() => OnExceptionListChange?.Invoke();
}
