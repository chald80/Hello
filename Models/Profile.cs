using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hello.Areas.Identity.Data;
using Hello.Models;
using Microsoft.Net.Http.Headers;

namespace TuneIfEsport.Models
{
    [Table("Profile")]

    public class Profile
    {
        [Key]
        public int ProfileId {get; set; }
        public Info Info { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
        public HelloUser HelloUser { get; set; }
        public virtual ICollection<Game> Games { get; set; }










    }
}