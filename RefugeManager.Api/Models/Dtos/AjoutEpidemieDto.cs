using System.ComponentModel.DataAnnotations;

namespace RefugeManager.Api.Models.Dtos
{
    public class AjoutEpidemieDto
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Maladie { get; set; }

        [Required]
        public DateTime DateDeclaration { get; set; }
       
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string EspeceConcernee { get; set; }

        public string EspecesVulnerables { get; set; }

        [Required]
        public int SecteurId { get; set; }
    }
}
