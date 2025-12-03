using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;

namespace Domain.Commands
{
    public class SupprimerBenevole : ICommandDefinition
    {
        public SupprimerBenevole(int id)
        {
            id = Id;
        }
        public int Id { get;}
    }
}
