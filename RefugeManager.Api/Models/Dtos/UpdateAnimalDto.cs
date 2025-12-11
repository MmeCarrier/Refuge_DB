using System.ComponentModel.DataAnnotations;

namespace RefugeManager.Api.Models.Dtos
{
    public class UpdateAnimalDto
    {

        [StringLength(20, MinimumLength = 4)]
        public string Nom { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Espece { get; set; }
        public int? Age { get; set; }
        public bool MF { get; set; }
        public bool Sterilise { get; set; }
        [Required]
        public bool PrimoVaccin { get; set; }
        [Required]
        public bool VaccinComplet { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Provenance { get; set; }

        [StringLength(80, MinimumLength = 4)]
        public string LieuProvenance { get; set; }

        [StringLength(20, MinimumLength = 4)]
        public string Localisation { get; set; }

        [StringLength(20, MinimumLength = 10)]
        public string? Remarque { get; set; }
        public int SecteurId { get; set; }
        public int? FaId { get; set; }

        //public UpdateAnimalDto(string nom, string espece, int age, bool mF, bool primoVaccin, bool vaccinComplet, string provenance, string lieuProvenance, string localisation, string remarque, int secteurId, int faId)
        //{
        //    Nom = nom;
        //    Espece = espece;
        //    Age = age;
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
