using System.Data.Common;
using System.Reflection;
using HTTPApiTemplate.Models;
using HTTPApiTemplate.Repository;
using HTTPApiTemplate.Repository.Argument;
using Microsoft.EntityFrameworkCore;
using ProductMarket.Config;


var builder = WebApplication.CreateBuilder(args);


var connectionString = GetConnectionString(builder.Environment.EnvironmentName, builder);

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseNpgsql(connectionString));
builder.Services.AddScoped
    <IRepository<Product, CreateProductArgument, UpdateProductArgument>, ProductService>();
builder.Services.AddControllers();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => $"{app.Environment.EnvironmentName}");

app.Run();

string? GetConnectionString(string stage, WebApplicationBuilder hostBuilder)
{
    switch (stage)
    {
        case "Development":
            var dataBaseOptions =
                hostBuilder.Configuration.GetSection(DataBaseOptions.OptionName)
                    .Get<DataBaseOptions>();
            if (dataBaseOptions is null)
                throw new ArgumentNullException(nameof(dataBaseOptions));
            DbConnectionStringBuilder connectionStringBuilder = new DbConnectionStringBuilder();
            connectionStringBuilder.Add("Host", dataBaseOptions.Server);
            connectionStringBuilder.Add("Port", dataBaseOptions.Port);
            connectionStringBuilder.Add("Username", dataBaseOptions.UserName);
            connectionStringBuilder.Add("Database", dataBaseOptions.DatabaseName);
            connectionStringBuilder.Add("Password", dataBaseOptions.Password);
            return connectionStringBuilder.ConnectionString;
            break;
        default:
            return null;

    }
}
/*  todo
 
 * global logging
 * global exception handler
 * authorization & authentification
 * automapper
 * Data Access Layer(?) Unity repo?
 
 
*/

