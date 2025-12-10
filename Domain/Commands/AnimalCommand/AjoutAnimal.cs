using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;

namespace Domain.Commands.AnimalCommand
{
    public class AjoutAnimal : ICommandDefinition
    {
        public AjoutAnimal(string nom, string espece, string age, bool sterilise, bool mF, bool primoVaccin, bool vaccinComplet, string provenance, string lieuProvenance, string localisation, string remarque, int secteurId, int faId)
        {
            Nom = nom;
            Espece = espece;
            Age = age;
            Sterilise = sterilise;
            MF = mF;
            PrimoVaccin = primoVaccin;
            VaccinComplet = vaccinComplet;
            Provenance = provenance;
            LieuProvenance = lieuProvenance;
            Localisation = localisation;
            Remarque = remarque;
            SecteurId = secteurId;
            FaId = faId;
        }

        public string Nom {  get; }
        public string Espece { get; }        
        public string Age { get; }
        public bool Sterilise { get; }
        public bool MF { get; }
        public bool PrimoVaccin{ get; }
        public bool VaccinComplet{ get; }
        public string Provenance {  get; }
        public string LieuProvenance{  get; }
        public string Localisation{  get; }
        public string Remarque { get; }
        public int SecteurId { get; }
        public int FaId { get; }
}
}
