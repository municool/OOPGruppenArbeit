using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGruppenArbeitLHOFLH
{

    public class DiaryBusiness : IBusiness
    {
        IInfrastructure infrastructure = new DiaryInfrastructure();

        public List<string> GetAvailableTags()
        {
            // Aus IInfrastructure aufrufen


            throw new NotImplementedException();
        }

        public DiaryEntry GetDiaryEntry(DateTime date)
        {
            //Tagebucheintrag aufrufen
            var diaryEntry = infrastructure.GetDiaryEntries(date, date).FirstOrDefault();

            return diaryEntry;
        }

        public bool IsValidEntry(DiaryEntry entry)
        {
            //entry auf Anzahl Zeichen prüfen
            //Wenn 1000 überschritten werden, Fehler ausgeben
            return entry.EntryText.Length <= 1000 && entry.GetTags().Count <= 3;
        }

        public void SaveDiaryEntry(DiaryEntry entry)
        {
            //Methode IsValidEntry aufrufen
            DiaryBusiness boolean = new DiaryBusiness();

            bool result = boolean.IsValidEntry(entry); 

            


            //Methode SaveDiaryEntry  aus IInfrastructure ausführen
            if (result == false)
            {
                throw new Exception("Der Text hat mehr als 1000 Zeichen oder mehr als 3 Tags.");
            }

            infrastructure.SaveDiaryEntry(entry);

        }
    }
}
