using OOPGruppenArbeitLHOFLH.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGruppenArbeitLHOFLH
{
    public interface IInfrastructure
    {
        /// <summary>
        /// Save a entry to the db
        /// </summary>
        /// <param name="entry">entry to be saved</param>
        void SaveDiaryEntry(DiaryEntry entry);
        
        /// <summary>
        /// Get specified diary entry
        /// </summary>
        /// <param name="key">entry id</param>
        /// <returns></returns>
        DiaryEntry GetDiaryEntry(string key);

        /// <summary>
        /// Get all diary entries 
        /// </summary>
        /// <param name="start">limits the start of the search</param>
        /// <param name="end">limits the end of the search</param>
        /// <returns></returns>
        List<DiaryEntry> GetDiaryEntries(DateTime? start = null, DateTime? end = null);

        /// <summary>
        /// Get already used tags
        /// </summary>
        /// <returns></returns>
        List<string> GetTags();

        /// <summary>
        /// Get user with the given name
        /// </summary>
        /// <param name="username">name of the user</param>
        /// <returns></returns>
        User GetUser(string username);

        /// <summary>
        /// Get list of all entries with the given tag
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        List<DiaryEntry> GetEntriesByTag(string tag);
    }
}
