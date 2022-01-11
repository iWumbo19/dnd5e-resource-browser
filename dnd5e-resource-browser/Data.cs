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
        public static SpellsReference Spells;
        public static List<string> SpellList = new List<string>();
        public static List<string> Clear = new List<string>();
        public static MainWindow window;

        public static void UpdateSpells(SpellsReference spells)
        {
            Spells = spells;
            SpellList.Clear();
            foreach (APIReference item in spells.results)
            {
                SpellList.Add(item.name);
            }
        }

        public static string GetSpell(int index)
        {
            string url = Spells.results[index].url;
            string spellJSON = new WebClient().DownloadString($"https://www.dnd5eapi.co{url}");
            Spell spell = JsonConvert.DeserializeObject<Spell>(spellJSON);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {spell.name}");
            sb.AppendLine($"Level: {spell.level}");
            sb.AppendLine($"Concentration: {spell.concentration}");
            sb.AppendLine($"Range: {spell.range}");
            foreach (var item in spell.desc)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
