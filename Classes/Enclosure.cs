using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Enclosure
    {
        public int Building_Id { get; set; }
        //PK
        public string Building_Name { get; set; }
        public string Zoo_Name { get; set; }
        //FK
    }
}
