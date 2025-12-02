using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolResults;

namespace Tools.Cqs.ToolCommands
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommandDefinition
    {
        ICqsResult Execute(TCommand command);
    }
}
