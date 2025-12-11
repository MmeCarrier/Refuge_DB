using Domain.Commands.AnimalCommand;
using Domain.Commands.BenevoleCommande;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using RefugeManager.Api.Models.Dtos;
using Tools.Cqs.ToolResults;
using RefugeManagerShared.SharedDbContext;
using Domain.Services;


namespace RefugeManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RefugeController : ControllerBase    
    {
        private readonly RefugeService _refugeService;
        public RefugeController(RefugeService refugeService)
        {
            _refugeService = refugeService;
        }
        [HttpPost("AjouterBenevole")]
        public async Task<IActionResult> Post([FromBody] AjoutBenevoleDto benevoledto)
        {
            ICqsResult result = await _refugeService.Execute(new AjoutBenevole(benevoledto.Prenom, benevoledto.Nom, benevoledto.Tel, benevoledto.Adresse, benevoledto.EstResponsable, benevoledto.FormeFerme, benevoledto.FormeReptile, benevoledto.FormeContrat, benevoledto.SecteurId, benevoledto.FaId));
                if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpDelete("SupprimerBenevole")]
        public async Task<IActionResult> Delete(string prenom)
        {
            ICqsResult result = await _refugeService.Execute(new SupprimerBenevole(prenom));
            if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpPut("ModifierBenevole")]
        public async Task<IActionResult> Update(string prenom, [FromBody] Models.Dtos.UpdateBenevoleDto benevoledto)
        {
            ICqsResult result = await _refugeService.Execute(new Domain.Commands.BenevoleCommande.UpdateBenevoleDto(prenom, benevoledto.Nom, benevoledto.Tel, benevoledto.Adresse, benevoledto.EstResponsable, benevoledto.FormeFerme, benevoledto.FormeReptile, benevoledto.FormeContrat, benevoledto.SecteurId, benevoledto.FaId));
            if (result.IsFailure)
            { return BadRequest(result); }
            return NoContent();
        }
        [HttpPost("AjouterAnimal")]
        public async Task<IActionResult> Post([FromBody] AjoutAnimalDto animaldto)
        {
            ICqsResult result = await _refugeService.Execute(new AjoutAnimal(animaldto.Nom, animaldto.Espece, animaldto.Age, animaldto.Sterilise, animaldto.MF, animaldto.PrimoVaccin, animaldto.VaccinComplet, animaldto.Provenance, animaldto.LieuProvenance, animaldto.Localisation, animaldto.Remarque, animaldto.SecteurId, animaldto.FaId));
            if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpPut("ModifierAnimal")]
        public async Task<IActionResult> Update(string nom, [FromBody] UpdateAnimal animaldto)
        {
            ICqsResult result = await _refugeService.Execute(new UpdateAnimal(nom, animaldto.Espece, animaldto.Age, animaldto.Sterilise, animaldto.MF, animaldto.PrimoVaccin, animaldto.VaccinComplet, animaldto.Provenance, animaldto.LieuProvenance, animaldto.Localisation, animaldto.Remarque, animaldto.SecteurId, animaldto.FaId));
                if (result.IsFailure)
            { 
                return BadRequest(result);
            }
            return NoContent();
        }
    }
}
