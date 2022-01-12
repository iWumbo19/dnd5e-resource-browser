using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Trait
    {
        public string index;
        public APIReference[] races;
        public APIReference[] subraces;
        public string name;
        public string[] desc;
        public APIReference[] proficiencies;
        public Choice proficiency_choices;
        public string url;
    }
}
