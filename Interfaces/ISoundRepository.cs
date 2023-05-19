using SoundScape_Tour_Guide_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundScape_Tour_Guide_Website.Interfaces
{
    public interface ISoundRepository
    {
        Dictionary<int, Sounds> AllSounds();
        Dictionary<int, Sounds> FilterSound(string crtiteria);
        void DeleteSound(Sounds sound);
        void AddSound(Sounds sound);
        void UpdateSound(Sounds sound);
        Sounds GetSound(int id);
    }

}
