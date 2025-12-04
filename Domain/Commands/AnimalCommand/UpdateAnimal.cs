using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;

namespace Domain.Commands.AnimalCommand
{
   public class UpdateAnimal : ICommandDefinition
    {
        public UpdateAnimal(string nom, string espece, string age, bool sterilise, bool mF, bool primoVaccine, bool vaccineComplet, string provenance, string lieuProvenance, string localisation, string remarque)
        {
            Nom = nom;
            Espece = espece;
            Age = age;
            Sterilise = sterilise;
            MF = mF;
            PrimoVaccine = primoVaccine;
            VaccineComplet = vaccineComplet;
            Provenance = provenance;
            LieuProvenance = lieuProvenance;
            Localisation = localisation;
            Remarque = remarque;
        }

        public string Nom { get; }
        public string Espece { get; }
        public string Age { get; }
        public bool Sterilise { get; }
        public bool MF { get; }
        public bool PrimoVaccine { get; }
        public bool VaccineComplet { get; }
        public string Provenance { get; }
        public string LieuProvenance { get; }
        public string Localisation { get; }
        public string Remarque { get; }
    }
}
