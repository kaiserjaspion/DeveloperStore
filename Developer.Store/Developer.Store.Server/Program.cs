using Developer.Store.Application.Mapping;
using Developer.Store.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

Developer.Store.Commands.Startup.ConfigureCommand(builder.Services);

Developer.Store.Hadlers.Startup.ConfuigureHandler(builder.Services);

var systemSecuritykey = builder.Configuration.GetSection("SymmetricSecurityKey")
                            .ToString() ?? "";

builder.Services.AddAutoMapper(typeof(Mapper));
var systemKey = new SymmetricSecurityKey(
                            Encoding.ASCII.GetBytes(systemSecuritykey));

builder.Services.AddSingleton<SymmetricSecurityKey>(systemKey);

builder.Services.AddDbContext<StoreContext>(c => { 
        c.UseSqlServer(builder.Configuration.GetConnectionString("StoreSQLContext"),b => b.MigrationsAssembly("Developer.Store.Server")); 
    });

Developer.Store.Application.Startup.ConfigureApplicationDepencies(builder.Services);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
