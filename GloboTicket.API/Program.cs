using GloboTicket.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

string connectionString = 
    builder.Configuration.GetConnectionString("GloboTicketConnection");
builder.Services.AddInfrastructure(connectionString);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();