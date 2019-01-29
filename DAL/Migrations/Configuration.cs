namespace DAL.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.LoyaltyDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LoyaltyDB db)
        {
            User user = new User
            {
                Alias = "Admistrador predeterminado",
                Email = "correo@dominio.com",
                Name = "Administrador",
                PaternalLastname = "Predeterminado",
                Username = "admin",
                Password = "1234"
            };

            db.Users.Add(user);
            db.SaveChanges();

            ApplicationSetting setting = new ApplicationSetting
            {
                BusinessName = "Empresa predeterminada",
                BusinessAnniversary = new DateTime(1900, 1, 1),
                RewardDoublePointsOnBusinessAnniversary = false,
                RewardDoublePointsOnCustomerAnniversary = false,
                AllowCashRequest = true,
                PercentagePoints = 10,
                PointValueCash = 0.1m
            };

            db.ApplicationSettings.Add(setting);
            db.SaveChanges();
        }
    }
}
