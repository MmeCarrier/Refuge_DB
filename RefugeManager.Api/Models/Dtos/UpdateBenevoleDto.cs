using System.ComponentModel.DataAnnotations;

namespace RefugeManager.Api.Models.Dtos
{
    public class UpdateBenevoleDto
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Prenom { get; }
        public string? Nom { get; }
        [Required]
        [StringLength(15, MinimumLength = 10)]
        public string? Tel { get; }
        public string? Adresse { get; }
        [Required]
        public bool EstResponsable { get; } = false;
        [Required]
        public bool FormeFerme { get; } = false;
        [Required]
        public bool FormeReptile { get; } = false;
        [Required]
        public bool FormeContrat { get; } = false;

        public UpdateBenevoleDto(string prenom, string nom, string tel, string adresse, bool estResponsable, bool formeFerme, bool formeReptile, bool formeContrat)
        {
            Prenom = prenom;
            Nom = nom;
            Tel = tel;
            Adresse = adresse;
            EstResponsable = estResponsable;
            FormeFerme = formeFerme;
            FormeReptile = formeReptile;
            FormeContrat = formeContrat;
        }
    }
}
