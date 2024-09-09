using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SpeciesApi.Repositories;
using SpeciesApi.Repositories.Interfaces;
using SpeciesApi.Services;
using SpeciesApi.Services.Intarfaces;
using SpeciesApi.Services.Interfaces;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyApiDocumentation", Version = "v1" });

    // Configuración para agregar el token JWT
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "AuthHeader",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Introduce tu token en este formato: Bearer {token}"
    });

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
            new string[] {}
        }
    });
});

var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:key"]);  //generacion de la clave

builder.Services.AddAuthentication(options =>     //esquema de autenticacion el cual agrega los servicios necesarios para la autenticacion
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>              //Este bloque añade el esquema JWT Bearer, que es el que se utiliza para validar los tokens JWT.
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = false,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAerialServices, AerialService>();
builder.Services.AddScoped<IAerialRepository, AerialRepository>();

builder.Services.AddScoped<IAquaticServices, AquaticServices>();
builder.Services.AddScoped<IAquaticRepository, AquaticRepository>();

builder.Services.AddScoped<ITerrestrialServices, TerrestrialServices>();
builder.Services.AddScoped<ITerrestrialRepository, TerrestrialRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
