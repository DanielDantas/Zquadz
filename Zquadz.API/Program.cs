using Zquadz.Application;
using Zquadz.Infrastructure;
using Zquadz.Infrastructure.Settings;

var builder = WebApplication.CreateBuilder(args);
{
    // Add application services to the container.
    builder.Services.AddApplication();
    // Add infrastructure services to the container.
    var cosmosSettings = builder.Configuration.GetSection("CosmosSettings").Get<CosmosSettings>();
    builder.Services.AddInfrastructure(cosmosSettings);

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}
var app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
