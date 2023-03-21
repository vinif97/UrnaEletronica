using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using UrnaEletronica.Infrastructure.Context;

namespace UrnaEletronica.WebApi.Extensions
{
    public static class DatabaseConfigure
    {
        public static void Migrate(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<EletronicUrnContext>();
            context.Database.Migrate();
        }
    }
}
