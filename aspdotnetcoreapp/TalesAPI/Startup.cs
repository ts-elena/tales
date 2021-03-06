namespace TalesAPI
{
    using Azure.Storage.Blobs;
    using Microsoft.OpenApi.Models;
    using AutoMapper;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Persistence.Repositories;
    using Services;
    using Services.ServiceInterfaces;
    using TalesApp.Data;
    using TalesApp.Domain.Repositories;
    using TalesApp.Domain.Services;
    using System;
    using TalesAPI.Tools;
    using TalesApp.Domain;
    using TalesAPI.Persistence;

    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "Tales API",
                    Version = "v1"
                });
            });

            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins, builder =>
                {
                    builder.WithOrigins("http://localhost:3000", "https://localhost:44382");
                });
            });

            services.AddDbContext<TalesContext>(options => options
                .UseSqlServer(Configuration.GetConnectionString("TalesContext"))
                .EnableSensitiveDataLogging()
                );

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IStoryRepository, StoryRepository>();
            services.AddScoped<ILineRepository, LineRepository>();
            services.AddScoped<ILineNumberRepository, LineNumberRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IStorySetNumberService, StorySetNumberService>();
            services.AddScoped<IStorySetService, StorySetService>();
            services.AddScoped<IStoryService, StoryService>();
            services.AddScoped<ILineService, LineService>();
            services.AddScoped<ILineNumberService, LineNumberService>();
            services.AddScoped<IDictionaryWordService, DictionaryWordService>();
            services.AddScoped<ICharacterService, CharacterService>();

            services.AddAutoMapper(typeof(Startup));

            services.AddSingleton(x =>
                new BlobServiceClient(Configuration.GetConnectionString("AudioAzureBlob")));
            services.AddSingleton<IBlobService, BlobService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TalesContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            if (!context.StorySet.AnyAsync().Result)
                Seeder.Seedit<StorySet>(System.IO.File.ReadAllText(@"Tools/SeedingData/StorySets.json"), app.ApplicationServices);
            if (!context.StorySetNumber.AnyAsync().Result)
                Seeder.Seedit<StorySetNumber>(System.IO.File.ReadAllText(@"Tools/SeedingData/StorySetNumbers.json"), app.ApplicationServices);
            if (!context.Story.AnyAsync().Result)
                Seeder.Seedit<Story>(System.IO.File.ReadAllText(@"Tools/SeedingData/Stories.json"), app.ApplicationServices);
            if (!context.Character.AnyAsync().Result)
                Seeder.Seedit<Character>(System.IO.File.ReadAllText(@"Tools/SeedingData/Characters.json"), app.ApplicationServices);
            if (!context.Line.AnyAsync().Result)
                Seeder.Seedit<Line>(System.IO.File.ReadAllText(@"Tools/SeedingData/Lines.json"), app.ApplicationServices);
            if (!context.LineNumber.AnyAsync().Result)
                Seeder.Seedit<LineNumber>(System.IO.File.ReadAllText(@"Tools/SeedingData/LineNumbers.json"), app.ApplicationServices);

            app.UseCors(MyAllowSpecificOrigins);
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "Tales API V1");
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
