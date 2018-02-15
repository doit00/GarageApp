namespace GarageApp
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class CarDb : DbContext
    {
        // Your context has been configured to use a 'CarDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GarageApp.CarDb' database on your LocalDb instance. 
        // If you wish to target a different database and/or database provider, modify the 'CarDb' 
        // connection string in the application configuration file.
        public CarDb()
            : base("name=CarDb")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Garage> Garages { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int EngineCapacity { get; set; }
        public virtual IEnumerable<Document> Documents { get; set; }
    }
    public class Garage
    {
        public int Id { get; set; }
        public virtual IEnumerable<Car> Cars { get; set; }
    }
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}