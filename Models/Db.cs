using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hebrew1.Models
{
        public class Db : DbContext
        {
            public DbSet<WordsDTO> Words { get; set; }
            
        }
}