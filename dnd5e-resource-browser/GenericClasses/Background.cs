using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Background
    {
        public string index;
        public string name;
        public APIReference[] starting_proficiencies;
        public Choice language_options;
        public APIReference[] starting_equipment;
        public Choice[] starting_equipment_options;
        public BackgroundFeature feature;
        public Choice personality_traits;
        public Choice bonds;
        public Choice flaws;
        public string url;
    }
}
