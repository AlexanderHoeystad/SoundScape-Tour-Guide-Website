using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoundScape_Tour_Guide_Website.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }

        public void OnGet()
        {
        }
    }

    public class Credential
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }


}


