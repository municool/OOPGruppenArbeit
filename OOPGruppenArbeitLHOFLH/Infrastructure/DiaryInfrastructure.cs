using OOPGruppenArbeitLHOFLH.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace OOPGruppenArbeitLHOFLH
{
    public class DiaryInfrastructure : IInfrastructure
    {

        public List<DiaryEntry> GetDiaryEntries(DateTime? start = null, DateTime? end = null)
        {
            var entries = dbContext.DiaryEntries.ToList();

            if(start != null)
            {
                entries = entries.Where(e => e.DateTime > start).ToList();
            }

            if(end != null)
            {
                entries = entries.Where(e => e.DateTime < end).ToList();
            }

            return entries;
        }

        public DiaryEntry GetDiaryEntry(string key)
        {
            return dbContext.DiaryEntries.FirstOrDefault(e => e.Id == Guid.Parse(key));
        }

        public List<string> GetTags()
        {
            var filePath = ConfigurationManager.AppSettings[TagsFilePathSettinsName];

            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath).Split(',').ToList();
            }

            return new List<string>();
        }

        public void SaveDiaryEntry(DiaryEntry entry)
        {
            if(dbContext.DiaryEntries.Any(e => e.Id == entry.Id))
            {
                dbContext.Entry(entry).State = EntityState.Modified;
            }
            else
            {
                dbContext.DiaryEntries.Add(entry);
            }

            SaveTags(entry.GetTags());

            dbContext.SaveChanges();
        }

        private void SaveTags(List<string> entryTags)
        {
            var tags = GetTags();

            tags.AddRange(entryTags.Except(tags));

            File.WriteAllText(TagsFilePathSettinsName, string.Join(",", tags));
        }

        private readonly EntryDbContext dbContext = new EntryDbContext();

        private const string TagsFilePathSettinsName = "TagsFilePath";
    }
}
