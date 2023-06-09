using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
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

        public async Task<IActionResult> OnPostAsync() 
        {
            if (!ModelState.IsValid) return Page();

            // Verify the credential
            if (Credential.Username == "admin" && Credential.Password == "password")

            {
                // Creating the security context 
                var claims = new List<Claim> {

                new Claim(ClaimTypes.Name, "admin"),
                new Claim(ClaimTypes.Email, "admin@mywebsite.com")
                
                
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");
            }

            return Page();
        }

    }

    public class Credential
    {
        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }




}


