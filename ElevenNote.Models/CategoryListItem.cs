using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryListItem
    {
        [Display(Name="Category ID")]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        [Display(Name="Number of Notes")]
        public int NumberOfNotes { get; set; }
    }
}
