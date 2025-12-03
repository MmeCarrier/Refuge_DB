using Domain.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;
using Tools.Cqs.ToolResults;

namespace Domain.Repositories
{
    public interface IRefugeRepository :        
        ICommandHandler<AjoutBenevole>,
        ICommandHandler<SupprimerBenevole>
    {
    }
}
