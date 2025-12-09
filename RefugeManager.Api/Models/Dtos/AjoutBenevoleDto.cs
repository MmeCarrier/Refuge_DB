using System.ComponentModel.DataAnnotations;

namespace RefugeManager.Api.Models.Dtos
{
    public class AjoutBenevoleDto
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Prenom { get; set; } = "anonyme";
        public string? Nom { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 10)]
        public string Tel { get; set; } = "0123456789";
        public string? Adresse { get; set; }
        [Required]
        public bool EstResponsable { get; set; } = false;
        [Required]
        public bool FormeFerme { get; set; } = false;
        [Required]
        public bool FormeReptile { get; set; } = false;
        [Required]
        public bool FormeContrat { get; set; } = false;
        public int? SecteurId { get; set; }
        public int? FaId { get; set; }

        //public AjoutBenevoleDto(string prenom, string nom, string tel, string adresse, bool estResponsable, bool formeFerme, bool formeReptile, bool formeContrat, int? secteurId, int? faId) 
        //{
        //    Prenom = prenom;
        //    Nom = nom;
        //    Tel = tel;
        //    Adresse = adresse;
        //    EstResponsable = estResponsable;
        //    FormeFerme = formeFerme;
        //    FormeReptile = formeReptile;
        //    FormeContrat= formeContrat;
        //    SecteurId = secteurId;
        //    FaId = faId;
        //}
    }
}
