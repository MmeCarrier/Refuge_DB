using Domain.Commands.AnimalCommand;
using Domain.Commands.BenevoleCommande;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using RefugeManager.Api.Models.Dtos;
using Tools.Cqs.ToolResults;

namespace RefugeManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RefugeController : ControllerBase    
    {
        private readonly IRefugeRepository _refugeRepository;
        public RefugeController(IRefugeRepository refugeRepository)
        {
            _refugeRepository = refugeRepository;
        }
        [HttpPost]
        public IActionResult Post([FromBody] AjoutBenevoleDto benevoledto)
        {
            ICqsResult result = _refugeRepository.Execute(new AjoutBenevole(benevoledto.Prenom, benevoledto.Nom, benevoledto.Tel, benevoledto.Adresse, benevoledto.EstResponsable, benevoledto.FormeFerme, benevoledto.FormeReptile, benevoledto.FormeContrat));
                if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpDelete]
        public IActionResult Delete(string prenom)
        {
            ICqsResult result = _refugeRepository.Execute(new SupprimerBenevole(prenom));
            if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpPut]
        public IActionResult Update(string prenom, [FromBody] UpdateBenevole dto)
        {
            ICqsResult result = _refugeRepository.Execute(new UpdateBenevole(prenom, dto.Nom, dto.Tel, dto.Adresse, dto.EstResponsable,dto.FormeFerme ,dto.FormeReptile, dto.FormeContrat));
            if (result.IsFailure)
            { return BadRequest(result); }
            return NoContent();
        }
        [HttpPost]
        public IActionResult Post([FromBody] AjoutAnimalDto animaldto)
        {
            ICqsResult result = _refugeRepository.Execute(new AjoutAnimal(animaldto.Nom, animaldto.Espece, animaldto.Age, animaldto.Sterilise, animaldto.MF, animaldto.PrimoVaccine, animaldto.VaccineComplet, animaldto.Provenance, animaldto.LieuProvenance, animaldto.Localisation, animaldto.Remarque));
            if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpPut]
        public IActionResult Update(string nom, [FromBody] UpdateAnimal animaldto)
        {
            ICqsResult result = _refugeRepository.Execute(new UpdateAnimal(nom, animaldto.Espece, animaldto.Age, animaldto.Sterilise, animaldto.MF, animaldto.PrimoVaccine, animaldto.VaccineComplet, animaldto.Provenance, animaldto.LieuProvenance, animaldto.Localisation, animaldto.Remarque));
                if (result.IsFailure)
            { 
                return BadRequest(result);
            }
            return NoContent();
        }
    }
}
