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

        public static bool PullJSON()
        {
            InitializeSpells();
            InitializeClasses();
            InitializeRaces();
            InitializeMonsters();

            return true;
        }

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
            string collectionJSON = new WebClient().DownloadString("https://www.dnd5eapi.co/api/races/");
            CategoryReference monsterReference = JsonConvert.DeserializeObject<CategoryReference>(collectionJSON);
            foreach (APIReference item in monsterReference.results)
            {
                MonsterNameList.Add(item.name);
                string monsterJSON = new WebClient().DownloadString("https://www.dnd5eapi.co" + item.url);
                MonsterObjList.Add(JsonConvert.DeserializeObject<Monster>(monsterJSON));
            }
        }


    }
}
