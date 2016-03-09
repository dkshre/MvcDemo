namespace MVC5Demo.Web.Migrations
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MVC5Demo.Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC5Demo.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "MVC5Demo.Web.Models.ApplicationDbContext";
        }

        protected override void Seed(MVC5Demo.Web.Models.ApplicationDbContext context)
        {
           // var hasher = new PasswordHasher();


            if (!context.Users.Any(u => u.UserName == "jack"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user0 = new ApplicationUser() { Email = "jack@yhoo.com", EmailConfirmed = true, UserName = "jack@yhoo.com" };
                manager.Create(user0, "Himal@420");

                var user1 = new ApplicationUser() { Email = "dkshre@gmail.com", EmailConfirmed = true, UserName = "dkshre@gmail.com" };
                manager.Create(user1, "Himal@420");
            }


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
