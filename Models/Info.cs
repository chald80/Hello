using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.MemoryMappedFiles;
using TuneIfEsport.Models;

namespace Hello.Models
{
    [Table("Info")]

    public class Info
    {
        [Key] 
        public int InfoId { get; set; }

        public string InfoName { get; set; }
        public int ProfileId { get; set; }


    }
}
