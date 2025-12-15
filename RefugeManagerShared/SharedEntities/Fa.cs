using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeManagerShared.SharedEntities
{
    public class Fa
    {
        public Fa(int? benevoleId, int? animalId)
        {
            BenevoleId = benevoleId;
            AnimalId = animalId;
        }

        public int FaId { get; private set; }

        public int? BenevoleId { get; set; }
        public Benevole? Benevole { get; set; }

        public int? AnimalId { get; set; }
        public Animal? Animal { get; set; }
    }

}
