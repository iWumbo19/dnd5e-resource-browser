using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Subrace
    {
        public string index;
        public string name;
        public APIReference race;
        public string desc;
        public AbilityBonus[] ability_bonuses;
        public APIReference[] starting_proficiencies;
        public APIReference[] languages;
        public Choice language_options;
        public APIReference[] racial_traits;
        public string url;
    }
}
