using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hello.Models;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;
using TuneIfEsport.Models;

namespace Hello.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the HelloUser class
    public class HelloUser : IdentityUser
    {
        [Key]
        public int UserId { get; set; }

    }
}
