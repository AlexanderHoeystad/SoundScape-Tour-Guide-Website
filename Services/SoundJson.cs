using SoundScape_Tour_Guide_Website.Helpers;
using SoundScape_Tour_Guide_Website.Interfaces;
using SoundScape_Tour_Guide_Website.Models;
using SoundScape_Tour_Guide_Website.Pages.Account;
using System.Reflection;
namespace SoundScape_Tour_Guide_Website.Services
{
    public class SoundJson :ISoundRepository
    {
        public Dictionary<int, Sounds> Sound { get; }
        string JsonFileName = @"C:\Users\beuge\source\repos\SoundScape-Tour-Guide-Website\Data\JsonSounds.json";

        //public SoundJson()
        //{
            
        //}
        public void AddSound(Sounds sound)
        {
            Dictionary<int, Sounds> sounds  = AllSounds();
            sounds.Add(sound.Id, sound);
            JsonFileWriter.WriteToJson(sounds,JsonFileName);
        }

        public Dictionary<int, Sounds> AllSounds()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }
        public Dictionary<int, Sounds> FilterSound(string criteria)
        {
            Dictionary<int, Sounds> sounds = AllSounds();
            Dictionary<int, Sounds> filteredSounds = new Dictionary<int, Sounds>();
            foreach (var s in sounds.Values)
            {
                if (s.Name.ToLower().StartsWith(criteria.ToLower()))
                {
                    filteredSounds.Add(s.Id, s);
                }
            }
            return filteredSounds;

        }
        public Sounds GetSound(int id)
        {
            Dictionary<int, Sounds> sounds = AllSounds();
            // not implemented yet;
            foreach (var s in sounds)
            {
                if (s.Key == id)
                    return s.Value;
            }
            return new Sounds();
        }
        public void UpdateSound(Sounds sound)
        {
            // not implemented yet
            foreach (var s in Sound.Values)
            {
                if (s.Id == sound.Id)
                {
                    s.Name = sound.Name;
                    s.SoundFileName = sound.SoundFileName;
                    s.SoundType = sound.SoundType;
                    s.Description = sound.Description;
                }
            }
        }

        public void DeleteSound(Sounds sound)
        {
            Dictionary<int, Sounds> sounds = AllSounds();
            // not implemented;
            sounds.Remove(sound.Id);
            /*foreach (var s in sounds.Values)
            {
                if (s.Id == sound.Id)
                {
                    Sound.Remove(s.Id);
                }
            }*/
            JsonFileWriter.WriteToJson(sounds, JsonFileName);
        }

    }
}
