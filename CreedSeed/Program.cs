var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOrchardCms();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

var list = new List<Tuple<int, string>>();
var tuple = Tuple.Create(1, "eins");
list.Add(tuple);
list.DistinctBy(l => l.Item2)

app.UseStaticFiles();
app.UseOrchardCore();

app.Run();
