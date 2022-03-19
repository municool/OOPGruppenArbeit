using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGruppenArbeitLHOFLH
{
    public interface IBusiness
    {
        DiaryEntry GetDiaryEntry(DateTime date);

        void SaveDiaryEntry(DiaryEntry entry);

        List<string> GetAvailableTags();

        bool IsValidEntry(DiaryEntry entry);

        bool Login(string username, string password);

        Dictionary<string, DateTime> GetEntriesForTag(string tag);

    }
}
