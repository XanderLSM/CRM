﻿using CRM.Server.Configurations.Entities;
using CRM.Server.Models;
using CRM.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CRM.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Blogpost> Blogposts { get; set; }
        public DbSet<Blogcategory> Blogcategorys { get; set; }
        public DbSet<Blogcomment> Blogcomments { get; set; }

    

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ColourSeedConfiguration());
            builder.ApplyConfiguration(new MakeSeedConfiguration());
            builder.ApplyConfiguration(new ModelSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new BlogcategorySeedConfiguration());
        }
    }
}
