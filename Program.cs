using Serilog;

var builder = WebApplication.CreateBuilder(args);
Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(builder.Configuration)
                    .CreateBootstrapLogger();


try
{
    // Add services to the container.

    builder.Services.AddControllers()
                    .AddXmlSerializerFormatters();
    // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
    builder.Services.AddOpenApi();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();
    }

    //app.UseHttpsRedirection();

    //app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (System.Exception ex)
{
    Log.Fatal(ex, "host ......");
}
finally
{
    Log.CloseAndFlush();
}

