using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoundScape_Tour_Guide_Website.Catalogs;
using SoundScape_Tour_Guide_Website.Models;
using Newtonsoft.Json;
using SoundScape_Tour_Guide_Website.Interfaces;

namespace SoundScape_Tour_Guide_Website.Pages
{
    public class GuideModel : PageModel
    {
        //private readonly ILogger<GuideModel> _logger;
        //public GuideModel(ILogger<GuideModel> logger)
        //{
        //    _logger = logger;
        //}
        //private ISoundRepository catalog;
        //public GuideModel(ISoundRepository repository)
        //{ 
        //    catalog = repository;
        //}
        private SoundAdmin catalog;
        public GuideModel() 
        {
            catalog = SoundAdmin.Instance;
        }
        public Dictionary<int, Sounds> Sound { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IActionResult OnGet()
        {
            Sound = catalog.AllSounds();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Sound = catalog.FilterSound(FilterCriteria);
            }
            return Page();
        }
    }
}