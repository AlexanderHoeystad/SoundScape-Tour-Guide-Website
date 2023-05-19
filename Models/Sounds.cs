using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoundScape_Tour_Guide_Website.Models
{
    public class Sounds
    {
        public int Id { get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "Name of the SoundFile can not be longer than 18 chars")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string SoundFileName { get; set; }
        public string SoundType { get; set; }
    }
}
