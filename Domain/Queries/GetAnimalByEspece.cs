using RefugeManagerShared.SharedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolQueries;

namespace Domain.Queries
{
    public class GetAnimalByEspece : IQueryDefinition<Animal>
    {
        public string Espece { get; }
        public GetAnimalByEspece(string espece)
        {
            Espece = espece;
        }
    }
}
