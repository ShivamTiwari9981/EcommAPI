using EcommAPI.Service.Category;
using EcommAPI.Service.Image;
using EcommAPI.Service.Module;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "AllowOrigin",
        builder => {
            builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
        });
});
builder.Services.AddCors();
// Add services to the container.
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<IAppModuleService, AppModuleService>();
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
app.UseCors("AllowOrigin");
app.UseAuthorization();

app.MapControllers();

app.Run();
