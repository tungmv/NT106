using System;
using Microsoft.AspNetCore.Builder;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Server_API.DBContext;
using Server_API.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UserDBContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Users")));
builder.Services.AddDbContext<AdminDBContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Admins")));
builder.Services.AddDbContext<TrainDBContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("TrainSystem")));

builder.Services.AddHostedService<BedAndSeatUpdate>();

var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]);

//Authentication config-------------------------------------------------------------------------------------Authentication config
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

builder.Services.AddAuthorization(options => {
    options.AddPolicy("ValidJwt", policy =>
    {
        policy.RequireAuthenticatedUser();
    });
});



builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
