using Domain.Commands.AnimalCommand;
using Domain.Commands.BenevoleCommand;
using Domain.Commands.EpidemieCommand;
using Domain.Commands.FaCommand;
using Domain.Repositories;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using RefugeManager.Api.Models.Dtos;
using RefugeManagerShared.SharedDbContext;
using RefugeManagerShared.SharedEntities;
using Tools.Cqs.ToolResults;


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
        [HttpPut("ModifierBenevole")]
        public async Task<IActionResult> Update(string prenom, [FromBody] UpdateBenevoleDto benevoledto)
        {
            ICqsResult result = await _refugeService.Execute(new UpdateBenevole(prenom, benevoledto.Nom, benevoledto.Tel, benevoledto.Adresse, benevoledto.EstResponsable, benevoledto.FormeFerme, benevoledto.FormeReptile, benevoledto.FormeContrat, benevoledto.SecteurId, benevoledto.FaId));
            if (result.IsFailure)
            { return BadRequest(result); }
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

        //[HttpGet("secteur/{secteur}")]
        //public async Task<IActionResult> GetBySecteur(string secteur)
        //{
        //    ICqsResult<List<Benevole>> result = await _refugeService.GetBenevoleBySecteur(secteur);
        //    if (result.IsFailure)
        //    {
        //        return NotFound(result);
        //    }
        //    return Ok(result.Data);
        //}
        [HttpGet("prenom/{prenom}")]
        public async Task<IActionResult> GetByName(string prenom)
        {
            ICqsResult<List<Benevole>> result = await _refugeService.GetBenevolelByName(prenom);
            if (result.IsFailure)
            {
                return NotFound(result);
            }
            return Ok(result.Data);
        }
        [HttpPost("AjouterAnimal")]
        public async Task<IActionResult> Post([FromBody] AjoutAnimalDto animaldto)
        {
            ICqsResult result = await _refugeService.Execute(new AjoutAnimal(animaldto.Nom, animaldto.Espece, animaldto.Age, animaldto.Sterilise, animaldto.MF, animaldto.PrimoVaccin, animaldto.VaccinComplet, animaldto.Provenance, animaldto.LieuProvenance, animaldto.Localisation, animaldto.Remarque, animaldto.SecteurId));//, animaldto.FaId));
            if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpPut("ModifierAnimal")]
        public async Task<IActionResult> Update(string nom, [FromBody] UpdateAnimalDto animaldto)
        {
            ICqsResult result = await _refugeService.Execute(new UpdateAnimal(nom, animaldto.Espece, animaldto.Age, animaldto.Sterilise, animaldto.MF, animaldto.PrimoVaccin, animaldto.VaccinComplet, animaldto.Provenance, animaldto.LieuProvenance, animaldto.Localisation, animaldto.Remarque, animaldto.SecteurId, animaldto.FaId));
            if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpDelete("SupprimerAnimal")]
        public async Task<IActionResult> DeleteAnimal(string nom)
        {
            ICqsResult result = await _refugeService.Execute(new SupprimerAnimal(nom));
            if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
        [HttpGet("espece/{espece}")]
        public async Task<IActionResult> GetByEspece(string espece)
        {
            ICqsResult<List<Animal>> result = await _refugeService.GetAnimalByEspece(espece);
            if (result.IsFailure)
            {
                return NotFound(result);
            }
            return Ok(result.Data);
        }
        [HttpGet("nom/{nom}")]
        public async Task<IActionResult> GetBySurname(string nom)
        {
            ICqsResult<List<Animal>> result = await _refugeService.GetAnimalByName(nom);
            if (result.IsFailure)
            {
                return NotFound(result);
            }
            return Ok(result.Data);
        }
        [HttpPost("AjouterEpidemie")]
        public async Task<IActionResult> Post([FromBody] AjoutEpidemieDto epidemiedto)
        {
            ICqsResult result = await _refugeService.Execute(
                new AjoutEpidemie(
                    epidemiedto.Maladie,
                    epidemiedto.DateDeclaration,                    
                    epidemiedto.EspeceConcernee,
                    epidemiedto.EspecesVulnerables,
                    epidemiedto.SecteurId
                )
            );

            if (result.IsFailure)
            {
                return BadRequest(result);
            }

            return NoContent();
        }

        [HttpPost("CreerFa")]
        public async Task<IActionResult> CreerFa([FromBody] AjoutFaDto fadto)
        {
            ICqsResult result = await _refugeService.Execute(
                new AjoutFa(
                    fadto.BenevoleId,
                    fadto.AnimalId,
                    fadto.DateDebut)
                );
            if (result.IsFailure)
            {
                return BadRequest(result);
            }

            return NoContent();
        }

        [HttpPost("CloturerFa")]
        public async Task<IActionResult> CloturerFa([FromBody] CloturerFaDto cloturerdto)
        {
            ICqsResult result = await _refugeService.Execute(new CloturerFa(cloturerdto.FaId, cloturerdto.DateFin));
            if (result.IsFailure)
            {
                return BadRequest(result);
            }
            return NoContent();
        }
    }
}

        
    
    
        // CONTROLLER
        //   try
        //    {
        //        var animal = await _refugeService.GetAnimalByEspece
        //            .FirstOrDefaultAsync(a => a.Nom == nom);
        //        if (animal==null)
        //        {
        //            return CqsResult<Animal>.Failure("Animal introuvable");
        //        }
        //        return CqsResult<Animal>.Success(animal);
        //    }
        //    catch (Exception ex) {
        //        return CqsResult<Animal>.Failure($"Erreur: {ex.Message})");
        //}