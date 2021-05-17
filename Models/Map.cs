using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Net.Http.Headers;

namespace TuneIfEsport.Models
{
    [Table("Maps")]

    public class Map
    {
        
        [Key]
        public int MapsId { get; set; }
        
        public string MapsName { get; set; }
        public Game Game { get; set; }
        public virtual ICollection<Score> Scores { get; set; }



    }
}