using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TuneIfEsport.Models
{
    [Table("Score")]
        public class Score
        {
            [Key]
            public int ScoreId{ get; set; }

            public int score { get; set; }

            public Profile Profile { get; set; }
            public Game Game { get; set; }
            public Map Map { get; set; }





    }
}
