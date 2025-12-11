using RefugeManagerShared.SharedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolQueries;

namespace Domain.Queries
{
    public class GetAnimalByName : IQueryDefinition<Animal>
    {
        public string Nom { get; }
        public GetAnimalByName(string nom)
        {
            Nom = nom;
        }
    }
}
