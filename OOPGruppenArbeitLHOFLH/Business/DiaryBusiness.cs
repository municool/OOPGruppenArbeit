using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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

        private bool IsValidEntry(DiaryEntry entry)
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



        public void Login(string username, string password) //Methodenname Inhalt muss abgestimmt werden
        {
            //Passwort verschlüsseln
            string hashString = getHashSha256(password);

            if(username == null && hashString == null)
            {
                //Methode zum aufrufen des Form
            }
            else
            {
                return "Your Login is not valid";
            }

          
        }
        public static string getHashSha256(string password)
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

        */
    }
}
