using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;

namespace Domain.Commands.BenevoleCommande
{
    public class AjoutBenevole : ICommandDefinition // Il faut créer le Tools pour faire ça
    {
        public AjoutBenevole(string prenom, string? nom, string tel, string? adresse, bool estResponsable, bool formeFerme, bool formeReptile, bool formeContrat, int? secteurId, int? faId)
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

        public string Prenom { get; }
        public string? Nom { get; }
        public string Tel { get; }
        public string? Adresse { get; }
        public bool EstResponsable { get; } = false;
        public bool FormeFerme { get; } = false;
        public bool FormeReptile { get; } = false;
        public bool FormeContrat { get; } = false;
        public int? SecteurId { get; }
        public int? FaId { get; }
    }
}
