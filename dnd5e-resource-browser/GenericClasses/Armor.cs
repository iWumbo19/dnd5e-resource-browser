using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Armor
    {
        public string index;
        public string name;
        public APIReference equipment_category;
        public string armor_category;
        public object armor_class;
        public int str_minimum;
        public bool stealth_disadvantage;
        public int weight;
        public Cost cost;
        public string url;
    }
}
