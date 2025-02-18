using Microsoft.EntityFrameworkCore;
using SistemaGerenciamentoTarefasAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TaskManagementDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();