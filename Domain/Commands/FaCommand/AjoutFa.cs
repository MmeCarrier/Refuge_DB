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
        public AjoutFa(int benevoleId, int animalId, DateTime dateDebut)
        {
            BenevoleId = benevoleId;
            AnimalId = animalId;
        }

        public int BenevoleId { get; } // rien de nullable ici, quand on créé une Fa on est certains d'avoir un benevole et un animal.
        public int AnimalId { get; }
        public DateTime DateDebut { get; }
    }
}
