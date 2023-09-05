using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting();
builder.Services.AddControllers();
builder.Services.AddMemoryCache();

builder.Logging.ClearProviders()
    .AddSerilog();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddEndpointsApiExplorer()
        .AddSwaggerGen();
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapDefaultControllerRoute();
app.MapFallbackToFile("index.html");

app.Run();