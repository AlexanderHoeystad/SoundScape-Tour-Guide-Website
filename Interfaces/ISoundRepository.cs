using SoundScape_Tour_Guide_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundScape_Tour_Guide_Website.Interfaces
{
    public interface ISoundRepository
    {
        public Dictionary<int, Sounds> AllSounds();
        public Dictionary<int, Sounds> FilterSound(string crtiteria);
        public void DeleteSound(Sounds sound);
        public void AddSound(Sounds sound);
        public void UpdateSound(Sounds sound);
        public Sounds GetSound(int id);
    }

}
