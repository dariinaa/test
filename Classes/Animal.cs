using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Animal
    {
        public int Animal_Id { get; set; }
        //PK
        public string Animal_Name { get; set; }
        public string Animal_Type { get; set; }
        public string Animal_Gender { get; set; }
        public int Building_Id { get; set; }
        //FK
        public int Diet_Id { get; set; }
        //FK
    }
}
