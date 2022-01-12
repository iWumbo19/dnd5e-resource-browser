using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace dnd5e_resource_browser
{
    public static class APIGet
    {
        private static string _base = "https://www.dnd5eapi.co/api";
        private static string _ability_scores = "/ability-scores";
        private static string _alignments = "/alignments";
        private static string _backgrounds = "/backgrounds";
        private static string _classes = "/classes";
        private static string _conditions = "/conditions";
        private static string _damage_types = "/damage-types";
        private static string _equipment_cat = "/equipment-categories";
        private static string _equipment = "/equipment";
        private static string _feats = "/feats";
        private static string _features = "/features";
        private static string _languages = "/languages";
        private static string _magic_items = "/magic-items";
        private static string _magic_schools = "/magic-schools";
        private static string _monsters = "/monsters";
        private static string _proficiencies = "/proficiencies";
        private static string _races = "/races";
        private static string _rules = "/rules";
        private static string _rule_sections = "/rule-sections";
        private static string _skills = "/skills";
        private static string _spells = "/spells";
        private static string _subclasses = "/subclasses";
        private static string _subraces = "/subraces";
        private static string _traits = "/traits";
        private static string _weapon_properties = "/weapon-properties";

        
    }

    public enum APIParam
    {
        AbilityScores,
        Alignments,
        Backgrounds,
        Classes,
        Conditions,
        DamageTypes,
        EquipmentCat,
        Equipment,
        Feats,
        Features,
        Languages,
        MagicItems,
        MagicSchools,
        Monsters,
        Proficiencies,
        Races,
        Rules,
        RuleSections,
        Skills,
        Spells,
        Subclasses,
        Subraces,
        Traits,
        WeaponProperties
    }
}
