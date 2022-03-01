using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGruppenArbeitLHOFLH.Infrastructure
{
    public class EntryDbContext : DbContext
    {
        //https://blogs.myfirstsharepoint.de/technikblog/serverunabhaengige-datenbanken-mit-c-net-framework-sqlite-und-dem-entity-framework
        public EntryDbContext() : base("name=OOPGruppenArbeitDb")
        {
            Database.ExecuteSqlCommand("CREATE TABLE IF NOT EXISTS 'DiaryEntries' ('Id' TEXT PRIMARY KEY, 'DateTime' TEXT, 'Tags' TEXT, 'EntryText' TEXT, 'PicturePath' TEXT)");
            Database.ExecuteSqlCommand("CREATE TABLE IF NOT EXISTS 'Users' ('Username' TEXT PRIMARY KEY, 'Password' TEXT)");
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }
        public DbSet<User> Users { get; set; }
    }

    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
