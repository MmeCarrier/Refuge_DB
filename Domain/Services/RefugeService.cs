using Domain.Commands.AnimalCommand;
using Domain.Commands.BenevoleCommande;
//using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;
using Tools.Cqs.ToolResults;
using Tools.Database;
using RefugeManagerShared.SharedEntities;
using RefugeManagerShared.SharedDbContext;
using Microsoft.EntityFrameworkCore;


namespace Domain.Services
{
    public class RefugeService
    {
        private readonly RefugeContext _refugeContext;

        public RefugeService(RefugeContext refugeContext)
        {
            _refugeContext = refugeContext;
            //if (_dbConnection.State is not System.Data.ConnectionState.Open)
            //{
              //  _dbConnection.Open();
            //}
        }



        public async Task<ICqsResult> Execute(AjoutBenevole command)
        {
            try
            {
                var benevole = new Benevole
                (

                    command.Prenom,
                    command.Nom,
                    command.Tel,
                    command.Adresse,
                    command.EstResponsable,
                    command.FormeFerme,
                    command.FormeReptile,
                    command.FormeContrat,
                    command.SecteurId,
                    command.FaId
                );

                await _refugeContext.Benevole.AddAsync(benevole);
                await _refugeContext.SaveChangesAsync();
                return CqsResult.Success();
            }
            catch (Exception ex)
            { 
                return CqsResult.Failure(ex.Message); 
            }
          
        }

        public async Task<ICqsResult> Execute(SupprimerBenevole command)
        {
            try
            {
                var benevole = await _refugeContext.Benevole
                .FirstOrDefaultAsync(b => b.Prenom == command.Prenom);

                if (benevole == null)
                { 
                  return CqsResult.Failure("Benevole à supprimer introuvable");                
                }
                    _refugeContext.Benevole.Remove(benevole);
                    await _refugeContext.SaveChangesAsync();
                    return CqsResult.Success();
            }

            catch (Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }

        }
        public async Task<ICqsResult> Execute(UpdateBenevoleDto command)
        {
            try
            {
                var benevole = await _refugeContext.Benevole
                    .FirstOrDefaultAsync(b => b.Prenom == command.Prenom);
                if (benevole == null)
                {
                    return CqsResult.Failure("Benevole à modifier introuvable");
                }

                benevole.Prenom = command.Prenom;
                benevole.Nom = command.Nom;
                benevole.Tel = command.Tel;
                benevole.Adresse = command.Adresse;
                benevole.FormeFerme = command.FormeFerme;
                benevole.EstResponsable = command.EstResponsable;
                benevole.FormeReptile = command.FormeReptile;
                benevole.FormeContrat = command.FormeContrat;
                benevole.SecteurId = command.SecteurId;
                benevole.FaId = command.FaId;


                await _refugeContext.SaveChangesAsync();
                return CqsResult.Success();
            }
            catch (Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }
        }
        public async Task<ICqsResult> Execute(AjoutAnimal command)
        {
            try
            {
                var animal = new Animal
                (                                       
                    command.Nom,
                    command.Espece,
                    command.Age,
                    command.MF,
                    command.Sterilise,
                    command.PrimoVaccin,
                    command.VaccinComplet,
                    command.Provenance,
                    command.LieuProvenance,
                    command.Localisation,
                    command.Remarque,
                    command.SecteurId,
                    command.FaId
                );

                await _refugeContext.Animal.AddAsync(animal);
                await _refugeContext.SaveChangesAsync();
                return CqsResult.Success();
            }
            catch (Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }
        }

        public async Task<ICqsResult> Execute(UpdateAnimal command)
        {
            try
            {
                var animal = _refugeContext.Animal
                    .FirstOrDefault(a => a.Nom == command.Nom);
                if (animal == null)
                {
                  return CqsResult.Failure("Animal à modifier introuvable");          
                }
                animal.Nom = command.Nom;
                animal.Espece = command.Espece;
                animal.Age = command.Age;
                animal.MF = command.MF;
                animal.Sterilise = command.Sterilise;
                animal.PrimoVaccin = command.PrimoVaccin;
                animal.Vaccincomplet = command.VaccinComplet;
                animal.Provenance = command.Provenance;
                animal.LieuProvenance = command.LieuProvenance;
                animal.Localisation = command.Localisation;
                animal.Remarque = command.Remarque;

                await _refugeContext.SaveChangesAsync();
                return CqsResult.Success();
            }
            catch (Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }
    
     
        }  
    }
}

