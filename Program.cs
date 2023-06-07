using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Webshop.Data;
using Webshop.Models;
using Webshop.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<IBookingRequestRepository, BookingRequestRepository>();
builder.Services.AddMudServices();

//Inject DbContext
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false).
    AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationContext>();


builder.Services.AddIdentityCore<IdentityUser>(options =>
{
    //options.SignIn.RequireConfirmedAccount = true;
    //options.Password.RequireDigit = true;
    //options.Password.RequireLowercase = true;
    //options.Password.RequireUppercase = true;
    //options.Password.RequireNonAlphanumeric = true;
    //options.Password.RequiredLength = 8;
})
    .AddEntityFrameworkStores<ApplicationContext>()
     .AddSignInManager<SignInManager<IdentityUser>>()
     .AddUserManager<UserManager<IdentityUser>>();

//builder.Services.AddDefaultIdentity<IdentityUser>()
//    .AddEntityFrameworkStores<ApplicationContext>();

//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationContext>()
//    .AddDefaultTokenProviders();


//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddUserStore<User>()
//    .AddEntityFrameworkStores<ApplicationContext>()
//    .AddDefaultTokenProviders();


//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
// .AddCookie(options =>
// {
//     options.LoginPath = "/User/Login";
//     options.AccessDeniedPath = "/User/Login";
//     options.LogoutPath = "/User/Logout";
//     options.SlidingExpiration = true;
// });

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.SlidingExpiration = true;
});

builder.Services.AddAuthentication()
        .AddGoogle(options =>
        {
            options.ClientId = "1000468712236-si06l1kehvupv57bar2m8ujg9n8h4359.apps.googleusercontent.com";
            options.ClientSecret = "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";
        });



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

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
