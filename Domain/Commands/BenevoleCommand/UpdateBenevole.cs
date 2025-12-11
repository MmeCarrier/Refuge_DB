using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;

namespace Domain.Commands.BenevoleCommand
{
    public class UpdateBenevole : ICommandDefinition
    {
        public int BenevoleId { get; }
        public string Prenom { get; }
        public string? Nom { get; }
        public string Tel { get; }
        public string? Adresse { get; }
        public bool EstResponsable { get; }
        public bool FormeFerme { get; }
        public bool FormeReptile { get; }
        public bool FormeContrat { get; }
        public int SecteurId { get; }
        public int? FaId { get; }
    public UpdateBenevole(string prenom, string? nom, string tel, string? adresse, bool estResponsable, bool formeFerme, bool formeReptile, bool formeContrat, int secteurId, int? faId)
        {
            Prenom = prenom;
            Nom = nom;
            Tel = tel;
            Adresse = adresse;
            EstResponsable = estResponsable;
            FormeFerme = formeFerme;
            FormeReptile = formeReptile;
            FormeContrat = formeContrat;
            SecteurId = secteurId;
            FaId = faId;
        }
    }
}
