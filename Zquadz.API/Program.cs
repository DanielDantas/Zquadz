using Zquadz.Application;
using Zquadz.Infrastructure;
using Zquadz.Infrastructure.Settings;

// CA1852 Type 'Program' can be sealed because it has no subtypes in its containing assembly and is not externally visible
#pragma warning disable CA1852
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
{
    // Add application services to the container.
    _ = builder.Services.AddApplication();
    // Add infrastructure services to the container.
    CosmosSettings? cosmosSettings = builder.Configuration.GetSection("CosmosSettings").Get<CosmosSettings>();
    if (cosmosSettings != null )
        _ = builder.Services.AddInfrastructure(cosmosSettings);

    _ = builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    _ = builder.Services.AddEndpointsApiExplorer();
    _ = builder.Services.AddSwaggerGen();
}
WebApplication app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        _ = app.UseSwagger();
        _ = app.UseSwaggerUI();
    }
    _ = app.UseHttpsRedirection();
    _ = app.UseAuthorization();
    _ = app.MapControllers();
    app.Run();
}
