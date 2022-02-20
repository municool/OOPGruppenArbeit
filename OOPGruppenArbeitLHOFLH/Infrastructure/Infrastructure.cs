using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGruppenArbeitLHOFLH
{
    public class Infrastructure : IInfrastructure
    {
        public List<DiaryEntry> GetDiaryEntries(DateTime? start = null, DateTime? end = null)
        {
            throw new NotImplementedException();
        }

        public DiaryEntry GetDiaryEntry(string key)
        {
            throw new NotImplementedException();
        }

        public List<string> GetTags()
        {
            throw new NotImplementedException();
        }

        public void SaveDiaryEntry(DiaryEntry entry)
        {
            throw new NotImplementedException();
        }
    }
}
