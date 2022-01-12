using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Subclass
    {
        public string index;
        public APIReference _class;
        public string name;
        public string subclass_flavor;
        public string[] desc;
        public SubclassSpell[] spells;
        public string subclass_levels;
        public string url;
    }
}
