var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

System.Console.WriteLine("I made a change here on 4/7/23 we need to pull this data on Monday so that we can get this boat sailing! blah b;ah blah ");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
