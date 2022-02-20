using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGruppenArbeitLHOFLH.Infrastructure
{
    public class EntryDbContext : DbContext
    {
        public EntryDbContext() : base("name=OOPGruppenArbeitDb")
        {
            Database.ExecuteSqlCommand(
                "CREATE TABLE IF NOT EXISTS 'DiaryEntries' ('Id' TEXT PRIMARY KEY, 'Description' TEXT, 'Status' INTEGER)");
        }
    }
}
