using System.ComponentModel.DataAnnotations;

namespace RefugeManager.Api.Models.Dtos
{
    public class AjoutAnimalDto
    {
        public AjoutAnimalDto(string nom, string espece, string age, bool sterilise, bool mF, bool primoVaccin, bool vaccinComplet, string provenance, string lieuProvenance, string localisation, string remarque)
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
        }

        [StringLength(20, MinimumLength = 4)]
        public string Nom { get; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Espece { get; }
        [Range(1, int.MaxValue)]
        public string Age { get; }
        [Required]
        public bool Sterilise { get; }
        public bool MF { get; }
        public bool PrimoVaccin { get; }
        public bool VaccinComplet { get; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Provenance { get; }

        [StringLength(80, MinimumLength = 4)]
        public string LieuProvenance { get; }
        [Required]
        public string Localisation {get;}
        [StringLength(20, MinimumLength = 10)]
        public string Remarque { get; }
    }
}
