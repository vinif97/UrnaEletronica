using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Domain.Security;
using UrnaEletronica.Domain.ValueObject;
using UrnaEletronica.Infrastructure.Context;
using UrnaEletronica.Infrastructure.Migrations;

namespace UrnaEletronica.WebApi.Extensions
{
    public static class DatabaseConfigure
    {
        public static void Migrate(IApplicationBuilder app)
        {
            var context = GetContext(app);
            context.Database.Migrate();
        }

        public static void Populate(IApplicationBuilder app)
        {
            var context = GetContext(app);

            if (!context.Users.Where(user => user.UserName == "Admin").Any())
            {
                (string password, byte[] salt) = PasswordHash.HashPassword("admin@123");
                Password passwordObject = new Password(password, password, salt);
                context.Users.Add(new User("Admin", "admin@gmail.com", passwordObject, "admin"));

                context.SaveChanges();
            }
        }

        private static EletronicUrnContext GetContext(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<EletronicUrnContext>();

            return context;
        }
    }
}
