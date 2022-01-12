using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Proficiency
    {
        public string index;
        public string type;
        public string name;
        public Class[] classes;
        public Race[] races;
        public string url;
        public APIReference[] reference;
    }
}
