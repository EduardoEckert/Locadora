using Locadora.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Add DependencyInjection
DependencyInjection.AddDependencyInjection(builder.Services);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope();
    var context = serviceScope
        .ServiceProvider
        .GetRequiredService<MyContext>();

    if (context.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
    {
        context
            .Database
            .Migrate();
    }
}

app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseHttpsRedirection();
//app.UseAuthentication();
//app.UseAuthorization();
app.MapControllers();
app.Run();
