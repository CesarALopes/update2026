using Microsoft.EntityFrameworkCore;
using SalesWebMvc;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SalesWebMvcContext") ?? throw new InvalidOperationException("Connection string 'SalesWebMvcContext' not found.");
try { 
builder.Services.AddDbContext<SalesWebMvcContext>
    (options =>options
    .UseMySql
    (connectionString, ServerVersion
    .AutoDetect(connectionString),
    x => x.MigrationsAssembly("SalesWebMvc")));

builder.Services.AddScoped<SeedingService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Se o projeto estiver rodando no seu computador (Modo Desenvolvimento)
if (app.Environment.IsDevelopment())
{
    SeedData(app);
}


app.UseHttpsRedirection();
app.UseRouting();
// ... o resto do código para baixo continua igualzinho estava


app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();


void SeedData(IApplicationBuilder app)
{
    using (var scope = app.ApplicationServices.CreateScope())
    {
        var seedingService = scope.ServiceProvider.GetRequiredService<SeedingService>();
        seedingService.Seed();
    }
}

}
catch(Exception e)
{

    Console.WriteLine("Error : " + e.Message);

}