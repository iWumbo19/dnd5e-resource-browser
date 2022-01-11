using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public static class APIGet
    {
        private static string _base = "https://www.dnd5eapi.co/api";
        private static string _spells = "/spells";
    }

    enum BaseMod
    {
        Spells,
        Features,
        Races,
        Classes
    }
}
