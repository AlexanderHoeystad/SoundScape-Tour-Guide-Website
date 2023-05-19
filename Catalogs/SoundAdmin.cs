using SoundScape_Tour_Guide_Website.Interfaces;
using SoundScape_Tour_Guide_Website.Models;
using SoundScape_Tour_Guide_Website.Pages.Account;
using System.Reflection;

namespace SoundScape_Tour_Guide_Website.Catalogs
{
    public class SoundAdmin/*:ISoundRepository*/
    {
        private Dictionary<int, Sounds> Sound { get; }
        private static SoundAdmin _instance;

        private SoundAdmin()
        {
            Sound = new Dictionary<int, Sounds>();
            Sound.Add(1, new Sounds() { Id = 1, Name = "Jimi Hendrix", Description = "A solo from Jimi Hendrix", SoundFileName = "purplehaze.mp3", SoundType ="purplehaze.ogg" });
        }
        public static SoundAdmin Instance
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new SoundAdmin();
                }
                return _instance;
            } 
        }
        public Dictionary<int, Sounds> AllSounds()
        {
            return Sound;
        }
        public void AddSound(Sounds sound)
        {
            if (!(Sound.Keys.Contains(sound.Id)))
                Sound.Add(sound.Id, sound);
        }

        public Dictionary<int, Sounds> FilterSound(string criteria)
        {
            Dictionary<int, Sounds> mySounds = new Dictionary<int, Sounds>();
            if (criteria != null)
            {
                foreach (var p in Sound.Values)
                {
                    if (p.Name.StartsWith(criteria))
                    {
                        mySounds.Add(p.Id, p);
                    }
                }
            }
            return mySounds;
        }
        public Sounds GetSound(int id)
        {
            return Sound[id];
        }

        public void UpdateSound(Sounds sound)
        {
            if (sound != null)
            {
                Sound[sound.Id] = sound;
            }
        }

        public void DeleteSound(Sounds sound)
        {
            if (sound != null)
            {
                Sound.Remove(sound.Id);
            }
        }
    }
}
