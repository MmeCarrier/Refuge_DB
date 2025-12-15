using Domain.Commands.AnimalCommand;
using Domain.Commands.BenevoleCommand;
using Domain.Commands.EpidemieCommand;
using Domain.Commands.FaCommand;
using Domain.Mappers;
using Domain.Queries;


//using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using RefugeManagerShared.SharedDbContext;
using RefugeManagerShared.SharedEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;
using Tools.Cqs.ToolResults;
using Tools.Database;


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
                    command.SecteurId
                    //command.FaId
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
        public async Task<ICqsResult> Execute(UpdateBenevole command)
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
                //benevole.FaId = command.FaId;


                await _refugeContext.SaveChangesAsync();
                return CqsResult.Success();
            }
            catch (Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }
        }

        public async Task<ICqsResult<List<Benevole>>> GetBenevolelByName(string prenom)
        {
            try
            {
                var benevole = await _refugeContext.Benevole
                    .Where(a => a.Prenom == prenom)
                    .ToListAsync();

                if (!benevole.Any())
                {
                    return CqsResult<List<Benevole>>.Failure("Benevole introuvable");
                }
                return CqsResult<List<Benevole>>.Success(benevole);
            }
            catch (Exception)
            {
                return CqsResult<List<Benevole>>.Failure("Benevole introuvable");
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
                    command.SecteurId
                    //command.FaId
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
                animal.SecteurId = command.SecteurId;
                //animal.FaId = command.FaId;

                await _refugeContext.SaveChangesAsync();
                return CqsResult.Success();
            }
            catch (Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }
                            
        }

        public async Task<ICqsResult> Execute(SupprimerAnimal command)
        {
            try
            {
                var animal = await _refugeContext.Animal
                .FirstOrDefaultAsync(b => b.Nom == command.Nom);

                if (animal == null)
                {
                    return CqsResult.Failure("Animal à supprimer introuvable");
                }
                _refugeContext.Animal.Remove(animal);
                await _refugeContext.SaveChangesAsync();
                return CqsResult.Success();
            }

            catch (Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }

        }
        public async Task<ICqsResult<List<Animal>>> GetAnimalByEspece(string espece)
        {
            try
            {
                var animal = await _refugeContext.Animal
                    .Where(a => a.Espece == espece)
                    .ToListAsync();

                if (!animal.Any())
                {
                    return CqsResult<List<Animal>>.Failure("Animal introuvable");
                }
                return CqsResult<List<Animal>>.Success(animal);
            }
            catch (Exception)
            {
                return CqsResult<List<Animal>>.Failure("Animal introuvable");
            }
             
        }
        public async Task<ICqsResult<List<Animal>>> GetAnimalByName(string nom)
        {
            try
            {
                var animal = await _refugeContext.Animal
                    .Where(a => a.Nom == nom)
                    .ToListAsync();

                if (!animal.Any())
                {
                    return CqsResult<List<Animal>>.Failure("Animal introuvable");
                }
                return CqsResult<List<Animal>>.Success(animal);
            }
            catch (Exception)
            {
                return CqsResult<List<Animal>>.Failure("Animal introuvable");
            }

        }

        public async Task<ICqsResult> Execute(AjoutEpidemie command)
        {
            try
            {
                var epidemie = new Epidemie
                (
                    command.Maladie,
                    command.DateDeclaration,                    
                    command.EspeceConcernee,
                    command.EspecesVulnerables,
                    command.SecteurId
                );

                await _refugeContext.Epidemie.AddAsync(epidemie);
                await _refugeContext.SaveChangesAsync();
                return CqsResult.Success();
            }
            catch (Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }
        }

        public async Task<ICqsResult> Execute(AjoutFa command)
        {
            try
            {
                var fa = new Fa(command.BenevoleId, command.AnimalId);

                await _refugeContext.Fa.AddAsync(fa);
                await _refugeContext.SaveChangesAsync();

                return CqsResult.Success();
            }
            catch (Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }
        }




        //    try
        //    {
        //        Animal? animal = _refugeContext.Execute("SELECT [Id], [Nom], [Espece], [Age], [MF], [Sterilise], [PrimoVaccin], [VaccinComplet], [Provenance], [LieuProvenance], [Localisation], [SecteurId],[FaId] FROM [Animal] WHERE Espece = @Espece;", dr => dr.ToAnimal(), parameters: query).SingleOrDefault();

        //        if (animal is null)
        //            return CqsResult<Animal>.Failure("Animal introuvable");
        //        return CqsResult<Animal>.Success(animal);
        //    }
        //    catch (Exception ex)
        //    {
        //        return CqsResult<Animal>.Failure(ex.Message);
        //    }
        //}


    }
}

