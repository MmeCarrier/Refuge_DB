using System.ComponentModel.DataAnnotations;

namespace RefugeManager.Api.Models.Dtos
{
    public class AjoutAnimalDto
    {

        [StringLength(20, MinimumLength = 4)]
        public string Nom { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Espece { get; set; }
        [Range(1, int.MaxValue)]
        public int? Age { get; set; }
        [Required]
        public bool Sterilise { get; set; }
        public bool MF { get; set; } = false;
        public bool PrimoVaccin { get; set; } = false;
        public bool VaccinComplet { get; set; } = false;
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Provenance { get; set; }

        [StringLength(80, MinimumLength = 4)]
        public string LieuProvenance { get; set; }
        [Required]
        public string Localisation {get; set; }
        [StringLength(20, MinimumLength = 10)]
        public string? Remarque { get; set; }
        public int SecteurId { get; set; }
        public int? FaId { get; set; }
        //public AjoutAnimalDto(string nom, string espece, string age, bool sterilise, bool mF, bool primoVaccin, bool vaccinComplet, string provenance, string lieuProvenance, string localisation, string remarque, int secteurId, int faId)
        //{
        //    Nom = nom;
        //    Espece = espece;
        //    Age = age;
        //    Sterilise = sterilise;
        //    MF = mF;
        //    PrimoVaccin = primoVaccin;
        //    VaccinComplet = vaccinComplet;
        //    Provenance = provenance;
        //    LieuProvenance = lieuProvenance;
        //    Localisation = localisation;
        //    Remarque = remarque;
        //    SecteurId = secteurId;
        //    FaId = faId;
        //}
    }
}
