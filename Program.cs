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

System.Console.WriteLine("I made a change here on 4/7/23 we need to pull this data on Monday so that we can get this boat sailing!");

System.Console.WriteLine("Test code 4/10/23");

System.Console.WriteLine("Will this string help Addie or will she have to talk to Jeff find out on the nffext episode of MIS321");
System.Console.WriteLine("It did in fact help Addie!!!!");

System.Console.WriteLine("lfg bitchez i got it to work");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//One option that she could try is that she could make a copy of the local version of the project that includes all the changes that she has made, then clone in the github repo again and manually copy & paste her changes then push the new repo and trash the original file
//Another option is that she can, depending on the error, run a rebase to catch her local version up with the remote repository

// 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