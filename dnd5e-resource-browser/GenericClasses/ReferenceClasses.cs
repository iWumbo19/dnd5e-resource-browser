using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class APIReference
    {
        public string index;
        public string name;
        public string url;
    }

    public class ClassAPIReference
    {
        public string index;
        public string _class;
        public string url;
    }

    public class MagicSchoolReference
    {
        public string index;
        public string name;
        public string desc;
        public string url;
    }

    public class Prequisite
    {
        public string index;
        public string type;
        public string name;
        public string url;
    }

    public class SubclassSpell
    {
        public APIReference spell;
        public Prequisite[] prequisites;
    }

    public class AbilityBonus
    {
        public APIReference ability_score;
        public int bonus;
    }

    public class CategoryReference
    {
        public int count;
        public APIReference[] results;
    }

    public class Choice
    {
        public int choose;
        public string type;
        public APIReference[] from;
    }

    public class Cost
    {
        public int quantity;
        public string unit;
    }

    public class SpellCasting
    {
        public int level;
        public APIReference spellcasting_ability;
        public SpellCastingRef[] info;
    }

    public class SpellCastingRef
    {
        public string[] desc;
        public string name;
    }

    public class WeaponDamage
    {
        public string damage_dice;
        public APIReference damge_type;
    }

}
