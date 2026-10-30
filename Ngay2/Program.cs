var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// ============================================================
// CONVENTIONAL ROUTING: Định nghĩa URL pattern theo convention
// URL sẽ tự động map theo pattern: {controller}/{action}/{id?}
// Không cần dùng [Route] attribute trên controller/action
// ============================================================

// Conventional Route cho trang Blog với URL ngắn gọn: /blog
app.MapControllerRoute(
    name: "blog",
    pattern: "blog",
    defaults: new { controller = "Home", action = "Blog" });

// Conventional Route cho trang FAQ với URL ngắn gọn: /faq  
app.MapControllerRoute(
    name: "faq",
    pattern: "faq",
    defaults: new { controller = "Home", action = "FAQ" });

// Default conventional route: {controller=Home}/{action=Index}/{id?}
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// ============================================================
// ATTRIBUTE ROUTING: Các controller có [Route] attribute (vd: HelloController)
// sẽ tự động được nhận diện bởi MapControllerRoute ở trên
// Attribute Routing được ưu tiên hơn Conventional Routing
// ============================================================

app.Run();
