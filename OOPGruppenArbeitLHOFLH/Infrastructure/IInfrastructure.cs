using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGruppenArbeitLHOFLH
{
    public interface IInfrastructure
    {
        void SaveDiaryEntry(DiaryEntry entry);
        
        DiaryEntry GetDiaryEntry(string key);

        List<DiaryEntry> GetDiaryEntries(DateTime? start = null, DateTime? end = null);

        List<string> GetTags();
    }
}
