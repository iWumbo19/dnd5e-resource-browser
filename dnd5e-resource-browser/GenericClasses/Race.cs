using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Race
    {
        public string index;
        public string name;
        public int speed;
        public AbilityBonus[] ability_bonuses;
        public string alignment;
        public string size;
        public string size_description;
        public APIReference[] starting_proficiencies;
        public Choice starting_proficiency_options;
        public APIReference[] languages;
        public string language_desc;
        public APIReference[] traits;
        public APIReference[] subraces;
        public string url;
    }
}
