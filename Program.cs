var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Load environment variables from the .env file
var configuration = new ConfigurationBuilder()
    .AddEnvironmentVariables()
    .AddJsonFile(".env", optional: true, reloadOnChange: true)
    .Build();

// Get the Google Maps API key from the configuration
var googleMapsApiKey = configuration["GoogleMapsApiKey"];

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Home/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
