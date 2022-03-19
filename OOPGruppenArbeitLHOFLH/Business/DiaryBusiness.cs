using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using OOPGruppenArbeitLHOFLH.Infrastructure;

namespace OOPGruppenArbeitLHOFLH
{

    public class DiaryBusiness : IBusiness
    {
        IInfrastructure infrastructure = new DiaryInfrastructure();

        public List<string> GetAvailableTags()
        {
            var tagList = infrastructure.GetTags();

            return tagList;
        }

        public DiaryEntry GetDiaryEntry(DateTime date)
        {
            var diaryEntry = infrastructure.GetDiaryEntries(date, date).FirstOrDefault();

            return diaryEntry;
        }

        public bool IsValidEntry(DiaryEntry entry)
        {
            return entry.EntryText.Length <= 1000 && entry.GetTags().Count <= 3;
        }

        public void SaveDiaryEntry(DiaryEntry entry)
        {
            DiaryBusiness boolean = new DiaryBusiness();

            bool result = boolean.IsValidEntry(entry); 

            if (result == false)
            {
                throw new Exception("Der Text hat mehr als 1000 Zeichen oder mehr als 3 Tags.");
            }

            infrastructure.SaveDiaryEntry(entry);
        }

        public bool Login(string username, string password) //Methodenname Inhalt muss abgestimmt werden
        {
            string hashString = getHashSha256(password);

            User user = infrastructure.GetUser(username);

            return user != null && user.Password == hashString;
        }

        private string getHashSha256(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        public Dictionary<string, DateTime> GetEntriesForTag(string tag)
        {
            var dict = new Dictionary<string, DateTime>();

            infrastructure.GetEntriesByTag(tag).ForEach(e => dict.Add(e.Id.ToString(), e.DateTime));

            return dict;
        }
    }
}
