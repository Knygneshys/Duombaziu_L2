﻿using Microsoft.EntityFrameworkCore;
using Trikotazo_Parduotuve.Entities;

namespace Trikotazo_Parduotuve
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Kategorija> Kategorijos { get; set; }
        public DbSet<Subkategorija> Subkategorijos { get; set; }
        public DbSet<F1> F1 { get; set; }
        public DbSet<Tiekejas> Tiekejai { get; set; }
        public DbSet<Trikotazas> Trikotazai { get; set; }
        public DbSet<AtaskaitaEntry> AtaskaitosEntries { get; set; }
        public DbSet<AtaskaitaTopic> AtaskaitosTopics { get; set; }

        public StoreDataContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
