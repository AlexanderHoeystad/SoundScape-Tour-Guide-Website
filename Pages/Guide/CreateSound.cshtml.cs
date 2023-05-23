using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoundScape_Tour_Guide_Website.Catalogs;
using SoundScape_Tour_Guide_Website.Interfaces;
using SoundScape_Tour_Guide_Website.Models;

namespace SoundScape_Tour_Guide_Website.Pages.Guide
{
    public class CreateSoundModel : PageModel
    {
        //private SoundAdmin catalog;
        [BindProperty]
        public Sounds Sound { get; set; }

        private ISoundRepository catalog;

        public CreateSoundModel(ISoundRepository repository)
        {
            catalog = repository;
        }
        //public CreateSoundModel() 
        //{
        //    catalog = SoundAdmin.Instance;
        //}
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            catalog.AddSound(Sound);

            return RedirectToPage("/Guide");
        }
    }
}
