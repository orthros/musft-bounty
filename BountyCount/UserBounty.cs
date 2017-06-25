namespace BountyCount
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UserBounty : DbContext
    {
        // Your context has been configured to use a 'UserBounty' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BountyCount.UserBounty' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'UserBounty' 
        // connection string in the application configuration file.
        public UserBounty()
            : base("name=UserBounty")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<BountyfulUser> Users { get; set; }
    }

    public class BountyfulUser
    {
        public int Id { get; set; }
        public string UseName { get; set; }
        public int BountiesCompleted { get; set; }
    }
}