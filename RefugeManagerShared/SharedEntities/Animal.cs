using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeManagerShared.SharedEntities
{
    public class Animal
    {
        public int AnimalId {  get; private set; }
        public string? Nom { get; set; }
        public string Espece { get; set; }
        public string? Age { get; set; }
        public bool? MF { get; set; }
        public bool Sterilise { set; get; }
        public bool? PrimoVaccin { get; set; }
        public bool? Vaccincomplet { get; set; }
        public string Provenance { get; set; }
        public string LieuProvenance { get; set; }
        public string Localisation { get; set; }
        public string? Remarque { get; set; } = null;
        public Animal(string? nom, string espece, string? age, bool? mF, bool sterilise, bool? primoVaccin, bool? vaccincomplet, string provenance, string lieuProvenance, string localisation, string? remarque)
        {            ;
            Nom = nom;
            Espece = espece;
            Age = age;
            MF = mF;
            Sterilise = sterilise;
            PrimoVaccin = primoVaccin;
            Vaccincomplet = vaccincomplet;
            Provenance = provenance;
            LieuProvenance = lieuProvenance;
            Localisation = localisation;
            Remarque = remarque;
        }


    }
}
