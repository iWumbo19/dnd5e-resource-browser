using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Spell
    {
        public string index;
        public string name;
        public string[] desc;
        public string[] higher_level;
        public string range;
        public string[] components;
        public string material;
        public bool ritual;
        public string duration;
        public bool concentration;
        public string casting_time;
        public int level;
        public string attack_type;
        public object damage;
        public APIReference school;
        public APIReference[] classes;
        public APIReference[] subclasses;
        public string url;
    }

    
}
