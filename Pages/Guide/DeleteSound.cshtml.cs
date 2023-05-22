using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoundScape_Tour_Guide_Website.Catalogs;
using SoundScape_Tour_Guide_Website.Interfaces;
using SoundScape_Tour_Guide_Website.Models;

namespace SoundScape_Tour_Guide_Website.Pages.Guide
{
    public class DeleteSoundModel : PageModel
    {
        private SoundAdmin catalog;
        [BindProperty]
        public Sounds Sound { get; set; }
        //brug mig for interface!!
        //private ISoundRepository catalog;
        //public DeleteSoundModel(ISoundRepository repository)
        //{
        //    catalog = repository;
        //}

        //fjern mig for implenmatation af interface
        public DeleteSoundModel()
        {
            catalog = SoundAdmin.Instance;
        }
        //-----------------------------------------
        public IActionResult OnGet(int id)
        {
            Sound = catalog.GetSound(id);
            return Page();
        }
        public IActionResult OnPost()
        {
            catalog.DeleteSound(Sound);
            return RedirectToPage("/Guide");
        }
    }
}
