var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Commentaire test
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
int a = 0;
while (a > 100)
{
    WeatherForecast.Leopard = "ABCDEFGHIJKLMNOP";
    global::System.Console.WriteLine(WeatherForecast.Leopard);
    a++;
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;


Coucou c'est greg qui est venu perturber un peu le code , lol ;-)


app.Run();
