using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Weapon
    {
        public string index;
        public string name;
        public APIReference equipment_category;
        public string weapon_category;
        public string weapon_range;
        public string category_range;
        public Cost cost;
        public object damage;
        public object two_handed_damge;
        public object range;
        public int weight;
        public APIReference[] properties;
        public string url;
    }
}
