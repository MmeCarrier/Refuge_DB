using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tools.Cqs.ToolCommands;

namespace Domain.Commands.FaCommand
{
    public class CloturerFa : ICommandDefinition
    {
        public CloturerFa(int faId, DateTime dateFin) 
        {
            FaId = faId;
            DateFin = dateFin;
        }
        public int FaId { get; }
        public DateTime DateFin { get; }
    }
}
