using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hebrew1.Models
{
    [Table("Words")]
    public class WordsDTO
    {
        [Key]
        public int Id { get; set; }
        public string HebrewWord { get; set; }
        public string Cuniform { get; set; }
        public string CuniformImage { get; set; }
        public string Phonetic { get; set; }
        public string Meaning { get; set; }
        public string RelatedWords { get; set; }
    }
}