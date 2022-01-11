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

        public static string Full(APIParam param)
        {
            try
            {
                switch (param)
                {
                    case APIParam.AbilityScores:
                        return new WebClient().DownloadString(_base + _ability_scores);
                    case APIParam.Alignments:
                        return new WebClient().DownloadString(_base + _alignments);
                    case APIParam.Backgrounds:
                        return new WebClient().DownloadString(_base + _backgrounds);
                    case APIParam.Classes:
                        return new WebClient().DownloadString(_base + _classes);
                    case APIParam.Conditions:
                        return new WebClient().DownloadString(_base + _conditions);
                    case APIParam.DamageTypes:
                        return new WebClient().DownloadString(_base + _damage_types);
                    case APIParam.EquipmentCat:
                        return new WebClient().DownloadString(_base + _equipment_cat);
                    case APIParam.Equipment:
                        return new WebClient().DownloadString(_base + _equipment);
                    case APIParam.Feats:
                        return new WebClient().DownloadString(_base + _feats);
                    case APIParam.Features:
                        return new WebClient().DownloadString(_base + _features);
                    case APIParam.Languages:
                        return new WebClient().DownloadString(_base + _languages);
                    case APIParam.MagicItems:
                        return new WebClient().DownloadString(_base + _magic_items);
                    case APIParam.MagicSchools:
                        return new WebClient().DownloadString(_base + _magic_schools);
                    case APIParam.Monsters:
                        return new WebClient().DownloadString(_base + _monsters);
                    case APIParam.Proficiencies:
                        return new WebClient().DownloadString(_base + _proficiencies);
                    case APIParam.Races:
                        return new WebClient().DownloadString(_base + _races);
                    case APIParam.Rules:
                        return new WebClient().DownloadString(_base + _rules);
                    case APIParam.RuleSections:
                        return new WebClient().DownloadString(_base + _rule_sections);
                    case APIParam.Skills:
                        return new WebClient().DownloadString(_base + _skills);
                    case APIParam.Spells:
                        return new WebClient().DownloadString(_base + _spells);
                    case APIParam.Subclasses:
                        return new WebClient().DownloadString(_base + _subclasses);
                    case APIParam.Subraces:
                        return new WebClient().DownloadString(_base + _subraces);
                    case APIParam.Traits:
                        return new WebClient().DownloadString(_base + _traits);
                    case APIParam.WeaponProperties:
                        return new WebClient().DownloadString(_base + _weapon_properties);
                    default:
                        return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
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
