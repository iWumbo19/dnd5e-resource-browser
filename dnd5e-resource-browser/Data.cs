using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace dnd5e_resource_browser
{
    public static class Data
    {
        public static MainWindow mainWindow;
        public delegate void Start();

        public static List<string> SpellNameList = new List<string>();
        public static List<Spell> SpellObjList = new List<Spell>();

        public static List<string> ClassNameList = new List<string>();
        public static List<Class> ClassObjList = new List<Class>();

        public static List<string> RaceNameList = new List<string>();
        public static List<Race> RaceObjList = new List<Race>();

        public static List<string> MonsterNameList = new List<string>();
        public static List<Monster> MonsterObjList = new List<Monster>();

        public static List<string> EquipmentNameList = new List<string>();
        public static List<Equipment> EquipmentObjList = new List<Equipment>();

        public static List<string> MagicItemNameList = new List<string>();
        public static List<MagicItem> MagicItemObjList = new List<MagicItem>();

        public static bool PullJSON()
        {
            InitializeSpells();
            InitializeClasses();
            InitializeRaces();
            InitializeMonsters();
            InitializeEquipment();
            InitializeMagicItem();

            return true;
        }

        
        #region INITIALIZE METHODS
        public static void InitializeSpells()
        {
            string collectionJSON = new WebClient().DownloadString("https://www.dnd5eapi.co/api/spells/");
            CategoryReference spellReference = JsonConvert.DeserializeObject<CategoryReference>(collectionJSON);
            foreach (APIReference item in spellReference.results)
            {
                SpellNameList.Add(item.name);
                string spellJSON = new WebClient().DownloadString("https://www.dnd5eapi.co" + item.url);
                SpellObjList.Add(JsonConvert.DeserializeObject<Spell>(spellJSON));
            }
        }

        public static void InitializeClasses()
        {
            string collectionJSON = new WebClient().DownloadString("https://www.dnd5eapi.co/api/classes/");
            CategoryReference classReference = JsonConvert.DeserializeObject<CategoryReference>(collectionJSON);
            
            foreach (APIReference item in classReference.results)
            {
                ClassNameList.Add(item.name);
                string classJSON = new WebClient().DownloadString("https://www.dnd5eapi.co" + item.url);
                ClassObjList.Add(JsonConvert.DeserializeObject<Class>(classJSON));
            }
        }

        public static void InitializeRaces()
        {
            string collectionJSON = new WebClient().DownloadString("https://www.dnd5eapi.co/api/races/");
            CategoryReference raceReference = JsonConvert.DeserializeObject<CategoryReference>(collectionJSON);
            foreach (APIReference item in raceReference.results)
            {
                RaceNameList.Add(item.name);
                string raceJSON = new WebClient().DownloadString("https://www.dnd5eapi.co" + item.url);
                RaceObjList.Add(JsonConvert.DeserializeObject<Race>(raceJSON));
            }
        }

        public static void InitializeMonsters()
        {
            string collectionJSON = new WebClient().DownloadString("https://www.dnd5eapi.co/api/monsters/");
            CategoryReference monsterReference = JsonConvert.DeserializeObject<CategoryReference>(collectionJSON);
            foreach (APIReference item in monsterReference.results)
            {
                MonsterNameList.Add(item.name);
                string monsterJSON = new WebClient().DownloadString("https://www.dnd5eapi.co" + item.url);
                MonsterObjList.Add(JsonConvert.DeserializeObject<Monster>(monsterJSON));
            }
        }

        public static void InitializeEquipment()
        {
            string collectionJSON = new WebClient().DownloadString("https://www.dnd5eapi.co/api/equipment/");
            CategoryReference equipmentReference = JsonConvert.DeserializeObject<CategoryReference>(collectionJSON);
            foreach (APIReference item in equipmentReference.results)
            {
                EquipmentNameList.Add(item.name);
                string equipmentJSON = new WebClient().DownloadString("https://www.dnd5eapi.co" + item.url);
                EquipmentObjList.Add(JsonConvert.DeserializeObject<Equipment>(equipmentJSON));
            }
        }

        public static void InitializeMagicItem()
        {
            string collectionJSON = new WebClient().DownloadString("https://www.dnd5eapi.co/api/magic-items/");
            CategoryReference magicitemReference = JsonConvert.DeserializeObject<CategoryReference>(collectionJSON);
            foreach (APIReference item in magicitemReference.results)
            {
                MagicItemNameList.Add(item.name);
                string magicitemJSON = new WebClient().DownloadString("https://www.dnd5eapi.co" + item.url);
                MagicItemObjList.Add(JsonConvert.DeserializeObject<MagicItem>(magicitemJSON));
            }
        }

        #endregion


        public static string SpellInfo(int index)
        {
            StringBuilder sb = new StringBuilder();
            Spell spell = SpellObjList[index];
            sb.AppendLine($"Name: {spell.name}");
            sb.AppendLine($"Level: {spell.level}");
            sb.Append($"Components: ");
            foreach (var item in spell.components)
            {
                sb.Append($"{item} ");
            }
            sb.AppendLine();
            sb.AppendLine($"Ritual: {spell.ritual}");
            foreach (var item in spell.desc)
            {
                sb.AppendLine(item);
            }
            return sb.ToString();
        }

        public static string ClassInfo(int index)
        {
            StringBuilder sb = new StringBuilder();
            Class _class = ClassObjList[index];
            sb.AppendLine($"Name: {_class.name}");
            sb.AppendLine($"Hit Die: 1d{_class.hit_die}");
            foreach (Choice choice in _class.proficiency_choices)
            {
                sb.AppendLine($"{choice.type}: ");
                foreach (APIReference reference in choice.from)
                {
                    sb.AppendLine($"    {reference.name}");
                }
            }
            sb.AppendLine($"Proficiencies: ");
            foreach (var item in _class.proficiencies)
            {
                sb.AppendLine($"    {item.name}");
            }
            sb.AppendLine($"Saving Throws:");
            foreach (var item in _class.saving_throws)
            {
                sb.AppendLine($"    {item.name}");
            }
            sb.AppendLine($"Subclasses: ");
            foreach (var item in _class.subclasses)
            {
                sb.AppendLine($"    {item.name}");
            }
            if (_class.spellcasting != null)
            {
                foreach (SpellCastingRef spellinfo in _class.spellcasting.info)
                {
                    sb.AppendLine();
                    sb.AppendLine($"{spellinfo.name}");
                    foreach (string descLine in spellinfo.desc)
                    {
                        sb.AppendLine($"    {descLine}");
                    }
                } 
            }


            return sb.ToString();
            
        }

        public static string RaceInfo(int index)
        {
            StringBuilder sb = new StringBuilder();
            Race race = RaceObjList[index];
            sb.AppendLine($"Name: {race.name}");
            sb.AppendLine($"Speed: {race.speed}");
            sb.AppendLine($"Bonuses:");
            foreach (var item in race.ability_bonuses)
            {
                sb.AppendLine($"    {item.ability_score.name} +{item.bonus}");
            }
            sb.AppendLine($"Alignment: {race.alignment}");
            sb.AppendLine($"Size: {race.size}");
            sb.AppendLine($"Starting Proficiencies:");
            foreach (var item in race.starting_proficiencies)
            {
                sb.AppendLine($"    {item.name}");
            }
            sb.AppendLine($"Languages:");
            foreach (var item in race.languages)
            {
                sb.AppendLine($"    {item.name}");
            }
            sb.AppendLine($"Traits:");
            foreach (var item in race.traits)
            {
                sb.AppendLine($"    {item.name}");
            }
            sb.AppendLine($"Subraces:");
            foreach (var item in race.subraces)
            {
                sb.AppendLine($"    {item.name}");
            }
            return sb.ToString();
        }

        public static string MonsterInfo(int index)
        {
            StringBuilder sb = new StringBuilder();
            Monster monster = MonsterObjList[index];

            sb.AppendLine($"Name: {monster.name}");
            sb.AppendLine($"Size: {monster.size}");
            sb.AppendLine($"Type: {monster.type}");
            sb.AppendLine($"Challenge Rating: {monster.challenge_rating}");
            sb.AppendLine($"SubType: {monster.subtype}");
            sb.AppendLine($"Alingment: {monster.alignment}");
            sb.AppendLine($"Armor Class: {monster.armor_class}");
            sb.AppendLine($"Hit Points: {monster.hit_points}");
            sb.AppendLine($"Hit Dice: {monster.hit_dice}");
            sb.AppendLine($"Speed: {monster.speed}");
            sb.AppendLine($"Scores:");
            sb.Append($"STR {monster.strength}");
            sb.Append($"  DEX {monster.dexterity}");
            sb.Append($"  CON {monster.constitution}");
            sb.Append($"  INT {monster.intelligence}");
            sb.Append($"  WIS {monster.wisdom}");
            sb.AppendLine($"  CHA {monster.charisma}");
            sb.AppendLine($"Vulnerabilities:");
            foreach (var item in monster.damage_vulnerabilities)
            {
                sb.AppendLine($"    {item}");
            }
            sb.AppendLine($"Resistances:");
            foreach (var item in monster.damage_resistances)
            {
                sb.AppendLine($"    {item}");
            }
            sb.AppendLine($"Immunities:");
            foreach (var item in monster.damage_immunities)
            {
                sb.AppendLine($"    {item}");
            }
            sb.AppendLine("Condition Immunities:");
            foreach (var item in monster.condition_immunities)
            {
                sb.AppendLine($"    {item}");
            }
            sb.AppendLine($"Languages: {monster.languages}");

            return sb.ToString();
        }

        public static string EquipmentInfo(int index)
        {
            StringBuilder sb = new StringBuilder();
            Equipment equip = EquipmentObjList[index];

            sb.AppendLine($"Name: {equip.name}");
            sb.AppendLine($"Equipment Category: {equip.equipment_category.name}");
            if (equip.weapon_category != null) { sb.AppendLine($"Weapon Category: {equip.weapon_category}"); }
            if (equip.weapon_range != null) { sb.AppendLine($"Weapon Range: {equip.weapon_range}"); }
            if (equip.category_range != null) { sb.AppendLine($"Category Range: {equip.category_range}"); }
            if (equip.cost != null) { sb.AppendLine($"Cost: {equip.cost.quantity}{equip.cost.unit}"); }
            if (equip.damage != null) { sb.AppendLine($"Damage: {equip.damage.damage_dice} {equip.damage.damge_type}"); }
            if (equip.two_handed_damage != null) { sb.AppendLine($"Two Handed Damage: {equip.two_handed_damage.damage_dice} {equip.two_handed_damage.damge_type}"); }
            if (equip.range != null) { sb.AppendLine($"Range: {equip.range}"); }
            sb.AppendLine($"Weight: {equip.weight}");
            if (equip.properties != null) { sb.AppendLine("Properties:"); }
            if (equip.properties != null)
            {
                foreach (var item in equip.properties)
                {
                    sb.AppendLine($"    {item.name}");
                } 
            }

            return sb.ToString();
        }

        public static string MagicItemInfo(int index)
        {
            StringBuilder sb = new StringBuilder();
            MagicItem item = MagicItemObjList[index];

            sb.AppendLine($"Name: {item.name}");
            sb.AppendLine($"Equipment Category: {item.equipment_category.name}");
            sb.Append("Description: ");
            foreach (var descLine in item.desc)
            {
                sb.AppendLine($"{descLine}");
            }

            return sb.ToString();
        }

        
    }
}
