using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Class
    {
        public string index;
        public string name;
        public int hit_die;
        public Choice[] proficiency_choices;
        public APIReference[] proficiencies;
        public APIReference[] saving_throws;
        public object starting_equipment;
        public string class_levels;
        public object multi_classing;
        public APIReference[] subclasses;
        public object spellcasting;
        public string spells;
        public string url;
    }
}
