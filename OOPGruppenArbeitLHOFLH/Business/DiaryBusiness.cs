using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGruppenArbeitLHOFLH
{

    public class DiaryBusiness : IBusiness
    {
        public List<string> GetAvailableTags()
        {
            


            throw new NotImplementedException();
        }

        public DiaryEntry GetDiaryEntry(DateTime date)
        {
            

            throw new NotImplementedException();
        }

        public bool IsValidEntry(DiaryEntry entry)
        {
            string dentry = entry.ToString();
 
            if(dentry.Length <= 1000)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public void SaveDiaryEntry(DiaryEntry entry)
        {
            if()
           

        }
    }
}
