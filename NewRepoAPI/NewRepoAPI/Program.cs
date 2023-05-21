using INewRepoDAL;
using Microsoft.EntityFrameworkCore;
using NewRepoDAL;
using NewRepoModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(m =>
{
    string path = AppContext.BaseDirectory + "NewRepoAPI.xml";
    m.IncludeXmlComments(path, true);
});

builder.Services.AddDbContext<NewRepoDbContext>(m => m.UseSqlServer(builder.Configuration.GetConnectionString("ConStr"), m => m.MigrationsAssembly("NewRepoAPI")));
//注册泛型接口IRepository<> ,Repository<>泛型接口服务的实现
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//builder.Services.AddSingleton<IUserDAL>();
//builder.Services.AddScoped<IRepository<User>>();
builder.Services.AddScoped<UserRepository>();
var app = builder.Build();
//app.UseMiddleware<RepositoryMiddleware>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
