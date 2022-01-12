using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class Feature
    {
        public string index;
        public string name;
        public int level;
        public APIReference _class;
        public APIReference subclass;
        public string[] desc;
        public string url;
    }
}
