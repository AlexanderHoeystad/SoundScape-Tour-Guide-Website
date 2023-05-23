using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoundScape_Tour_Guide_Website.Catalogs;
using SoundScape_Tour_Guide_Website.Interfaces;
using SoundScape_Tour_Guide_Website.Models;

namespace SoundScape_Tour_Guide_Website.Pages.Guide
{
    public class EditSoundModel : PageModel
    {
        //private SoundAdmin catalog;

        [BindProperty]
        public Sounds Sound { get; set; }
        //Brug mig for interface!!
        private ISoundRepository catalog;
        public EditSoundModel(ISoundRepository repository)
        {
            catalog = repository;
        }

        // fjern mig for at bruge interfaces!!
        //public EditSoundModel()
        //{
        //    catalog = SoundAdmin.Instance;
        //}
        //------------------------------------
        public void OnGet(int id)
        {
            Sound = catalog.GetSound(id);
        }

        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.UpdateSound(Sound);
            return RedirectToPage("/Guide");
        }

    }
}
