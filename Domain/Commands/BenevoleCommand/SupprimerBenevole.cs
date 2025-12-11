using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;

namespace Domain.Commands.BenevoleCommand
{
    public class SupprimerBenevole : ICommandDefinition
    {
        public string Prenom { get;}
        public SupprimerBenevole(string prenom)
        {
            Prenom = prenom;
        }
    }
}
