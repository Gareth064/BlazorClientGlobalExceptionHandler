using BlazorClientGlobalExceptionHandler.Client.Services.Logging;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddLogging(logging =>
{
    if (builder.HostEnvironment.IsProduction())
        logging.ClearProviders();

    logging.AddProvider(new CustomLoggerProvider());
});

builder.Services.AddMudServices();

await builder.Build().RunAsync();
