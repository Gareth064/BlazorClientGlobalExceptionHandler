using BlazorClientGlobalExceptionHandler.Client.Services.Logging;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddLogging(logging =>
{
    //if (builder.HostEnvironment.IsProduction())
    logging.ClearProviders();

    logging.AddProvider(new CustomLoggerProvider());
});

await builder.Build().RunAsync();
