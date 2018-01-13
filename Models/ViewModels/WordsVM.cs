using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hebrew1.Models.ViewModels
{
    public class WordsVM
    {
        public WordsVM()
        {
        }

        public WordsVM(WordsDTO row)
        {
            HebrewWord = row.HebrewWord;
            Cuniform = row.Cuniform;
            CuniformImage = row.CuniformImage;
            Phonetic = row.Phonetic;
            Meaning = row.Meaning;
            RelatedWords = row.RelatedWords; 
        }
        
        public int Id { get; set; }
        [Required]
        public string HebrewWord { get; set; }
        public string Cuniform { get; set; }
        public string CuniformImage { get; set; }
        public string Phonetic { get; set; }
        [Required]
        public string Meaning { get; set; }
        public string RelatedWords { get; set; }
    }
}