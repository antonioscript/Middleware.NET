var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Ex.1
//Middleware Presetation Central (controla todas as solicitações)
app.Run( async context =>
{
    await context.Response.WriteAsync("Hello World");
});

//Ex.2
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 1: Incoming request");
    await next();  // Pass control to the next middleware
    await context.Response.WriteAsync("Middleware 1: Outgoing response");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 2: Incoming request");
    await next();
    await context.Response.WriteAsync("Middleware 2: Outgoing response");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Middleware 3: Handling request and terminating pipeline");
    await context.Response.WriteAsync("Hello, world!");
});




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
