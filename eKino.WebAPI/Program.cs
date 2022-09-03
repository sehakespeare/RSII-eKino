using eKino.Filters;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Database;
using eKino.Services.Implementations;
using eKino.Services.Interfaces;
using eKino.WebAPI;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(x =>
{
    x.Filters.Add<ErrorFilter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
            },
            new string[]{}
        }
    });
});

builder.Services.AddTransient<IUsersService, UsersService>();

builder.Services.AddTransient<IService<eKino.Model.Role, BaseSearchObject>, BaseService<eKino.Model.Role, Role, BaseSearchObject>>();
builder.Services.AddTransient<ICRUDService<eKino.Model.Auditorium, AuditoriumSearchObject, AuditoriumUpsertRequest, AuditoriumUpsertRequest>, BaseCRUDService<eKino.Model.Auditorium, Auditorium, AuditoriumSearchObject, AuditoriumUpsertRequest, AuditoriumUpsertRequest>>();
builder.Services.AddTransient<ICRUDService<eKino.Model.Director, DirectorSearchObject, DirectorUpsertRequest, DirectorUpsertRequest>, BaseCRUDService<eKino.Model.Director, Director, DirectorSearchObject, DirectorUpsertRequest, DirectorUpsertRequest>>();
builder.Services.AddTransient<ICRUDService<eKino.Model.Genre, GenreSearchObject, GenreUpsertRequest, GenreUpsertRequest>, BaseCRUDService<eKino.Model.Genre, Genre, GenreSearchObject, GenreUpsertRequest, GenreUpsertRequest>>();
builder.Services.AddTransient<ICRUDService<eKino.Model.Movie, MovieSearchObject, MovieUpsertRequest, MovieUpsertRequest>, BaseCRUDService<eKino.Model.Movie, Movie, MovieSearchObject, MovieUpsertRequest, MovieUpsertRequest>>();
builder.Services.AddTransient<ICRUDService<eKino.Model.Projection, ProjectionSearchObject, ProjectionUpsertRequest, ProjectionUpsertRequest>, BaseCRUDService<eKino.Model.Projection, Projection, ProjectionSearchObject, ProjectionUpsertRequest, ProjectionUpsertRequest>>();
builder.Services.AddTransient<ICRUDService<eKino.Model.Rating, RatingSearchObject, RatingUpsertRequest, RatingUpsertRequest>, BaseCRUDService<eKino.Model.Rating, Rating, RatingSearchObject, RatingUpsertRequest, RatingUpsertRequest>>();
builder.Services.AddTransient<ICRUDService<eKino.Model.Reservation, ReservationSearchObject, ReservationUpsertRequest, ReservationUpsertRequest>, BaseCRUDService<eKino.Model.Reservation, Reservation, ReservationSearchObject, ReservationUpsertRequest, ReservationUpsertRequest>>();

builder.Services.AddAutoMapper(typeof(IUsersService));

builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<eKinoContext>(options =>
    options.UseSqlServer(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();


using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<eKinoContext>();
    dataContext.Database.Migrate();
}

app.Run();
