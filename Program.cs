using Duck_Mail.Builder;
using Duck_Mail.Builder.Impl;
using Duck_Mail.Data;
using Duck_Mail.Repositories;
using Duck_Mail.Repositories.Impl;
using Duck_Mail.Service;
using Duck_Mail.Service.Impl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// SERVICES
builder.Services.AddScoped<ICampaignService, CampaignService>();

// BUILDERS
builder.Services.AddScoped<ICampaignBuilder, CampaignBuilder>();

// REPOSITORIES
builder.Services.AddScoped<ICampaignRepository, CampaignRepository>();

var sqlServerConnectionString = builder.Configuration["ConnectionStrings:Duckmail"];
builder.Services.AddDbContext<DatabaseContext>(opts =>
{
    opts
        .UseSqlServer(sqlServerConnectionString)
        .UseLazyLoadingProxies();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();