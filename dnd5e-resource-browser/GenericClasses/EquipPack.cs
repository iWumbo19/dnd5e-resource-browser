using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_resource_browser
{
    public class EquipPack
    {
        public string index;
        public string name;
        public APIReference equipment_category;
        public APIReference gear_category;
        public Cost cost;
        public string url;
    }
}
