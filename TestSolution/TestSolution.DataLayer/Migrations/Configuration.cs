using TestSolution.Model;

namespace TestSolution.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestSolution.DataLayer.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TestSolution.DataLayer.SalesContext context)
        {

            context.SalesOrders.AddOrUpdate(
                so =>so.CustomerName,
                new SalesOrder { CustomerName = "Alex Cabaang", OrderDate = new DateTime(2017,1,15), PoNumber = "67890"},
                new SalesOrder { CustomerName = "Aileen Ordiales", OrderDate = new DateTime(2017,7,5), PoNumber = "12345"},
                new SalesOrder { CustomerName = "Sharmaine Ordiales", OrderDate = DateTime.Today, PoNumber = "33355"}
                );

            context.Customers.AddOrUpdate(
                c =>c.Name,
                new Customer { Name = "Sharmaine Ordiales", Birthdate = new DateTime(1996,1,6), Address = "Bangkal, Makati City", ContactNo = "759-30-74"},
                new Customer { Name = "Benjamin Ordiales", Birthdate = new DateTime(1992,10,6), Address = "Bangkal, Makati City", ContactNo = "567-33-44"},
                new Customer { Name = "Katherine Martinez", Birthdate = new DateTime(1991,12,15), Address = "Pasay City", ContactNo = "345-1576"}
                );

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
