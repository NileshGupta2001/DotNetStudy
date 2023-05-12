using Microsoft.EntityFrameworkCore;
using WebAPIStudy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = @"server = DESKTOP-QG50OON\SQLEXPRESS;initial catalog = DoctorDB; integrated security = true;TrustServerCertificate=True ";
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connectionString));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
