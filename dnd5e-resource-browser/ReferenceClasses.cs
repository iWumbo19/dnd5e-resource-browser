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
        //public string class;
        public string url;
    }

    public class MagicSchoolReference
    {
        public string index;
        public string name;
        public string desc;
        public string url;
    }

    public class SpellsReference
    {
        public int count;
        public APIReference[] results;
    }
}
