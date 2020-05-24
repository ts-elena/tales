namespace aspdotnetcoreapp
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.EntityFrameworkCore;
    using TalesApp.Data;
    using AutoMapper;
    using TalesApp.Domain.Services;
    using aspdotnetcoreapp.Persistence.Repositories;
    using aspdotnetcoreapp.Services;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;
    using aspdotnetcoreapp.Services.ServiceInterfaces;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<TalesContext>(options => options
                .UseSqlServer(Configuration.GetConnectionString("TalesContext"))
                .EnableSensitiveDataLogging()
                );

            services.AddScoped<IStorySetNumberRepository, StorySetNumberRepository>();
            services.AddScoped<IStorySetRepository, StorySetRepository>();
            services.AddScoped<IStoryRepository, StoryRepository>();
            services.AddScoped<ILineRepository, LineRepository>();
            services.AddScoped<ILineNumberRepository, LineNumberRepository>();
            services.AddScoped<IDictionaryWordRepository, DictionaryWordRepository>();
            services.AddScoped<ICharacterRepository, CharacterRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IStorySetNumberService, StorySetNumberService>();
            services.AddScoped<IStorySetService, StorySetService>();
            services.AddScoped<IStoryService, StoryService>();
            services.AddScoped<ILineService, LineService>();
            services.AddScoped<IDictionaryWordService, DictionaryWordService>();
            services.AddScoped<ICharacterService, CharacterService>();

            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
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
