using SoundScape_Tour_Guide_Website.Interfaces;
using SoundScape_Tour_Guide_Website.Models;
using SoundScape_Tour_Guide_Website.Pages.Account;
using System.Reflection;

namespace SoundScape_Tour_Guide_Website.Catalogs
{
    public class SoundAdmin : ISoundRepository
    {
        private Dictionary<int, Sounds> Sound { get; }
        private static SoundAdmin _instance;

        public SoundAdmin()
        {
            Sound = new Dictionary<int, Sounds>();
            Sound.Add(1, new Sounds() { Id = 1, Name = "Jimi Hendrix", Description = "A song from Jimi Hendrix", SoundFileName = "purplehaze.mp3", SoundType = "purplehaze.ogg" });
            Sound.Add(2, new Sounds() { Id = 2, Name = "Hella", Description = "A track by Sacramento rock band Hella", SoundFileName = "biblicalviolence.mp3", SoundType = "biblicalbviolence.ogg" });
            Sound.Add(3, new Sounds() { Id = 3, Name = "Black Country, New Road", Description = "Introductory track to the band's second album", SoundFileName = "spacemarine.mp3", SoundType = "spacemarine.ogg" });
            Sound.Add(4, new Sounds() { Id = 4, Name = "Black Midi", Description = "A song from their newest record, Cavalcade", SoundFileName = "welcometohell.mp3", SoundType = "welcometohell.mp3" });
            Sound.Add(5, new Sounds() { Id = 5, Name = "Boris", Description = "The most popular song from Japanese experimental band, Boris", SoundFileName = "farewell.mp3", SoundType = "farewell.ogg" });
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
        //public void UpdateSound2(Sounds sound)
        //{
        //    foreach (var p in Sound.Values)
        //    {
        //        if (p.Id == sound.Id)
        //        {
        //            p.Name = sound.Name;
        //            p.SoundFileName = sound.SoundFileName;
        //            p.Description = sound.Description;
        //        }
        //    }
        //}

        public void DeleteSound(Sounds sound)
        {
            if (sound != null)
            {
                Sound.Remove(sound.Id);
            }
        }
    }
}
