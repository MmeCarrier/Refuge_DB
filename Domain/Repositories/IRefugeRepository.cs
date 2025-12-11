using Domain.Commands.AnimalCommand;
using Domain.Commands.BenevoleCommand;
using Domain.Queries;
//using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;
using Tools.Cqs.ToolResults;
using RefugeManagerShared.SharedEntities;
using Tools.Cqs.ToolQueries;

namespace Domain.Repositories
{
    public interface IRefugeRepository :        
        ICommandHandler<AjoutBenevole>,
        ICommandHandler<SupprimerBenevole>,
        ICommandHandler<UpdateBenevole>,
        ICommandHandler<AjoutAnimal>,
        ICommandHandler<UpdateAnimal>,
        ICommandHandler<SupprimerAnimal>,
        IQueryHandler<GetAnimalByEspece, Animal>,
        IQueryHandler<GetAnimalByName, Animal>
    {
    }
}
