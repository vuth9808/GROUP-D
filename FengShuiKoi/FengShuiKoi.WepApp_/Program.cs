using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Reponsitories.Res;
using FengShuiKoi.Reponsitories.IReponsitories;
using FengShuiKoi.Services.IServices;
using FengShuiKoi.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//DI 
builder.Services.AddDbContext<FengShuiKoiContext>();
//DI Reponsitories
builder.Services.AddScoped<NhanVien_Res, NhanVien_Res>();
//DI services
builder.Services.AddScoped<INhanVien_Ser, NhanVien_Ser>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
