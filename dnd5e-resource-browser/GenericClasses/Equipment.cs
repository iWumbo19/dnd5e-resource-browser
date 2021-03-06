using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Equipment
    {
        public string index;
        public string name;
        public APIReference equipment_category;
        public string weapon_category;
        public string weapon_range;
        public string category_range;
        public Cost cost;
        public WeaponDamage damage;
        public WeaponDamage two_handed_damage;
        public object range;
        public double weight;
        public APIReference[] properties;
        public string url;
    }
}
