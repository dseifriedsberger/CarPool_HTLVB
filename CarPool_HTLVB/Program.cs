using Blazorise; 
using Blazorise.Icons.FontAwesome;
using CarPool_HTLVB;
using CarPool_HTLVB.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthService>();

builder.Services.AddScoped<AuthService>();
//builder.Services.AddScoped<IUser, CurUser>();
builder.Services.AddSingleton<IUser, CurUser>();

builder.Services
    .AddBlazorise() 
    .AddFontAwesomeIcons();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
 

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
