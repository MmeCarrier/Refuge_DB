using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Cqs.ToolCommands
{
    internal class ICommandHandler<TCommand>
        where TCommand : ICommandDefinition
    {
        ICqsResult Execute(TCommand command);
    }
}
