using Domain.Commands.AnimalCommand;
using Domain.Commands.BenevoleCommande;
//using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;
using Tools.Cqs.ToolResults;
using RefugeManagerShared.SharedEntities;

namespace Domain.Repositories
{
    public interface IRefugeRepository :        
        ICommandHandler<AjoutBenevole>,
        ICommandHandler<SupprimerBenevole>,
        ICommandHandler<UpdateBenevoleDto>,
        ICommandHandler<AjoutAnimal>,
        ICommandHandler<UpdateAnimal>
    {
    }
}
