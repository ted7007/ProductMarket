using HTTPApiTemplate.Models;
using HTTPApiTemplate.Repository;
using HTTPApiTemplate.Repository.Argument;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IRepository<Product, CreateProductArgument, UpdateProductArgument>, ProductService>();
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => $"{app.Environment.EnvironmentName}");

app.Run();

/*  todo
 
 * global logging
 * global exception handler
 * authorization & authentification
 * automapper
 * Data Access Layer(?) Unity repo?
 
 
*/

