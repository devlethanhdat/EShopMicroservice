var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCarter(); // Add Carter
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly); // Register MediatR handlers
});
builder.Services.AddMarten(opts =>
{
    opts.Connection(builder.Configuration.GetConnectionString("Database")!); // Configure Marten
}).UseLightweightSessions();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapCarter(); // Map Carter routes

app.Run();
