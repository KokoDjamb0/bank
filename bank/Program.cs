using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();

        
        builder.Services.AddDbContext<BankDbContext>(options =>
        {
            options.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True"); 
        });

        builder.Services.AddSwaggerGen();
        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapEntityEndpoints<Student, BankDbContext>("/Student");
        app.MapEntityEndpoints<grade, BankDbContext>("/grade");
        app.MapEntityEndpoints<grade, BankDbContext>("/PROMPUN");
        app.MapEntityEndpoints<Composition_Family, BankDbContext>("/Composition_Family");
        app.MapEntityEndpoints<Creativity_Activity, BankDbContext>("/Creativity_Activity");
        app.MapEntityEndpoints<Education, BankDbContext>("/Education");
        app.MapEntityEndpoints<Eventss, BankDbContext>("/Eventss");
        app.MapEntityEndpoints<Parents, BankDbContext>("/Parents");
        app.MapEntityEndpoints<Participation_in_event, BankDbContext>("/Participation_in_event");
        app.MapEntityEndpoints<PROMPUN, BankDbContext>("/Promotion");
        app.MapEntityEndpoints<Students_Promotions, BankDbContext>("/Students_Promotions");
        app.MapEntityEndpoints<Punishment, BankDbContext>("/Punishment");
        app.MapEntityEndpoints<Student_Punishments, BankDbContext>("/Student_Punishments");
        app.MapEntityEndpoints<Student_Creativity, BankDbContext>("/Student_Creativity");

        app.Run();
    }
}

public static class EntityEndpoints
{
    public static void MapEntityEndpoints<TEntity, TDbContext>(this WebApplication app, string routePrefix)
        where TEntity : class
        where TDbContext : DbContext
    {
        app.MapGet(routePrefix, async (TDbContext dbContext) =>
        {
            var entities = await dbContext.Set<TEntity>().ToListAsync();
            return entities;
        });

        app.MapGet($"{routePrefix}/{{id}}", async (int id, TDbContext dbContext) =>
        {
            var entity = await dbContext.Set<TEntity>().FindAsync(id);
            if (entity == null) return Results.NotFound();
            return Results.Ok(entity);
        });

        app.MapPost(routePrefix, async (TDbContext dbContext, TEntity entity) =>
        {
            dbContext.Set<TEntity>().Add(entity);
            await dbContext.SaveChangesAsync();
            return Results.Created($"{routePrefix}/{entity}", entity);
        });

        app.MapPut($"{routePrefix}/{{id}}", async (int id, TDbContext dbContext, TEntity entity) =>
        {
            var existingEntity = await dbContext.Set<TEntity>().FindAsync(id);
            if (existingEntity == null) return Results.NotFound();
            dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
            await dbContext.SaveChangesAsync();
            return Results.Ok(entity);
        });

        app.MapDelete($"{routePrefix}/{{id}}", async (int id, TDbContext dbContext) =>
        {
            if (await dbContext.Set<TEntity>().FindAsync(id) is TEntity entity)
            {
                dbContext.Set<TEntity>().Remove(entity);
                await dbContext.SaveChangesAsync();
                return Results.NoContent();
            }
            return Results.NotFound();
        });
    }
}
