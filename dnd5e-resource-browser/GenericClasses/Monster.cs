using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Monster
    {
        public string index;
        public string name;
        public string size;
        public string type;
        public string subtype;
        public string alignment;
        public int armor_class;
        public int hit_points;
        public string hit_dice;
        public APIReference forms;
        public object speed;
        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;
        public int wisdom;
        public int charisma;
        public Proficiency[] proficiencies;
        public APIReference[] damage_vulnerabilities;
        public APIReference[] damage_resistances;
        public APIReference[] damage_immunities;
        public APIReference[] condition_immunities;
        public object senses;
        public string languages;
        public int challenge_rating;
        public object[] speical_abilities;
        public object[] actions;
        public object[] legendary_actions;
        public string url;
    }
}
