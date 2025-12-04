using System.ComponentModel.DataAnnotations;

namespace RefugeManager.Api.Models.Dtos
{
    public class AjoutAnimalDto
    {
        public AjoutAnimalDto(string nom, string espece, string age, bool sterilise, bool mF, string primoVaccine, string vaccineComplet, string provenance, string lieuProvenance, string localisation, string remarque)
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
        public string PrimoVaccine { get; }
        public string VaccineComplet { get; }
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
