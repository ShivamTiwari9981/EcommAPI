using EcommAPI.Service.Category;
using EcommAPI.Service.Image;
using EcommAPI.Service.Module;
using Microsoft.AspNetCore.Authentication.Google;

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
builder.Services.AddAuthentication()
    .AddGoogle(options =>
    {
        IConfigurationSection googleAuthNSection =
        builder.Configuration.GetSection("Authentication:Google");
        options.ClientId = googleAuthNSection["ClientId"];
        options.ClientSecret = googleAuthNSection["ClientSecret"];
    })
    .AddFacebook(options =>
 {
     IConfigurationSection FBAuthNSection =
     builder.Configuration.GetSection("Authentication:Facebook");
     options.ClientId = FBAuthNSection["ClientId"];
     options.ClientSecret = FBAuthNSection["ClientSecret"];
 });
   //.AddMicrosoftAccount(microsoftOptions =>
   //{
   //    microsoftOptions.ClientId = config["Authentication:Microsoft:ClientId"];
   //    microsoftOptions.ClientSecret = config["Authentication:Microsoft:ClientSecret"];
   //})
   //.AddTwitter(twitterOptions =>
   //{
   //    twitterOptions.ConsumerKey = config["Authentication:Twitter:ConsumerAPIKey"];
   //    twitterOptions.ConsumerSecret = config["Authentication:Twitter:ConsumerSecret"];
   //    twitterOptions.RetrieveUserDetails = true;
   //});
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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
