var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.UseHttpsRedirection();

// ADD NEW ENDPOINTS HERE
// Edit this endpoint to take in two dates and subtract it to get the difference in days.
app.MapGet("/date-diff", (DateTime start, DateTime end) => (end - start).TotalDays);
app.MapGet("/", () => "Hello World!");
app.Run();

// Needed to be able to access this type from the MinimalAPI.Tests project.
public partial class Program
{ }
