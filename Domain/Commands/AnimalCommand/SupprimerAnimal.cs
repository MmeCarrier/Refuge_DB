using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;

namespace Domain.Commands.AnimalCommand
{
    public class SupprimerAnimal : ICommandDefinition
    {
        public string Nom { get; }
        public SupprimerAnimal(string nom)
        {  Nom = nom; }

    }
}
