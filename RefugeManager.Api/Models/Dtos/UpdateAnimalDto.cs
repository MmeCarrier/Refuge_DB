using System.ComponentModel.DataAnnotations;

namespace RefugeManager.Api.Models.Dtos
{
    public class UpdateAnimalDto
    {
        public UpdateAnimalDto(string nom, string espece, int age, bool mF, bool primoVaccin, bool vaccinComplet, string provenance, string lieuProvenance, string localisation, string remarque)
        {
            Nom = nom;
            Espece = espece;
            Age = age;
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

        public int Age { get; }
        public bool MF { get; }
        [Required]
        public bool PrimoVaccin { get; }
        [Required]
        public bool VaccinComplet { get; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Provenance { get; }

        [StringLength(80, MinimumLength = 4)]
        public string LieuProvenance { get; }

        [StringLength(20, MinimumLength = 4)]
        public string Localisation { get; }

        [StringLength(20, MinimumLength = 10)]
        public string Remarque { get; }

    }
}
