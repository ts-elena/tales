namespace TalesAPI.Tools
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using Newtonsoft.Json;
    using TalesApp.Data;

    public static class Seeder
    {
        public static void Seedit<TModel>(string jsonData, IServiceProvider serviceProvider) where TModel: class
        {
            IEnumerable<TModel> convertedObject = JsonConvert.DeserializeObject<IEnumerable<TModel>>(jsonData);

            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<TalesContext>();
                context.AddRange(convertedObject);
                context.SaveChanges();
            }
        }
    }
}
