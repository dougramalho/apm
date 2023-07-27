using ApmDemonstracao.Core.Repositories;
using ApmDemonstracao.Core.Services;
using ApmDemonstracao.Extensions;
using ApmDemonstracao.Infrastructure.Repositories;
using Elastic.Apm.NetCoreAll;

var builder = WebApplication.CreateBuilder(args);
SerilogExtensions.AddSerilog(builder.Configuration);

//builder.Host.UseElasticApm(builder.Configuration);
// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IPolicyRepository, PolicyRepository>();
builder.Services.AddScoped<IClaimRepository, ClaimRepository>();

builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IPolicyService, PolicyService>();
builder.Services.AddScoped<IClaimService, ClaimService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseAllElasticApm(builder.Configuration);

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
