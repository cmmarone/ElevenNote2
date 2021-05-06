using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteOfCategory
    {
        public string Title { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
