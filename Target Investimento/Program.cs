using Microsoft.EntityFrameworkCore;
using Target_Investimento.IoC;
using Target_Investimento.Repository.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMyDependencies();

builder.Services.AddDbContext<TargetContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("TargetConnection"));
    });

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
