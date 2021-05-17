using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.MemoryMappedFiles;

namespace TuneIfEsport.Models
{
    [Table("Games")]

    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string GameName { get; set; }
        public virtual ICollection<Map> Maps { get; set; }
        public virtual ICollection<Score> Scores { get; set; }

        public Profile Profile { get; set; }








    }
}