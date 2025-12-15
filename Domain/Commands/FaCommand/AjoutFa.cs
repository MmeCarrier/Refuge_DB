using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;

namespace Domain.Commands.FaCommand
{
    public class AjoutFa : ICommandDefinition
    {
        public AjoutFa(int? benevoleId, int? animalId)
        {
            BenevoleId = benevoleId;
            AnimalId = animalId;
        }

        public int? BenevoleId { get; }
        public int? AnimalId { get; }
    }
}
