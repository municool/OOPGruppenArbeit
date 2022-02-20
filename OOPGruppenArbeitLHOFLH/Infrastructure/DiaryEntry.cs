using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGruppenArbeitLHOFLH
{
    public class DiaryEntry
    {
        public DiaryEntry()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public DateTime DateTime { get; set; }
        public List<string> Tags { get; set; }
        public string EntryText { get; set; }
        public string PicturePath { get; set; }
    }
}
