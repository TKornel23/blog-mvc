using Blogs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");

builder.Services.AddDbContext<BlogDbContext>(options =>
    options
    .UseSqlServer(connectionString)
    .UseLazyLoadingProxies()
    );
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<SiteUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;

})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<BlogDbContext>();

builder.Services.AddAuthentication().AddFacebook(opt =>
{
    opt.AppId = "290143610050949";
    opt.AppSecret = "bdcb39f7b793be73105a67cf8d0b1e0a";
});

builder.Services.AddAuthentication();

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<GenericRepository<Tag>>();
builder.Services.AddScoped<GenericRepository<Comment>>();
builder.Services.AddScoped<GenericRepository<Blog.Persistence.Blog>>();
builder.Services.AddScoped<IBlogService, BlogService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Blog}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
