using FluentValidation.AspNetCore;
using HireWise.API.Configurations.ColumnWriters;
using HireWise.API.Extensions;
using HireWise.API.Filters;
using HireWise.Application;
using HireWise.Infrastructure;
using HireWise.Infrastructure.Filter;
using HireWise.Infrastructure.Services.Storage.Local;
using HireWise.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NpgsqlTypes;
using Serilog;
using Serilog.Context;
using Serilog.Sinks.PostgreSQL;
using System.ComponentModel;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();


builder.Services.AddStorage<LocalStorage>();
//builder.Services.AddStorage(StorageType.Azure);

var allowedOrigin = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>();

// Add services to the container.
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("HwCors", policy =>
//    {
//        policy.WithOrigins(allowedOrigin)
//                .AllowAnyHeader()
//                .AllowAnyMethod();
//    });
//});

builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
));

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt")
    .WriteTo.PostgreSQL(builder.Configuration.GetConnectionString("PostgreSQL"), "logs",
    needAutoCreateTable: true,
    columnOptions: new Dictionary<string, ColumnWriterBase>
    {
        {"message", new RenderedMessageColumnWriter(NpgsqlDbType.Text)},
        {"message_template", new MessageTemplateColumnWriter(NpgsqlDbType.Text)},
        {"level", new LevelColumnWriter(true , NpgsqlDbType.Varchar)},
        {"time_stamp", new TimestampColumnWriter(NpgsqlDbType.Timestamp)},
        {"exception", new ExceptionColumnWriter(NpgsqlDbType.Text)},
        {"log_event", new LogEventSerializedColumnWriter(NpgsqlDbType.Json)},
        {"email", new EmailColumnWriter()}
    })
    .Enrich.FromLogContext()
    .MinimumLevel.Information()
    .CreateLogger();

builder.Host.UseSerilog();

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});
builder.Services.AddControllers();
//builder.Services.AddControllers(options =>
//{
//    options.Filters.Add<ValidationFilter>();
//    options.Filters.Add<RolePermissionFilter>();
//})
//    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<Create_Employee_Validator>())
//    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter =true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "HireWise API", Version = "v1" });

    // Kimlik doðrulama için giriþ yapma iþlemi
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter your API key into the field",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    // Swagger UI'da kimlik doðrulama kullan
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] { }
            }
        });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer("Admin", options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateAudience = true,
            ValidateIssuer = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidAudience = builder.Configuration["Token:Audience"],
            ValidIssuer = builder.Configuration["Token:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
            LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.UtcNow : false,
            NameClaimType = ClaimTypes.Name
        };
    });

var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());
app.UseSerilogRequestLogging();


app.UseStaticFiles();

app.UseHttpLogging();
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.Use(async (context, next) =>
{
    var userEmail = context.User?.FindFirst(ClaimTypes.Email)?.Value;
    LogContext.PushProperty("UserEmail", userEmail);
    await next();
});


app.MapControllers();

app.Run();