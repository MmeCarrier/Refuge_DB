using Domain.Commands.AnimalCommand;
using Domain.Commands.BenevoleCommande;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using RefugeManager.Api.Models.Dtos;
using Tools.Cqs.ToolResults;
using RefugeManagerShared.SharedDbContext;


namespace RefugeManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RefugeController : ControllerBase    
    {
        private readonly RefugeContext _refugeContext;
        public RefugeController(RefugeContext context)
        {
            _refugeContext = context;
        }
        [HttpPost("AjouterBenevole")]
        public IActionResult Post([FromBody] AjoutBenevoleDto benevoledto)
        {
            ICqsResult result = _refugeContext.Execute(new AjoutBenevole(benevoledto.Prenom, benevoledto.Nom, benevoledto.Tel, benevoledto.Adresse, benevoledto.EstResponsable, benevoledto.FormeFerme, benevoledto.FormeReptile, benevoledto.FormeContrat));
                if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpDelete("SupprimerBenevole")]
        public IActionResult Delete(string prenom)
        {
            ICqsResult result = _refugeContext.Execute(new SupprimerBenevole(prenom));
            if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpPut("ModifierBenevole")]
        public IActionResult Update(string prenom, [FromBody] UpdateBenevole dto)
        {
            ICqsResult result = _refugeContext.Execute(new UpdateBenevole(prenom, dto.Nom, dto.Tel, dto.Adresse, dto.EstResponsable,dto.FormeFerme ,dto.FormeReptile, dto.FormeContrat));
            if (result.IsFailure)
            { return BadRequest(result); }
            return NoContent();
        }
        [HttpPost("AjouterAnimal")]
        public IActionResult Post([FromBody] AjoutAnimalDto animaldto)
        {
            ICqsResult result = _refugeContext.Execute(new AjoutAnimal(animaldto.Nom, animaldto.Espece, animaldto.Age, animaldto.Sterilise, animaldto.MF, animaldto.PrimoVaccin, animaldto.VaccinComplet, animaldto.Provenance, animaldto.LieuProvenance, animaldto.Localisation, animaldto.Remarque));
            if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpPut("ModifierAnimal")]
        public IActionResult Update(string nom, [FromBody] UpdateAnimal animaldto)
        {
            ICqsResult result = _refugeContext.Execute(new UpdateAnimal(nom, animaldto.Espece, animaldto.Age, animaldto.Sterilise, animaldto.MF, animaldto.PrimoVaccin, animaldto.VaccinComplet, animaldto.Provenance, animaldto.LieuProvenance, animaldto.Localisation, animaldto.Remarque));
                if (result.IsFailure)
            { 
                return BadRequest(result);
            }
            return NoContent();
        }
    }
}
