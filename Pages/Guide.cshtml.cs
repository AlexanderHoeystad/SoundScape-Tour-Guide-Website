using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoundScape_Tour_Guide_Website.Catalogs;
using SoundScape_Tour_Guide_Website.Models;

namespace SoundScape_Tour_Guide_Website.Pages
{
    public class GuideModel : PageModel
    {
        private readonly ILogger<GuideModel> _logger;

        private SoundAdmin soundAdmin;

        //public GuideModel(ILogger<GuideModel> logger)
        //{
        //    _logger = logger;
        //}
        public GuideModel()
        { 
            soundAdmin = new SoundAdmin();
        }
        public Dictionary<int, Sounds> sounds { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}