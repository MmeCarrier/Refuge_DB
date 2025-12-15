using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeManagerShared.SharedEntities
{
    public class Benevole
    {
        public Benevole(string prenom, string? nom, string tel, string? adresse, bool estResponsable, bool formeFerme, bool formeReptile, bool formeContrat, int? secteurId)//, int? faId)
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
           // FaId = faId;
        }

        public int BenevoleId { get; private set; }
        public string Prenom { get; set;}
        public string? Nom { get; set; }
        public string Tel { get; set; }
        public string? Adresse { get; set; }
        public bool EstResponsable { get; set; }
        public bool FormeFerme { get; set; }
        public bool FormeReptile { get; set; }
        public bool FormeContrat { get; set; }
        
        public int? SecteurId { get; set; }
        public Secteur? Secteur { get; set; }

       // public int? FaId { get; set; }
       // public Fa? Fa { get; set; }
        public ICollection<Fa> Fas { get; set; } = new List<Fa>();

    }
}
