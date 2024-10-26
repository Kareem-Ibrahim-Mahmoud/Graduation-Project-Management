using Microsoft.AspNetCore.Identity;
using Your_Graduation.Model;
using Your_Graduation.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





builder.Services.AddDbContext<Context>();

builder.Services.AddIdentity<ApplcationUser, IdentityRole>()
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders()
    .AddSignInManager<SignInManager<ApplcationUser>>();

builder.Services.AddScoped<IDoctorReposatry, DoctorReposatry>();
builder.Services.AddScoped<IStudentReposatry, StudentReposatry>();
builder.Services.AddScoped<ITasksReposatry, TaskRebosatry>();
builder.Services.AddScoped<IGroupReposatry, groupReposatry>();






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
