using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeManagerShared.SharedEntities
{
    public class Fa
    {
        public Fa(int benevoleId, int animalId, DateTime dateDebut)
        {
            BenevoleId = benevoleId;
            AnimalId = animalId;
            DateDebut = dateDebut;
        }

        public int FaId { get; private set; }

        public int BenevoleId { get; private set; }
        public Benevole Benevole { get; private set; }

        public int AnimalId { get; private set; }
        public Animal Animal { get; private set; }
        public DateTime DateDebut { get; private set; }
        public DateTime? DateFin { get; private set; }

        public void Cloturer(DateTime dateFin)
        { 
            DateFin = dateFin; 
        }
    }

}
