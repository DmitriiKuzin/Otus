var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://[::]:8000");

var app = builder.Build();

app.MapGet("/health", () =>  new Response{Status = "OK"});
app.Run();