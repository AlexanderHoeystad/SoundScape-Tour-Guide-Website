using SoundScape_Tour_Guide_Website.Models;
using SoundScape_Tour_Guide_Website.Pages.Account;

namespace SoundScape_Tour_Guide_Website.Catalogs
{
    public class SoundAdmin
    {
        private Dictionary<int, Sounds> sounds { get; }

        public SoundAdmin()
        {
            sounds = new Dictionary<int, Sounds>();
        }
        public Dictionary<int, Sounds?> AllCrendential()
        {
            return sounds;
        }

    }
}
